using System;
using System.IO;
using myException;

namespace CS039_Exception_1
{
    class Program
    {
        // có thể tạo các lớp kế thừa từ file thư viện mã nguồn riêng
        static void Register(string name, int age)
        {
            if (string.IsNullOrEmpty(name)) // kiểm tra tên rỗng hoặc không tên
            {
                // Exception exception = new Exception("Ten phai khac rong");
                // throw exception; // phát ra ngoại lệ này nếu có (chương trình sẽ dừng ở đây hành động này thực hiện)
                throw new NameEmptyException(); // thực hiện chức năng của hàm NameEmptyException() nếu thoả mãn điều kiện kiểm tra tương ứng
            }

            if (age < 18 || age > 60)
            {
                // throw new Exception("Tuoi phai >= 18 va <= 60");
                throw new AgeException(age);
            }

            //...
            Console.WriteLine($"Xin chao {name}, {age} tuoi");
        }
        static void Main(string[] args)
        {
            try
            {
                Register("Supperman", 12); // (null, 12);
                // Register("", 12);           // TH2
                // Register("Supperman", 21);  // TH3
            }
            catch (NameEmptyException nee)
            {
                Console.WriteLine(nee.Message); // bắt trực tiếp trong main
            }
            catch (AgeException e) // bắt lỗi với tuổi
            {
                Console.WriteLine(e.Message);
                e.Detail();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // thêm try-catch để kiểm tra lỗi phát sinh từ hàm Register
            }
        }
    }
}