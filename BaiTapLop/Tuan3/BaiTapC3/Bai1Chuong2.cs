using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapC_
{
    public class NhanVien
    {
        private string maNV;
        private string hoTen;
        private int ngayCong;
        private char xepLoai;
        private double luongNgay = 200000;

        public NhanVien()
        {
        }
        public NhanVien(string maNV, string hoTen) // constructor 2 tham số
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.NgayCong = 0;
            this.XepLoai = 'C';
        }

        public NhanVien(string maNV, string hoTen, int ngayCong, char xepLoai)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
            this.ngayCong = ngayCong;
            this.xepLoai = xepLoai;
        }

        ~NhanVien()
        {
            Console.WriteLine($"Da huy doi tuong nhan vien {maNV}");
        }

        public string MaNV
        {
            get { return maNV; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    maNV = value;
                else
                    throw new ArgumentException("Ma nhan vien khong duoc de trong");
            }
        }

        public string HoTen
        {
            get { return hoTen; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    hoTen = value;
                else
                    throw new ArgumentException("Ho ten khong duoc de trong");
            }
        }

        public int NgayCong
        {
            get { return ngayCong; }
            set
            {
                if (value > 0)
                    ngayCong = value;
                else
                    throw new ArgumentException("So ngay cong phai lon hon 0");
            }
        }

        public char XepLoai
        {
            get { return xepLoai; }
            set
            {
                if (value == 'A' || value == 'B' || value == 'C')
                    xepLoai = value;
                else
                    throw new ArgumentException("Xếp loại chỉ nhận A, B hoặc C!");
            }
        }

        public void NhapThongTinNhanVien()
        {
            Console.Write("Nhap ma nhan vien: ");
            maNV = Console.ReadLine();
            Console.Write("Nhap ten nhan vien: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap so ngay cong: ");
            ngayCong = int.Parse(Console.ReadLine());
            if (ngayCong > 26)
                xepLoai = 'A';
            if (ngayCong >= 22 && ngayCong <= 26)
                xepLoai = 'B';
            if(ngayCong < 22)
                xepLoai = 'C';
        }

        public void XuatTThongTinNhanVien()
        {
            Console.WriteLine();
            Console.WriteLine("======Thong tin nhan vien======"
            Console.WriteLine("Ma nhan vien: " + maNV);
            Console.WriteLine("Ten nhan vien: " + hoTen);
            Console.WriteLine("So ngay cong: " + ngayCong);
            Console.WriteLine("Xep loai: " + xepLoai);
            Console.WriteLine("Luong: " + (TinhLuong() + TinhThuong()));
        }

        public double TinhLuong()
        {
            return ngayCong * luongNgay;
        }

        public double TinhThuong()
        {
            if (XepLoai == 'A')
                return TinhLuong() * 0.05;
            else if (XepLoai == 'B')
                return TinhLuong() * 0.02;
            else
                return 0;
        }
    }

}
