using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    // ----- Lớp cha -----
    class CanBo
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }

        public CanBo(string hoTen, int namSinh, string gioiTinh, string diaChi)
        {
            if (DateTime.Now.Year - namSinh < 18)
                throw new Exception("Tuoi phai >= 18");

            HoTen = hoTen;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Ho ten: {HoTen}, Nam sinh: {NamSinh}, Gioi tinh: {GioiTinh}, Dia chi: {DiaChi}");
        }

        public virtual double TinhLuong()
        {
            return 0;
        }
    }

    // ----- Lớp Công nhân -----
    class CongNhan : CanBo
    {
        public string Bac { get; set; }

        public CongNhan(string hoTen, int namSinh, string gioiTinh, string diaChi, string bac)
            : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            Bac = bac;
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Bac: {Bac}");
        }

        public override double TinhLuong()
        {
            return 3000000;
        }
    }

    // ----- Lớp Kỹ sư -----
    class KySu : CanBo
    {
        public string NganhDaoTao { get; set; }

        public KySu(string hoTen, int namSinh, string gioiTinh, string diaChi, string nganh)
            : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            NganhDaoTao = nganh;
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Nganh dao tao: {NganhDaoTao}");
        }

        public override double TinhLuong()
        {
            return 8000000 + 1000000;
        }
    }

    // ----- Lớp Nhân viên -----
    class NhanVien : CanBo
    {
        public string CongViec { get; set; }

        public NhanVien(string hoTen, int namSinh, string gioiTinh, string diaChi, string congViec)
            : base(hoTen, namSinh, gioiTinh, diaChi)
        {
            CongViec = congViec;
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Cong viec: {CongViec}");
        }

        public override double TinhLuong()
        {
            return 4000000 + 500000;
        }
    }

    // ----- Chương trình chính -----
    class Program
    {
        static void Main(string[] args)
        {
            CongNhan cn = new CongNhan("Nguyen Van A", 1990, "Nam", "Ha Noi", "Bac 3/7");
            KySu ks = new KySu("Tran Thi B", 1988, "Nu", "Hai Phong", "Co khi");
            NhanVien nv = new NhanVien("Le Van C", 1995, "Nam", "Da Nang", "Ke toan");

            Console.WriteLine("---- Cong nhan ----");
            cn.HienThi();
            Console.WriteLine($"Luong: {cn.TinhLuong()} VND\n");

            Console.WriteLine("---- Ky su ----");
            ks.HienThi();
            Console.WriteLine($"Luong: {ks.TinhLuong()} VND\n");

            Console.WriteLine("---- Nhan vien ----");
            nv.HienThi();
            Console.WriteLine($"Luong: {nv.TinhLuong()} VND\n");
        }
    }
}

