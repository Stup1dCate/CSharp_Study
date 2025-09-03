using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // tìm 2 số khi biết tổng hiệu của chúng
            float tong, hieu, x, y;
            Console.WriteLine("Nhap vao tong hai so: ");
            tong = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao hieu hai so: ");
            hieu = float.Parse(Console.ReadLine());

            // x + y = tong; x - y = hieu; => 2y = tong - hieu
            y = (tong - hieu) / 2;
            x = tong - y;
            Console.WriteLine("Gia tri cua 2 so lan luot la: {0} va {1}", x, y);
        // viet chuong trinh tinh BMI cua nguoi, nhap vao chieu cao va can nang. BMI = canNang/(chieuCao^2)
            float chieuCao, canNang; // chieuCao (m), canNang(kg)
            Console.WriteLine("Nhap vao chieu cao(m): ");
            chieuCao = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao can nang(kg): ");
            canNang = float.Parse(Console.ReadLine());

            float BMI = canNang / (chieuCao * chieuCao);
            if (BMI >= 35.0) { Console.WriteLine("Than hinh qua beo"); }
            else if (BMI >= 30.0 && BMI < 35.0) { Console.WriteLine("Than hinh beo"); }
            else if (BMI >= 25.0 && BMI < 30.0) { Console.WriteLine("Than hinh hoi beo"); }
            else if (BMI >= 18.5 && BMI < 25.0) { Console.WriteLine("Than hinh binh thuong"); }
            else if (BMI >= 16.0 && BMI < 18.5) { Console.WriteLine("Than hinh hoi gay"); }
            else if (BMI >= 15.0 && BMI < 16.0) { Console.WriteLine("Than hinh gay"); }
            else
            {
                Console.WriteLine("Than hinh qua gay");
            }
        // kiểm tra năm nhuận/không nhuận:
            int year, months;
            Console.WriteLine("Nhap vao nam can kiem tra: ");
            year = int.Parse(Console.ReadLine());
            bool namNhuan;

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("Nam {0} la nam nhuan", year);
                namNhuan = true;
            }
            else { 
                Console.WriteLine("Nam {0} khong phai la nam nhuan", year);
                namNhuan = false;
            }

            Console.WriteLine("Nhap vao thang can kiem tra cua nam {0}:", year);
            months = int.Parse(Console.ReadLine());
            if (months == 1 || months == 3 || months == 5 || months == 7 || months == 8 || months == 10 || months == 12)
            {
                Console.WriteLine("Thang co 31 ngay");
            }
            else if (months == 4 || months == 6 || months == 9 || months == 11) {
                Console.WriteLine("Thang co 30 ngay");
            }
            else if (months == 2)
            {
                if (namNhuan)
                {
                    Console.WriteLine("Thang co 29 ngay");
                }
                else
                {
                    Console.WriteLine("Thang co 28 ngay");
                }
            }
            else
            {
                Console.WriteLine("Thang nhap vao khong hop le !");
            }
        }
    }
}
