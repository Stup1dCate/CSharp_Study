// KIỂU DỮ LIỆU VÔ DANH - Anonymous
/*
+ Object - Thuộc tính - Chỉ đọc
+ khai báo: new {thuoctinh = giatri, thuoctinh2 = giatri2, ...}
*/
using System;
using System.Collections.Generic;
using System.Linq; // khai báo using để sử dụng được Linq

namespace CS026_AnonymousType
{
    // Áp dụng với Linq:
    class Sinhvien
    {
        public string HoTen { set; get; }
        public int NamSinh { set; get; }
        public string NoiSinh { set; get; }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // // Khai báo một đối tượng vô danh:
            // var sanpham = new
            // {
            //     Ten = "Lenovo",
            //     Gia = 1000,
            //     NamSX = 2024
            // };
            // // sanpham.Ten = "Legion"; -> dòng này báo lỗi vì kiểu dữ liệu này chỉ đọc không ghi đè được 

            // Console.WriteLine(sanpham.Ten);
            // Console.WriteLine(sanpham.Gia);


            List<Sinhvien> cacSinhVien = new List<Sinhvien>()
            {
                new Sinhvien() {HoTen = "Nam", NamSinh = 2003, NoiSinh = "ThanhHoa"},
                new Sinhvien() {HoTen = "Tung", NamSinh = 2005, NoiSinh = "ThanhHoa"},
                new Sinhvien() {HoTen = "Vu", NamSinh = 2005, NoiSinh = "Hue"}
            };

            var ketqua = from sv in cacSinhVien
                         where sv.NamSinh > 2003 // in ra các sinh viên sinh năm bé hơn 2003
                                                 //   where sv.NoiSinh == "ThanhHoa" -> in ra các sinh viên có cùng nơi sinh
                         select new // tạo ra các biến vô danh (Anonymous) để in ra thông tin sinh viên cần lấy
                         {
                             Ten = sv.HoTen,
                             Ns = sv.NoiSinh
                         };
            foreach (var sinhvien in ketqua)
            {
                Console.WriteLine(sinhvien.Ten + " - " + sinhvien.Ns);
            }

            Console.WriteLine("-----------------------");

            var ketqua1 = from sv in cacSinhVien
                         where sv.HoTen.Contains("n") // in ra các sinh viên mà tên sinh viên đó chứa chữ cái "n"
                         select new 
                         {
                             Ten = sv.HoTen,
                             Ns = sv.NoiSinh
                         };
            foreach (var sinhvien in ketqua1)
            {
                Console.WriteLine(sinhvien.Ten + " - " + sinhvien.Ns);
            }


        }
    }
}