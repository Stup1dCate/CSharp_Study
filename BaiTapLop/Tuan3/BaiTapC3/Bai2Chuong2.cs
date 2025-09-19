using System;

namespace BaiTapC_
{
    public class TinhTienDien
    {
        private static int DinhMuc;       
        private static double DonGia;     

        private string hoTen;
        private string maSoCongTo;
        private int chiSoCu;
        private int chiSoMoi;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public string MaSoCongTo
        {
            get { return maSoCongTo; }
            set { maSoCongTo = value; }
        }

        public int ChiSoCu
        {
            get { return chiSoCu; }
            set
            {
                if (value >= 0)
                    chiSoCu = value;
                else
                    throw new ArgumentException("Chỉ số cũ phải >= 0");
            }
        }

        public int ChiSoMoi
        {
            get { return chiSoMoi; }
            set
            {
                if (value >= chiSoCu)
                    chiSoMoi = value;
                else
                    throw new ArgumentException("Chỉ số mới phải >= chỉ số cũ");
            }
        }
        public TinhTienDien() { }

        public TinhTienDien(string hoTen, string maSo, int cu, int moi)
        {
            this.HoTen = hoTen;
            this.MaSoCongTo = maSo;
            this.ChiSoCu = cu;
            this.ChiSoMoi = moi;
        }

        public static void ThietLapDinhMucVaDonGia(int dinhMuc, double donGia)
        {
            DinhMuc = dinhMuc;
            DonGia = donGia;
        }

        public int SoDienSuDung()
        {
            return ChiSoMoi - ChiSoCu;
        }

        public double TinhTienDienPhaiTra()
        {
            int sd = SoDienSuDung();
            if (sd <= DinhMuc)
                return sd * DonGia;
            else
            {
                int vuot = sd - DinhMuc;
                return DinhMuc * DonGia + vuot * DonGia * 1.5;
            }
        }

        public void NhapThongTin()
        {
            Console.Write("Nhập họ tên chủ hộ: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập mã số công tơ: ");
            MaSoCongTo = Console.ReadLine();

            Console.Write("Nhập chỉ số cũ: ");
            ChiSoCu = int.Parse(Console.ReadLine());

            Console.Write("Nhập chỉ số mới: ");
            ChiSoMoi = int.Parse(Console.ReadLine());
        }

        public void XuatThongTin()
        {
            Console.WriteLine("===== Hóa đơn tiền điện =====");
            Console.WriteLine($"Chủ hộ: {HoTen}");
            Console.WriteLine($"Mã công tơ: {MaSoCongTo}");
            Console.WriteLine($"Chỉ số cũ: {ChiSoCu}");
            Console.WriteLine($"Chỉ số mới: {ChiSoMoi}");
            Console.WriteLine($"Số điện sử dụng: {SoDienSuDung()} kWh");
            Console.WriteLine($"Tiền điện phải trả: {TinhTienDienPhaiTra()} VND");
        }
    }
}
