using System;
/*
- lỗi phát sinh trong chương trình CS
- bắt lỗi Exception với try-catch
- bắt nhiều lỗi Exception cụ thể
- xây dựng và phát sinh ngoại lệ Exception
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
                var c = a / b;
                Console.WriteLine(c);
            }
            // muốn biết lỗi phát sinh ngoại lệ là gì thì đưa đối tượng Exception vào catch
            catch (Exception e)
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

            // dòng lệnh này để cho biết rằng chương trình đã không thực thi khối try -> không phát sinh lỗi
            Console.WriteLine("Day la dong cuoi cua chuong trinh - ket thuc");
        }
    }
}