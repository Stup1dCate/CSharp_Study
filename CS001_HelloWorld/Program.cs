/*
Console.Write(); 
Xuất dữ liệu, (Giá trị) có thể là chuỗi ký tự, số.

Console.WriteLine(); 
Giống lệnh trên, sau khi in giá trị ra màn hình thì hệ thống sẽ đặt con trỏ xuống dòng tiếp theo. *Tức nghĩa là viết ra rồi xuống dòng*

Console.ReadLine(); 
Đặt cuối chương trình để dừng màn hình chương trình lại. *Nếu không chương trình sẽ chạy xong rồi tự tắt.*

Console.ReadKey();
Không truyền gì vào trong ngoặc -> mặc định false
    + Console.ReadKey(false) -> hiển thị phím ấn lên màn hình -> Thường dùng để tạm dừng chương trình chờ người dùng nhấn một phím.
    + Console.ReadKey(true) -> không hiển thị phím ấn lên màn hình -> Thường dùng trong các trường hợp nhập mật khẩu hoặc kiểm tra thao tác bàn phím ẩn.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Xuất ra tiếng Việt
            // Console.Write => viết và bỏ con trỏ chuột ở cuối dòng
            Console.WriteLine("Hello World"); // viết và xuống dòng
            Console.WriteLine("Xin chào Việt Nam");
            Console.WriteLine(200);
            //Console.ReadLine(); // dừng màn hình chương trình lại
            Console.ReadKey(); 
        }
    }
}
