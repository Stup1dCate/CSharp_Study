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