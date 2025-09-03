using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7_ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        // là điều kiện nếu đúng thì thực hiện bước hai, sai thì thực hiện bước ba
            int n;
            Console.WriteLine("Nhap vao mot so nguyen: ");
            n = int.Parse(Console.ReadLine());
            string result = (n % 2 == 0) ? "la so chan" : "la so le";
            Console.WriteLine(result);
        // bài tập tính điểm trung bình và xếp loại
            float diemTB;
            Console.WriteLine("Nhap vao diem trung binh de xep loai: ");
            diemTB = float.Parse(Console.ReadLine());
            string kqdiemTB =
            (diemTB >= 8.0) ? "Dat hang gioi" :
            (diemTB >= 7.0) ? "Dat loai kha" :
            (diemTB >= 5.0) ? "Dat loai trung binh" :
            "Dat loai yeu";

            Console.WriteLine(kqdiemTB);
        }
    }
}
