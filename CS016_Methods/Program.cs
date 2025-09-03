using System;
// CÚ PHÁP KHAI BÁO: 
/* <Access Modifiers> <return type> <name_method> (<paramaters>) 
{ 
    // Các câu lệnh trong phương thức 
} 
*/
namespace bai16_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            xinchao();
            // Gọi phương thức với namespace đầy đủ: bai16_Methods.Program.xinchao();

            // Gọi phương thức tich
            int result = tich(5, 7);
            Console.WriteLine("Ket qua tich: " + result);

            // Khai báo phương thức lớp Tinhtoan.cs nằm cùng thư mục với Program(chương trình chính)
            // int x = 123, y = 456; để truyền vào
            var result_1 = Tinhtoan.Tong(123, 456);
            Console.WriteLine(result_1);


            // QUÁ TẢI PHƯƠNG THỨC (METHOD OVERLOADING) - phương thức cùng tên khác tham số
            float a = 12.12f;
            float b = 10.2f;
            var result_2 = Tinhtoan.Tong(a, b);
            Console.WriteLine(result_2);

            // TRUYỀN THAM SỐ VỚI STRING:
            // hoTen("Tung", "Vu");
            // hoTen(ho: "Vu Ngoc", ten: "Tung");
            hoTen("Tung");
            hoTen("Tung", "Vu"); // vẫn có thể thay đổi "ho" khi đã được khởi tạo trước

            // THAM CHIẾU - THAM TRỊ
            int x = 5;
            Power(x); // giá trị của biển x được gán = 5, sau khi nó làm tham số của phương thức Power thì giá trị của x vẫn là 5 => không có sự thay đổi gì
            Console.WriteLine(x); // tham số ban đầu sau khi bình phương không thay đổi gì
            Power_1(ref x); // thêm ref để lấy trực tiếp giá trị x ban đầu
            Console.WriteLine(x); // giá trị x khi này đã được gán = bình phương của nó (x = 25)
            // dùng "out" -> chỉ để xuất giá trị ra
            int y;
            Power_2(4,out y);
            Console.WriteLine(y);
        }

        // phương thức không trả về (void)
        public static void xinchao()
        {
            Console.WriteLine("Hello World");
        }

        // phương thức trả về int
        static int tich(int a, int b)
        {
            int result;
            result = a * b;
            return result;
        }

        // phương thức trả về string
        static void hoTen(string ten, string ho = "Nguyen") // giả sử chương trình cho sẵn ho = "Nguyen" thì chỉ cần nhập tên
        {
            string fullName;
            fullName = ho + " " + ten;
            Console.WriteLine($"Xin chao {fullName}");
        }

        // Tham số - tham trị
        static void Power(int x) // biến x trong Power (biến cục bộ được khởi tạo) và biến x được khởi tạo ban đầu là khác nhau
        {
            x = x * x;
            Console.WriteLine(x);
        }

        static void Power_1(ref int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }
        static void Power_2(int x, out int result_3)
        {
            result_3 = x * x;
        }
        

    }
}









