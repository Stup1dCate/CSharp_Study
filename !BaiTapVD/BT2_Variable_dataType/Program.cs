using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2_Variable_dataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name;
            float diemToan;
            float diemVan;

            Console.WriteLine("Moi nhap vao ho ten: ");
            Name = Console.ReadLine();

            Console.WriteLine("Moi nhap vao diem Toan: ");
            diemToan = float.Parse(Console.ReadLine());

            Console.WriteLine("Moi nhap vao diem Van: ");
            diemVan = float.Parse(Console.ReadLine());

            // Xuất ra học sinh có tên và có điểm toán, văn
            Console.WriteLine("Hoc sinh: {0} \nDiem toan: {1} \nDiem van: {2}", Name, diemToan, diemVan);

        }
    }
}
