using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_logic_prefix_postfix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // nhập vào 2 cạnh hcn và tính diện tích + chu vi:
            int a, b;
            Console.WriteLine("Nhap vao lan luot 2 canh cua hinh chu nhat: ");
            Console.WriteLine("Nhap vao canh thu nhat: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao canh thu hai: ");
            b = int.Parse(Console.ReadLine());
            int S = a * b;
            int C = (a + b) * 2;
            Console.WriteLine("Dien tich cua hcn la: {0}; Chu vi hcn la: {1}", S, C);
        }
    }
}
