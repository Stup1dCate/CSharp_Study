using System;

public class Bai1
{
    public static void Run()
    {
        // Test bang nhap san
        NuocGiaiKhat nuoc1 = new NuocGiaiKhat("Coca Cola", "chai", 10, 200000);
        nuoc1.Xuat();

        Console.WriteLine("\n--- Nhap mat hang moi ---");
        NuocGiaiKhat nuoc2 = new NuocGiaiKhat("", "", 1, 1);
        nuoc2.Nhap();
        Console.WriteLine("\n--- Thong tin mat hang vua nhap ---");
        nuoc2.Xuat();
    }
}

public class NuocGiaiKhat
{
    public string TenHang { get; set; }

    private string donViTinh;
    public string DonViTinh
    {
        get { return donViTinh; }
        set
        {
            if (value == "ket" || value == "thung" || value == "chai" || value == "lon")
                donViTinh = value;
            else
                donViTinh = "ket";
        }
    }

    private int soLuong;
    public int SoLuong
    {
        get { return soLuong; }
        set { soLuong = (value > 0) ? value : 1; }
    }

    private float donGia;
    public float DonGia
    {
        get { return donGia; }
        set { donGia = (value > 0) ? value : 1; }
    }

    public static float VAT { get; set; } = 0.1f;

    public NuocGiaiKhat(string tenHang, string donViTinh, int soLuong, float donGia)
    {
        TenHang = tenHang;
        DonViTinh = donViTinh;
        SoLuong = soLuong;
        DonGia = donGia;
    }

    public float ThanhTien()
    {
        float giaCoBan = 0;
        if (DonViTinh == "ket" || DonViTinh == "thung")
            giaCoBan = SoLuong * DonGia;
        else if (DonViTinh == "chai")
            giaCoBan = SoLuong * (DonGia / 20);
        else if (DonViTinh == "lon")
            giaCoBan = SoLuong * (DonGia / 24);

        return giaCoBan + giaCoBan * VAT;
    }

    public void Nhap()
    {
        Console.Write("Nhap ten hang: ");
        TenHang = Console.ReadLine();

        Console.Write("Nhap don vi tinh (ket/thung/chai/lon): ");
        DonViTinh = Console.ReadLine();

        Console.Write("Nhap so luong (>0): ");
        SoLuong = int.Parse(Console.ReadLine());

        Console.Write("Nhap don gia (>0): ");
        DonGia = float.Parse(Console.ReadLine());
    }

    public void Xuat()
    {
        Console.WriteLine($"Ten hang: {TenHang}");
        Console.WriteLine($"Don vi tinh: {DonViTinh}");
        Console.WriteLine($"So luong: {SoLuong}");
        Console.WriteLine($"Don gia: {DonGia}");
        Console.WriteLine($"Thue VAT: {VAT * 100}%");
        Console.WriteLine($"Thanh tien: {ThanhTien()}");
    }
}
