/*
- Định nghĩa: Hằng số (constants) là giá trị không đổi trong suốt chương trình 
vd: pi (math) = 3.1415... == const
    => đã là hằng số thì phải có giá trị (không thể khai báo: "const int giaTri;")
- Khai báo: <const> <type> <tên hằng số> = <giá trị hằng số>;
    => sau dòng khai báo trên thì mọi thao tác thay đổi giá trị của <giá trị hằng số> đều bị coi là lỗi
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3_constants_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1415;
            Console.WriteLine("Gia tri so pi la: " + pi);

            /* Các phép toán cơ bản
            - công\\
            */
            float x, y;
            Console.WriteLine("Nhap vao lan luot gia tri x va y: ");
            Console.WriteLine("Nhap vao gia tri x: ");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao gia tri y: ");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("Tong hai so x+y = {0}", (x+y));
            Console.WriteLine("Hieu hai so x-y = {0}", (x-y));
            Console.WriteLine("Tich hai so x*y = {0}", (x*y));
            Console.WriteLine("Thuong hai so x/y = {0}", (x/y));
            Console.WriteLine("Phan du cua hai so x%y = {0}", (x%y));
        }
    }
}
