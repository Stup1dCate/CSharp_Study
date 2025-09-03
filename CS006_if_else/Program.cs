using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float diemTN;
            Console.WriteLine("Nhap vao diem tot nghiep: ");
            diemTN = float.Parse(Console.ReadLine());

            if (diemTN > 5.0)
            {
                Console.WriteLine("Diem cua ban la: {0}. Ban da do", diemTN);
            }
            else
            {
                Console.WriteLine("Diem cua ban la: {0}. Ban da rot", diemTN);
            }
            float diemTB;
            Console.WriteLine("Nhap vao diem trung binh: ");
            diemTB = float.Parse(Console.ReadLine());

            if (diemTB >= 8.0)
            {
                Console.WriteLine("Dat loai gioi");
            }
            else if (diemTB < 8.0 && diemTB >= 7.0)
            {
                Console.WriteLine("Dat loai kha");
            }
            else if (diemTB >= 5.0 && diemTB < 7.0)
            {
                Console.WriteLine("Dat loai trung binh");
            }
            else
            {
                Console.WriteLine("Dat loai yeu");
            }
        }
    }
}
