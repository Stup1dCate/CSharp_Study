using System;

public class Bai2
{
    public static void Run()
    {
        VanDongVien vdv1 = new VanDongVien();
        Console.WriteLine("Nhap thong tin van dong vien:");
        vdv1.Nhap();

        Console.WriteLine("\n--- Thong tin van dong vien ---");
        vdv1.Xuat();
    }
}

public class Gio
{
    public int GioPhut { get; set; }
    public int Phut { get; set; }
    public int Giay { get; set; }

    public Gio()
    {
        GioPhut = 0;
        Phut = 0;
        Giay = 0;
    }

    public Gio(int gio, int phut, int giay)
    {
        GioPhut = gio;
        Phut = phut;
        Giay = giay;
    }

    public bool HopLe()
    {
        if (GioPhut < 0 || GioPhut > 23) return false;
        if (Phut < 0 || Phut > 59) return false;
        if (Giay < 0 || Giay > 59) return false;
        return true;
    }

    public int ToSeconds()
    {
        return GioPhut * 3600 + Phut * 60 + Giay;
    }

    public override string ToString()
    {
        return $"{GioPhut:D2}:{Phut:D2}:{Giay:D2}";
    }
}

public class VanDongVien
{
    public string MaSo { get; set; }
    public string HoTen { get; set; }
    public int SoAo { get; set; }
    public Gio ThoiGianBatDau { get; set; }
    public Gio ThoiGianKetThuc { get; set; }

    public static int ThanhTichChuan = 1 * 3600 + 30 * 60;

    public VanDongVien()
    {
        MaSo = "";
        HoTen = "";
        SoAo = 0;
        ThoiGianBatDau = new Gio();
        ThoiGianKetThuc = new Gio();
    }

    public VanDongVien(string maSo, string hoTen, int soAo)
    {
        MaSo = maSo;
        HoTen = hoTen;
        SoAo = soAo;
        ThoiGianBatDau = new Gio();
        ThoiGianKetThuc = new Gio();
    }

    public VanDongVien(string maSo, string hoTen, int soAo, Gio bd, Gio kt)
    {
        MaSo = maSo;
        HoTen = hoTen;
        SoAo = soAo;
        ThoiGianBatDau = bd;
        ThoiGianKetThuc = kt;
    }

    public void Nhap()
    {
        Console.Write("Nhap ma so: ");
        MaSo = Console.ReadLine();

        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine();

        Console.Write("Nhap so ao: ");
        SoAo = int.Parse(Console.ReadLine());

        int g, p, s;

        do
        {
            Console.Write("Nhap thoi gian bat dau (gio phut giay): ");
            g = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());
            ThoiGianBatDau = new Gio(g, p, s);
        } while (!ThoiGianBatDau.HopLe());

        do
        {
            Console.Write("Nhap thoi gian ket thuc (gio phut giay): ");
            g = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());
            ThoiGianKetThuc = new Gio(g, p, s);
        } while (!ThoiGianKetThuc.HopLe());
    }

    public Gio TinhThanhTich()
    {
        int tg = ThoiGianKetThuc.ToSeconds() - ThoiGianBatDau.ToSeconds();
        if (tg < 0) tg += 24 * 3600;

        int gio = tg / 3600;
        int phut = (tg % 3600) / 60;
        int giay = tg % 60;
        return new Gio(gio, phut, giay);
    }

    public bool DatChuan()
    {
        int tg = ThoiGianKetThuc.ToSeconds() - ThoiGianBatDau.ToSeconds();
        if (tg < 0) tg += 24 * 3600;
        return tg <= ThanhTichChuan;
    }

    public void Xuat()
    {
        Console.WriteLine($"Ma so: {MaSo}");
        Console.WriteLine($"Ho ten: {HoTen}");
        Console.WriteLine($"So ao: {SoAo}");
        Console.WriteLine($"Thoi gian bat dau: {ThoiGianBatDau}");
        Console.WriteLine($"Thoi gian ket thuc: {ThoiGianKetThuc}");
        Console.WriteLine($"Thanh tich: {TinhThanhTich()}");
        Console.WriteLine($"Dat chuan: {(DatChuan() ? "Co" : "Khong")}");
    }
}
