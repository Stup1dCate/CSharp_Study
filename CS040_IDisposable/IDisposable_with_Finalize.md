# 6. Triển khai IDisposable cùng với hàm Hủy (Finalize)
- Hàm hủy - phương thức hủy (còn gọi là Finalize) như trình bày ở mục phương thức hủy (Finalize), nó là phương thức tự động chạy khi đối tượng không còn tham chiếu - và cũng dùng nó để viết code giải phóng tài nguyên

- Vấn đề xảy ra khi một lớp vừa có hàm hủy vừa có Dispose() - tức triển khai IDisposable là: thao tác giải phóng tài nguyên có thể thực hiện hai lần - một lần khi ra khỏi using - một lần đối tượng mất tham chiếu. Hoặc khi đối tượng chủ động gọi Dispose nhiều lần. Điều này có thể dẫn đến lỗi.

- Cách giải quyết là cần có biến lưu lại trạng thái cho biết Dispose đã được thi hành hay chưa.

Ví dụ: một lớp WriteData có triển khai IDisposable có thể cần giải phóng một số tài nguyên nó chiếm giữ không quản lý được bởi .NET,
WriteData cũng có sử dụng đối tượng lớp StreamWriter, đối tượng này cũng triển khai IDisposable, nên nó cần gọi thủ công Dispose() của nó khi không còn dùng đến nữa.

public class WriteData : IDisposable {

    // trường lưu trạng thái Dispose
    private bool m_Disposed = false;
    private StreamWriter stream;
    
    public WriteData (string filename) {
        stream = new StreamWriter (filename, true);
    }

    // Phương thức triển khai từ giao diện
    public void Dispose () {
        Dispose (true);
        GC.SuppressFinalize (this);
    }

    /* 
    Nếu disposing = true -> Được thi hành do gọi trực tiếp (do Dispose gọi)
    tài nguyên managed, unmanaged được giải phóng
    nếu disposing = fale -> Được thi hành bởi phương thức hủy, chỉ cần giải phóng
    các toàn nguyên unmanaged.
    */
    protected virtual void Dispose (bool disposing) {
        if (!m_Disposed) {
            if (disposing) {
                // các đối tượng có Dispose gọi ở đây
                stream.Dispose();
            }
            // giải phóng các tài nguyên không quản lý được cửa lớp (unmanaged)
            m_Disposed = true;
        }
    }
    ~WriteData () {
        Dispose(false);
    }

}

=> Mẫu trên ta có thể áp dụng cho bất ký lớp nào muốn triển khai IDisposable, lúc đó ta sử dụng using hay không using nó đều hoạt động đúng logic

- Sử dụng với using, hết lệnh Dispose sẽ thi hành và mọi tài nguyên được giải phóng

    using (WriteData writeData = new WriteData("filename.txt")) {
        // do something
    }

- Nếu không dùng using, thì chủ động gọi Dispose, tài nguyên cũng giải phóng đúng yêu cầu.

    WriteData writeData = new WriteData("filename.txt");
    //do something
    writeData.Dispose();