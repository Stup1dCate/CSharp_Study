using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Toán tử gán:
            x += y <=> x = x + y
            x -= y <=> x = x - y
            x *= y <=> x = x * y
            x /= y <=> x = x / y
            x %= y <=> x = x % y
            */
            float x = 5, y = 4;
            x += y;
            Console.WriteLine(x); // giá trị của x sau khi gán
            /* Phép so sánh: boolean
            ==  |   bằng nhau           1 == 1
            !=  |   khác nhau           2 != 1
            >   |   lớn hơn             2 > 1
            <   |   bé hơn              1 < 3
            >=  |   lớn hơn hoặc bằng   2 >= 1
            <=  |   bé hơn hoặc bằng    2 <= 2
            */
            // Vận dụng kiểm tra số chẵn/lẻ:
            int n;
            Console.WriteLine("Nhap vao gia tri so nguyen bat ki: ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " la so chan");
            }
            else { Console.WriteLine(n + " la so le"); }

            // Vận dụng tính chu vi + diện tích hình tròn: pi = 3.1415
            const double pi = 3.1415; // có thể khai báo là float với hậu tố "f"
            float r;
            Console.WriteLine("Nhap vao gia tri ban kinh cua hinh tron can tinh: ");
            r = float.Parse(Console.ReadLine());

            // phải khai báo C và S ở kiểu double vì có pi ở kiểu double mặc dù r là kiểu float (khai báo r là float chỉ để tích kiệm bộ nhớ)
            // toán tử giữa float và double sẽ tự động nâng cấp (promotion) kết quả thành double, vì double có độ chính xác cao hơn float.
            double C = 2*r*pi;
            Console.WriteLine("Chu vi hinh tron voi ban kinh " + r + " la: " + C);
            double S = r*r*pi;
            Console.WriteLine("Dien tich hinh tron voi ban kinh " + r + " la: " + S);
        }
    }
}
