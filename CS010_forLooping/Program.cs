using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai10_forLooping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* CÚ PHÁP VÒNG FOR:
            for([khởi tạo]; [điều kiện]; [bước lặp]){
                <khối lệnh trong for>
            }
            */
            // xuất ra các số từ 1->10:
            Console.WriteLine("Cac so tu 1->10:");
            for(int i = 1; i <= 10; i++){
                Console.WriteLine("i = "+i);
            }
            // kết hợp với phương thức if để in ra các số chẵn/lẻ 1->10:
            Console.WriteLine("Cac so chan tu 1->10:");
            for (int i = 1; i <= 10; i++){
                if(i%2==0) Console.WriteLine("i = " + i);
            }
            // kết hợp với các phép tính cơ bản:
            int sum = 0;
            for (int i = 1; i <= 10; i++){
                sum += i;
            }
            Console.WriteLine("Tong cac so nguyen tu 1->10: "+sum);




            /* CÚ PHÁP VÒNG FOREACH:
            foreach (<kiểu dữ liệu><biến lặp> in <tên mảng hoặc tập hợp>){
                <khối lệnh trong foreach>
            }
            */  

            // duyệt phần tử trong một list
            int[] list = { 1, 2, 3, 4, 5 };
            foreach (int j in list) {
                Console.WriteLine("j = " + j);
            }

            // kết hợp với if-else:
            int months;
            Console.WriteLine("Nhap vao mot thang trong nam");
            months = int.Parse(Console.ReadLine());
            int[] months_list = { 1, 3, 5, 7, 8, 10, 12 };
            foreach (int j in months_list) {
                if (months == j)
                {
                    Console.WriteLine("Thang co 31 ngay");
                    break;
                }
            }

            //kết hợp với string:
            string[] fruits = { "apple", "banana", "mango", "cherry" };
            foreach (string j in fruits)
            {
                Console.WriteLine("j = " + j);
            }

            /* KIỂU DỮ LIỆU CONTINUE - BREAK:
            CONTINUE - bỏ qua một giá trị
            BREAK - kết thúc khi đạt được giá trị 
            */

            // bỏ một số trong dãy số liên tục
            for(int i = 1; i <= 5; i++)
            {
                if (i == 3) continue;
                Console.WriteLine("i=" + i);
            }



            // thoát chương trình khi gặp được key (giá trị dừng)
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3) break;
                Console.WriteLine("i=" + i);
            }

        }
    }
}
