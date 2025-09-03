
/*
B1: tính n! dùng vòng lặp

B2: tính tổng các số chẵn từ 0 -> n (n nguyên nhập vào)

B3: tìm những số chia hết cho 3 trong đoạn [10; 50]

B4: tính tổng biểu thức giai thừa có dạng: 1! + 2! + 3! + ... + n! (n nguyên nhập vào) 

B5: tìm tất cả các số hoàn chỉnh (hoàn hảo/hoàn thành) trong đoạn từ 1-1000 (số hoàn chỉnh là số có tổng các ước của nó bằng chính nó)

B6: viết chương trình kiểm tra một số n nhập vào từ bàn phím là số nguyên tố hay số chính phương hay không. Khi thực hiện xong hỏi 
người dùng có muốn nhập tiếp không?
*/
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BT10_forLooping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //B1:
            int n1;
            Console.Write("Bai1. Nhap vao mot so nguyen de tinh giai thua: ");
            n1 = int.Parse(Console.ReadLine());
            int result_1 = 1;
            for (int i = 1; i <= n1; i++)
            {
                result_1 *= i;
            }
            Console.WriteLine(result_1);



            //B2:
            int n2;
            Console.Write("Bai2. Nhap vao mot so nguyen de tinh tong cac so chan: ");
            n2 = int.Parse(Console.ReadLine());
            int result_2 = 0;
            for (int i = 0; i <= n2; i++)
            {
                if (i % 2 == 0) result_2 += i;
            }
            Console.WriteLine(result_2);



            //B3: 
            Console.Write("Bai3. Tong cac so chia het cho 3 trong khoang [10; 50] la: ");
            int count_3 = 0;
            for(int i = 10; i <= 50; i++)
            {
                if (i % 3 == 0) count_3++;
            }
            Console.WriteLine(count_3);



            //B4:
            int n4;
            Console.Write("Bai4. Nhap vao mot so nguyen de tinh tong bieu thuc giai thua: ");
            n4 = int.Parse(Console.ReadLine());
            int result_4 = 0;
            for (int i = 1; i <= n4; i++)
            {
                int key = 1;
                for(int j = 1; j <= i; j++)
                {
                    key *= j;
                }
                result_4 += key;
            }
            Console.WriteLine(result_4);



            //B5:
            Console.WriteLine("bai6. Tat ca cac so hoan chinh trong khoang tu 1-1000 bao gom: ");
            int count_5 = 0;
            for(int i = 1; i <= 1000; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0) {
                        sum += j;
                    }
                }
                if (sum == i)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();



            //B6: 
            while (true)
            {
                Console.Write("Bai6. Nhap vao mot so de kiem tra xem chinh phuong hay nguyen to: ");
                int n6 = int.Parse(Console.ReadLine());
                bool isPrime = true;
                bool isSquare = false;

                if (n6 < 2) isPrime = false;

                else
                {
                    for (int i = 2; i * i <= n6; i++)
                    {
                        if (n6 % i == 0)
                        {
                            isPrime = false; break;
                        }
                    }
                }

                if (n6 >= 0)
                {
                    for (int i = 1; i * i <= n6; i++)
                    {
                        if (i * i == n6)
                        {
                            isSquare = true; break;
                        }
                    }
                }

                if (isPrime && isSquare)
                {
                    Console.WriteLine($"{n6} vua la so nguyen to vua la so chinh phuong.");
                }
                else if (isSquare)
                {
                    Console.WriteLine($"{n6} la so chinh phuong.");
                }
                else if (isPrime)
                {
                    Console.WriteLine($"{n6} la so nguyen to.");
                }
                else
                {
                    Console.WriteLine($"{n6} khong phai so nguyen to hay chinh phuong");
                }

                Console.Write("tiep tuc chuong trinh ? (y/n) ");
                string tiep = Console.ReadLine().ToLower();
                if (tiep != "y")
                {
                    Console.WriteLine("Ket thuc chuong trinh.");
                    break;
                }
            }
        }
    }
}
