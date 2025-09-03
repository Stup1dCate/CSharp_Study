using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8_switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sử dụng switch-case để đến một số nhập vào có bao nhiêu chữ số:
            int number;
            Console.ForegroundColor = ConsoleColor.Red; // chuyển màu kí tự 
            Console.WriteLine("Nhap vao mot thang trong nam: ");
            number = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow; // chuyển tiếp màu khác cho các output phía dưới (bắt đầu từ dòng này)

            switch (number)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang vua nhap co 31 ngay");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang vua nhap co 30 ngay");
                    break;
                case 2:
                    Console.WriteLine("Thang vua nhap co 28/29 ngay");
                    break;
                default: //mặc định: trường hợp khi không xảy ra giống với bất kì case nào phía trên
                    Console.WriteLine("Thang vua nhap vao khong hop le");
                    break;
            }

            // Cú pháp "nhãn":
            Console.WriteLine("Nhap vao cau lenh can thuc hien: ");
            Console.WriteLine("1. Tinh tong 2 so");
            Console.WriteLine("2. Tinh hieu 2 so");
            Console.WriteLine("3. Tinh tich 2 so");
            Console.WriteLine("4. Tinh thuong 2 so");
            int a = 4, b = 2;
            char c;
            L1:
            c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (c)
            {
                case '1':
                    Console.WriteLine($"Tong la: {a + b}");
                    break;
                case '2':
                    Console.WriteLine($"Hieu la: {a - b}");
                    break;
                case '3':
                    Console.WriteLine($"Tich la: {a * b}");
                    break;
                case '4':
                    Console.WriteLine($"Thuong la: {a / b}");
                    break;
                default:
                    Console.WriteLine("Hay chon lenh khac");
                    goto L1;
                break;                    
            }


        }
    }
}
