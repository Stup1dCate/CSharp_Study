using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Số PI
            Console.WriteLine("so PI la: " + Math.PI);
            Console.WriteLine("kieu du lieu cua so PI la: " + Math.PI.GetType().ToString()); // phải có thêm đuôi .ToString() để in ra kiểu chữ cho người dùng đọc
            // nếu ép kiểu sang float (giá trị float < double) thì các số sau dấu chấm sẽ rút ngắn đi
            float num_PI = (float)Math.PI;
            Console.WriteLine("So PI sau khi chuyen sang kieu du lieu float la: "+num_PI);


            // Căn bậc 2
            int a = 16;
            Console.WriteLine("Can bac 2 cua so {0} la: {1}", 16, Math.Sqrt(a));
            Console.WriteLine("Kieu du lieu cua can bac 2 la: " + Math.Sqrt(a).GetType().ToString());


            // Luỹ thừa
            Console.WriteLine("Luy thua 2 cua 3 la: " + Math.Pow(3, 2));
            Console.WriteLine("Kieu du lieu cua can bac 2 la: " + Math.Pow(3, 2).GetType().ToString());


            // max-min trong một khoảng
            Console.WriteLine("Gia tri lon nhat va nho nhat trong doan [1, 10] lan luot la: {0} va {1}", Math.Max(1, 10), Math.Min(1, 10));
            // kiểu dữ liệu của max-min sẽ phụ thuộc vào phần tử nằm trong nó. Nếu có một phần tử thuộc loại lớn hơn (float > int) thì cả khoảng sẽ được quy về loại đó
            Console.WriteLine("Kieu gia tri cua max - min [1, 10] la: " + Math.Min(1, 10).GetType().ToString());
            Console.WriteLine("Kieu gia tri cua max - min [1, 10.5] la: " + Math.Max(1, 10.5).GetType().ToString());


            // Làm tròn số
            float c = 1.235876f;
            // Round(x, n) => x là số (khác số nguyên) cần làm tròn - n là số chữ số đằng sau dấu ',' cần làm tròn 
            Console.WriteLine("Chu so {0} sau khi lam tron la: {1}", c, Math.Round(c, 2)); // tuỳ thuộc vào chữ số cần lấy để làm tròn lên/xuống


            // Lượng giác:
            // 1 độ = (pi/180) radiant
            // Suy ra muốn tìm góc lượng giác ta lấy độ nhân với pi/180
            Console.WriteLine("sin(180) = " + Math.Sin(Math.PI));
            Console.WriteLine("sin(30) = " + Math.Sin(30*Math.PI/180));


        }
    }
}
