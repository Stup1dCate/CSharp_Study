/*
    - Phương thức với kiểu Generic
+ Generic là kiểu đại diện, nó cho phép tạo mã nguồn code không phụ thuộc vào kiểu dữ liệu cụ thể, 
chỉ khi code thực thi thì kiểu cụ thể mới xác định. 
+ Trước đây bạn đã quen với việc viết code trên những kiểu dữ liệu cụ thể như int, float, double ... 
hay các class do bạn định nghĩa, tuy nhiên có những giải thuật giống nhau trên những kiểu dữ liệu khác nhau, 
để tránh việc viết nhiều lần code lặp lại thì lúc này áp dụng Generic - kiểu đại diện để xây dựng phương thức hoặc lớp.
    - VD nổi bật nhất là hàm hoán vị:
    public static void Swap(ref int a, ref int b) {
        int c = a;
        a = b;
        b = c;
    }
    public static void Swap(ref string a, ref string b) {
        string c = a;
        a = b;
        b = c;
    }
*/

using System;

namespace CS024_Generic
{
    class Program
    {
        /*
        // hàm hoán vị:
        static void swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
        // quá tải phương thức để thực hiện swap với nhiều kiểu dữ liệu khác (string, double, ...)
        static void swap(ref float x, ref float y)
        {
            float tmp = x;
            x = y;
            y = tmp;
        }
        */
        // ÁP DỤNG VỚI KIỂU DỮ LIỆU GENERIC: "T" ở đây là đối tượng Generic 
        static void swap<T>(ref T x, ref T y)
        {
            T tmp = x;
            x = y;
            y = tmp;
        }

        public static void Main(string[] args)
        {
            double a = 15, b = 24; // dựa vào kiểu dữ liệu của a và b mà chương trình sẽ lựa chọn phương thức với kiểu tương ứng
            Console.WriteLine($"a = {a} va b = {b}");
            swap(ref a, ref b); // khi khai báo a và b là kiểu int thì hàm swap sẽ tự động biết kiểu của a và b
                // swap<int>(ref a, ref b); ta có thể chỉ rõ kiểu dữ liệu cho hàm generic trước khi thực hiện bằng cách ghi <kiểu dữ liệu> ở đầu hàm gọi
                // khi chỉ rõ phải ghi đúng kiểu dữ liệu khởi tạo ban đầu
            Console.WriteLine($"Sau khi hoan vi: \na = {a} va b = {b}");

        }
    }
}







