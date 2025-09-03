using System;
using System.Linq;
namespace CS033_Lambda
{
    /* Lambda - Anonymous function (biểu thức vô danh)
    - Cách khai báo:

    (1):
        (tham_so, tham_so, ...) => bieu_thuc;

    (2):
        (tham_so, tham_so, ...) => {
            bieu_thuc;
            bieu_thuc;
            ...
            return bieu_thuc_tra_ve;
        };
    - Cách sử dụng: một biểu thức lambde có thể gán cho một biến kiểu delegate 
                    (phải phù hợp với khai báo tham số và kiểu trả về)

    */

    

    class Program
    {
        static void Main(string[] args)
        {
            Action<string> thongbao;
            // cach 1
            thongbao = (string s) => Console.WriteLine(s); // phải gán cho delegate dạng: delegate void TYPE(string s) = Action<string>
            // // cach 2
            // (int a, int b) =>
            // {
            //     int result = a + b;
            //     return result;
            // }

            thongbao?.Invoke("Xin chao"); // in ra bao nhiêu lần cũng được
            for (int i = 0; i < 10; i++)
            {
                thongbao?.Invoke("Xin chao");
            }

            // BIỂU THỨC LAMBDA CÓ THỂ GÁN CHO CÁC BIẾN KIỂU DELEGATE
            // một biểu thức lambda có thể không có tham số đầu vào
            Action thongbao1;
            thongbao1 = () => Console.WriteLine("Xin chao 1");
            thongbao1?.Invoke();


            // viết ngắn gọn khai báo tham số:
            Action<string> welcome;
            welcome = s => Console.WriteLine(s);
            // welcome = (string s) ~ welcome = (s) chương trình sẽ tự biết s là kiểu string => đã xác định được kiểu từ trên khai báo
            //                      ~ welcome = s // có thể bỏ luôn ngoặc
            welcome?.Invoke("Xin chao 2");


            // khai báo đa tham số
            Action<string, string> welcome1;
            welcome1 = (mgs, name) => Console.WriteLine(mgs + " " + name);
            // trường hợp 2 (nhiều) tham số thì không thể bỏ ngoặc chỉ có thể bỏ kiểu dữ liệu ở đầu (nếu đã xác định được lúc khai báo)
            welcome1?.Invoke("Xin chao", "Vietnam");
            welcome1?.Invoke("Hello", "World");


            // khai báo đa biểu thức
            Action<string, string> welcome2;
            welcome2 = (mgs, name) =>
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(mgs + " " + name);
                Console.ResetColor();
                // nếu có return ở đây 
            };
            welcome2?.Invoke("Xin chao", "Vietnam");


            // NẾU BIỂU THỨC - PHƯƠNG THỨC LAMBDA CÓ KIỂU TRẢ VỀ THÌ TA SỬ DỤNG DELEGATE DẠNG FUNC:
            Func<int, int, int> tinhtoan; // int thứ 3 là kiểu của giá trị trả về
            tinhtoan = (a, b) =>
            {
                int result = a + b;
                return result;
            };
            Console.WriteLine($"Tong 2 so la: {tinhtoan.Invoke(5, 6)}");



            // sử dụng lambda trong một số thư viện của .NET khác:
            int[] arr = { 2, 4, 6, 8, 10 };

            // cach 1
            var result = arr.Select((int x) =>
            {
                return Math.Sqrt(x);
            });
            foreach (var rs in result)
            {
                Console.WriteLine(rs);
            }
            int[] arr1 = { 2, 4, 6, 8, 10, 11, 13, 15 };

            // cach 2: chuyển về list
            arr1.ToList().ForEach(
                (x) => // đầy đủ (int x) nhưng đã xác định được kiểu dữ liệu của x ở trên rồi
                {
                    if (x % 2 != 0) Console.WriteLine(x);
                }
            );

            // cach 3: phương thức Where
            var result1 = arr1.Where(
                (x) =>
                {
                    return x % 4 == 0;
                    // return x < 10 && x >= 4;
                }
            );
            // có thể viết ngắn gọn biểu thức như sau:
            result1 = arr1.Where(x => x % 4 == 0); // nếu chỉ có một biểu thức thì cũng có thể bỏ "return" và ngoặc của x

            foreach (var n in result1)
            {
                Console.WriteLine(n);
            }

        }   
    }
}