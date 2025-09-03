using System;
/* HÀM UỶ QUYỀN - DELEGATE
+ là một kiểu dữ liệu dùng để tham chiếu (trỏ đến) đến các hàm (phương thức)
+ có tham số và kiểu trả về phù hợp với khai báo kiểu. Khi dùng đến delegate ta có thể gán vào nó một hoặc 
nhiều hàm (phương thức) có sự tương thích về tham số, kiểu trả về, sau đó dùng nó để gọi hàm (giống con trỏ trong C++)
+ các event trong C# chính là các hàm được gọi thông qua delegate, 
cũng có thể dùng delegate để xây dựng các hàm callback, đặc biệt là các Event

==> Giống với con trỏ trong C++
*/
namespace CS032_Delegate
{
    public delegate void Showlog(string message);
    // giống với các khai báo phương thức nhưng không có phần thân và có chữ "delegate" trước kiểu trả về


    class Program
    {
        static void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        delegate int Type1();

        static int Sum(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;
        static int Tong(int a, int b, Showlog log) // phương thức để delegate tham số đến
        {
            int result = a + b;
            log?.Invoke($"Tong la: {result}");
            return result;
        }

        static void Main(string[] args)
        {
            // DELEGATE
            Showlog log = null;
            log = Info; // nếu không gán chỗ này thì các câu lệnh WriteLine phía dưới sẽ bị lỗi

            // các cách viết thông báo:
            log("Xin chao1");
            log.Invoke("Xin chao2"); // cách viết tường minh
            // với câu lệnh điều kiện:
            if (log != null) log("Xin chao3");
            log?.Invoke("Xin chao4"); // ưu tiên hơn

            log = Warning;
            log?.Invoke("Canh Bao1");

            // Đa phương thức:
            Showlog log1 = null;
            log1 += Info;
            log1 += Warning;
            log1 += Warning;
            log1 += Info;
            log1 += Warning;
            log1?.Invoke("Hello World");


            // ACTION, FUNC: DELEGATE - GERERIC

            // Các thao tác với Action
            Action action;                  // ~ delegate void FUNCTION(); 
            Action<string, int> action1;    // ~ delegate void FUNCTION(strin s, int i);
            Action<string> action2;         // ~ delegate void FUNCTION(strin s);

            action2 = Warning;
            action2 += Info;
            action2?.Invoke("Thong bao tu Action");
            // các action trên chỉ có action2 là phù hợp để gán với Info và Warning

            // Các thao tác với Func (Giống với Action nhưng Func phải có kiểu trả về)
            Func<int> f1;                       // ~ delegate int Type1();
            Func<string, double, string> f2;    // ~ delegate int Type1(string s, double d)
            // kiểu trả về nằm ở cuối và kiểu của các tham số là các kiểu còn lại
            // (f2 có string là kiểu trả về, 2 kiểu phía trước là kiểu của tham số) <TS-type, TS-type, TV-type>
            Func<int, int, int> f3;             // ~ delegate int Sum(int, int) / delegate int Subtract(int, int)
            int a = 5, b = 7;

            f3 = Sum;
            Console.WriteLine($"Tong 2 so a va b la: {f3(a, b)}");
            f3 = Subtract;
            Console.WriteLine($"Hieu 2 so a va b la: {f3(a, b)}");

            /* Gán như này sẽ bị lỗi: kết quả chỉ in ra 2 lần hàm Subtract
            f3 = Sum;
            f3 = Subtract;
            Console.WriteLine($"Tong 2 so a va b la: {f3(a,b)}");
            Console.WriteLine($"Hieu 2 so a va b la: {f3(a,b)}");
            */


            // Sử dụng delegate cho tham số phương thức
            Tong(2, 3, Info); // in ra chữ màu xanh tổng của 2 và 3

        }
    }
}