using System;
/*
- lỗi phát sinh trong chương trình CS
- bắt lỗi Exception với try-catch
- bắt nhiều lỗi Exception cụ thể
- xây dựng và phát sinh ngoại lệ Exception
Các đối tượng như: DiviedByZeroException, IndexOutOfRangeException, ... đều là các lớp kế thừa từ lớp cơ sở Exception
*/
namespace CS038_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            // float a = 5;
            // int a1 = 6;
            // int b = 0;
            // var c = a / b;
            // var d = a1 / b;
            // Console.WriteLine(c); // ouput = inf
            // Console.WriteLine(d); // output = lỗi Exception

            int a = 5;
            int b = 0;

            // khối lệnh try - catch:
            try
            {
                // e
                var c = a / b;
                Console.WriteLine(c);

                // e1
                int[] i = { 1, 2, 3 };
                var x = i[5];


            }
            // muốn biết lỗi phát sinh ngoại lệ là gì thì đưa đối tượng Exception vào catch
            catch (DivideByZeroException e)
            /* 
            đưa vào catch đối tượng Exception cơ sở (lỗi ngoại lệ chung chung)  
            nếu chỉ muốn bắt đối tượng ngoại lệ cụ thể thì ta có thể điền vào catch lỗi cụ thể của ví dụ này là:
            catch (DivideByZeroException e) -> lỗi chia cho 0 (hoặc nhiều lỗi khác nữa tuỳ thuộc vào chương trình)
            */
            {
                Console.WriteLine(e.Message); // thông báo ngắn gọn về lỗi phát sinh - ouput: "Attempted to divide by zero."
                Console.WriteLine(e.StackTrace); // đưa ra vị trí phát sinh lỗi - mô tả đường đi dẫn đến lỗi
                Console.WriteLine(e.GetType().Name); // đưa ra tên lớp của ngoại lệ 
                Console.WriteLine("Phep chia co loi");
            }
            // thêm nhiều các khối catch để bắt được nhiều lỗi hơn:
            catch (IndexOutOfRangeException e1)
            {
                Console.WriteLine(e1.Message); // lỗi về chỉ số index 
                Console.WriteLine("Chi so mang khong phu hop");
            }
            catch (Exception e2) // thông báo các lỗi khác không xác định
            {
                Console.WriteLine(e2.Message); 
            }



            // bắt lỗi mở file:
            string path = "1.txt"; // khởi tạo một file không tồn tại. (path = null)
            try
            {
                string s = File.ReadAllText(path);
                Console.WriteLine(s);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message); // nếu file không tồn tại sẽ chỉ rõ đường dẫn file không tồn tại đó
                Console.WriteLine("File khong ton tai");
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
                Console.WriteLine("Duong dan file phai khac null"); // nếu path = null sẽ phát hiện được lỗi này
            }
            catch (Exception e)
            // gõ lệnh "chmod -r 1.txt" vào terminal để hiển thị một lỗi khác với 2 lỗi trên (lỗi không được phép đọc)
            {
                Console.WriteLine(e.Message);
            }












            // dòng lệnh này để cho biết rằng chương trình đã không thực thi khối try -> không phát sinh lỗi
            Console.WriteLine("Day la dong cuoi cua chuong trinh - ket thuc");
        }
    }
}
/*
Ứng dụng quản lý kho - Yêu cầu nghiệp vụ và các đối tượng của hệ thống:
- Các đối tượng của hệ thống:
    + admin 
    + nhân viên 
    + sản phẩm
    + đối tác 
- Admin:
    + CRUD nhân viên
        . thêm, xoá tài khoản nhân viên
        . sửa id, tên, địa chỉ, mail, ... 
    + CRUD đối tác (bên nhập/xuất hàng)
- Nhân viên:
    + Info nhân viên:
        . liên lạc (sđt, mail) 
        . giới tính
        . địa chỉ 
	+ CRUD sản phẩm
    + Các thao tác với sản phẩm:
        . CRUD sản phẩm
        . Phân chia (sort) loại hàng (quần áo - theo size, theo hãng, theo mùa, theo giá, ...)
        . 
	+ nhận phiếu nhập:
		
        . người lập phiếu (id nhân viên, tên nhân viên)
	+ làm phiếu xuất:
		
        . người lập phiếu (id nhân viên, tên nhân viên)
    + không xem được báo cáo thống kê/doanh thu
- Phiếu nhập:
    + phiếu nhập:
        . id sản phẩm nhập
		. ngày nhập hàng
    + Thông tin phiếu nhập: 
        . id/tên nhà cung cấp
		. tên sản phẩm nhập
        . số lượng hàng nhập vào
        . tình trạng hàng
		. tổng giá trị hàng hoá 
- Phiếu xuất:
    + phiếu xuất:
        . id sản phẩm xuất
        . ngày xuất hàng
    + Thông tin phiếu xuất:
        . id/tên khách hàng nhận
        . tên sản phẩm xuất
        . số lượng hàng xuất ra
        . tình trạng hàng
        . tổng giá trị hàng hoá 
- Sản phẩm:
    + CRUD sản phẩm 
    + id sản phẩm
    + tên sản phẩm
    + nguồn nhập (công ty abc -> khi bấm vào "nguồn nhập" sẽ hiển thị info công ty abc)
- Nhà cung cấp:
    + CRUD NCC (do nhân viên/admin điều hành)
    + id NCC
    + tên NCC
    + thông tin liên lạc (địa chỉ, sđt, mail)

- Đối tượng cập nhật dữ liệu:
    + cập nhật lại các đối tượng dạng số lượng, ngày tháng, ...
- Khách hàng (nếu có)

*/

























