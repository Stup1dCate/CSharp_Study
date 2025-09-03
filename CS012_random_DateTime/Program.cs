using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai12_random_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RANDOM:
            // Khởi tạo đối tượng có thể sinh ra số ngẫu nhiên
            Random random = new Random();

            // tạo một số ngẫu nhiên từ 50 -> 100 
            int randomInterger_1 = random.Next(50, 101); // [50 , 101)
            // Cấu trúc: random.Next(begin, end) -> begin không điền gì thì begin = 0
            Console.WriteLine("So ngau nhien duoc sinh ra trong doan [50, 100] la: "+randomInterger_1);

            // số ngẫu nhiên không chứa begin và end:
            double randomInterger_2 = random.NextDouble(); // [0, 1)
            Console.WriteLine("So thuc ngau nhien duoc sinh ra trong doan [0, 1] la: " + randomInterger_2);

            // số ngẫu nhiên mong muốn 1,n; 2,n; ...
            double randomInterger_3 = randomInterger_1 + randomInterger_2;
            Console.WriteLine("So ngau nhien theo quy tac mong muon la: " + randomInterger_3);
            double randomInterger_4 = randomInterger_2 * 10;
            Console.WriteLine("So ngau nhien theo quy tac mong muon la: " + randomInterger_4);



            // DATETIME:
            // khởi tạo
            DateTime birtday = new DateTime(2005, 03, 11);
            Console.WriteLine("Ngay thang nam sinh cua ban la [dd/MM/yyyy]: " + birtday.ToString("dd/MM/yyyy"));
            Console.WriteLine("Ngay thang nam sinh cua ban la [MM/dd/yyyy]: " + birtday.ToString("MM/dd/yyyy"));
            Console.WriteLine("Ngay thang nam sinh cua ban la [yyyy/MM/dd]: " + birtday.ToString("yyyy/MM/dd"));
            Console.WriteLine("Ngay sinh cua ban: " + birtday.ToString("dd"));
            Console.WriteLine("Thang sinh cua ban: " + birtday.ToString("MM"));
            Console.WriteLine("Nam sinh cua ban: " + birtday.ToString("yyyy"));

            // viết chương trình cho người dùng nhập vào ngày tháng năm sinh
            Console.WriteLine("Nhap vao ngay thang nam sinh cua ban (ngay/thang/nam): ");
            string input_birtday = Console.ReadLine();
            DateTime birtday_1 = DateTime.Parse(input_birtday);
            Console.WriteLine("Ngay sinh cua ban: " + birtday_1.ToString("dd"));
            Console.WriteLine("Thang sinh cua ban: " + birtday_1.ToString("MM"));
            Console.WriteLine("Nam sinh cua ban: " + birtday_1.ToString("yyyy"));
        }
    }
}
