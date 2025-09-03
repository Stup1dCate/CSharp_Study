using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bai9_while_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* khai báo và khởi tạo While:
                while (<điều kiện lặp>) {
                    <khối lệnh lặp>
                }
            */
            int x = 10;
            Console.WriteLine("Cac so nguyen duong <= 10 la:");
            while (x > 0)
            {
                Console.WriteLine(x);
                x--;
            }



            /* khai báo và khởi tạo Do-While:
                do {
                    <khối lệnh lặp>
                }
            while(<điều kiện lặp>);
            */
            int a = 1;
            int sum = 0;
            do
            {
                sum += a;
                a++;
            }
            while (a <= 10);
            Console.WriteLine("Tong 10 so nguyen duong dau tien la: " + sum);



            // while(true) {break;} -> break; là dòng lệnh dừng chương trình
            int b = 1;
            Console.WriteLine("Cac so nguyen duong <= 5 la: ");
            while (true) {
                Console.WriteLine(b);
                b++;
                if (b == 6) {break;}
            }

        }
    }
}
