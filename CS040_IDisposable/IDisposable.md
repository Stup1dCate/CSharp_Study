# 1. IDisposable là gì?
IDisposable là một interface có sẵn trong .NET (namespace: System).
Nó chỉ có một phương thức duy nhất:

public interface IDisposable
{
    void Dispose();
}

Mục đích: Cung cấp cách giải phóng tài nguyên mà một object sử dụng (nhất là unmanaged resources – tài nguyên ngoài .NET quản lý, ví dụ: file handle, kết nối DB, socket, stream…).

# 2. Vì sao cần IDisposable?

Trong .NET, bộ dọn rác (Garbage Collector) sẽ tự động giải phóng managed objects (các object thuần .NET).
Nhưng GC không biết cách giải phóng unmanaged resources (file đang mở, kết nối DB, GDI+ handle…).
Dispose() cho phép lập trình viên tự kiểm soát việc giải phóng tài nguyên này.

Ví dụ: nếu mở file bằng FileStream mà không đóng => file sẽ bị khóa cho đến khi chương trình kết thúc.

# 3. Cách cài đặt IDisposable

Ví dụ:

public class MyResource : IDisposable
{
    private bool disposed = false;

    public void DoWork()
    {
        if (disposed) throw new ObjectDisposedException("MyResource");
        Console.WriteLine("Đang làm việc...");
    }

    public void Dispose()
    {
        if (!disposed)
        {
            Console.WriteLine("Giải phóng tài nguyên...");
            // Giải phóng unmanaged resources ở đây
            disposed = true;
        }
    }
}

# 4. Sử dụng với using

Khi một class implement IDisposable, ta có thể dùng using:

using (MyResource resource = new MyResource())
{
    resource.DoWork();
} // <-- Tự động gọi resource.Dispose() ở cuối block


=> using đảm bảo Dispose() luôn được gọi, kể cả khi có exception xảy ra.

# 5. Mẫu triển khai đầy đủ (Dispose Pattern)

Với class phức tạp (kế thừa, unmanaged resources), ta theo mẫu chuẩn Microsoft:

public class MyResource : IDisposable
{
    private IntPtr handle; // unmanaged resource (ví dụ)
    private bool disposed = false;

    public MyResource(IntPtr h)
    {
        handle = h;
    }

    // Hàm Dispose do người dùng gọi
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this); // Ngăn GC gọi Finalizer nữa
    }

    // Dispose thật sự
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Giải phóng managed resources
            }

            // Giải phóng unmanaged resources
            if (handle != IntPtr.Zero)
            {
                // free(handle)
                handle = IntPtr.Zero;
            }

            disposed = true;
        }
    }

    // Finalizer (dùng khi lập trình viên quên Dispose)
    ~MyResource()
    {
        Dispose(false);
    }
}

