using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

// Lớp KhoaHoc
public class KhoaHoc
{
    private string maKhoaHoc;
    private string tenKhoaHoc;
    private int soTiet;
    private string gioHoc;
    private int soHocVien;
    private string giaoVien;
    private static double hocPhi1Tiet = 20; // Học phí 1 tiết hiện tại
    private static double thuLao1Tiet = 100; // Thù lao giáo viên 1 tiết
    private static int soLuongToiThieu = 10; // Số lượng học viên tối thiểu
    private static double thuLaoThem = 2; // Thù lao thêm cho mỗi học viên vượt quá
    

    // Constructor mặc định
    public KhoaHoc()
    {
        this.maKhoaHoc = "TH023";
        this.tenKhoaHoc = "Android Programming";
        this.soTiet = 48;
        this.gioHoc = "2,4,6";
        this.soHocVien = 13;
        this.giaoVien = "Nguyen Van A"; // Thay bằng tên của bạn
    }

    // Constructor với tham số đầy đủ
    public KhoaHoc(string maKhoaHoc, string tenKhoaHoc, int soTiet, string gioHoc, int soHocVien, string giaoVien)
    {
        this.maKhoaHoc = maKhoaHoc;
        this.tenKhoaHoc = tenKhoaHoc;
        this.soTiet = soTiet;

        // Kiểm tra giờ học hợp lệ
        if (gioHoc == "3,5,7" || gioHoc == "2,4,6" || gioHoc == "7,CN")
            this.gioHoc = gioHoc;
        else
            this.gioHoc = "3,5,7"; // Mặc định

        this.soHocVien = soHocVien;
        this.giaoVien = giaoVien;
    }

    // Constructor với một số tham số
    public KhoaHoc(string maKhoaHoc, string tenKhoaHoc, int soTiet)
    {
        this.maKhoaHoc = maKhoaHoc;
        this.tenKhoaHoc = tenKhoaHoc;
        this.soTiet = soTiet;
        this.gioHoc = "3,5,7"; // Mặc định
        this.soHocVien = 10;
        this.giaoVien = "Nguyen Van A";
    }

    // Properties
    public string MaKhoaHoc
    {
        get { return maKhoaHoc; }
        set { maKhoaHoc = value; }
    }

    public string TenKhoaHoc
    {
        get { return tenKhoaHoc; }
        set { tenKhoaHoc = value; }
    }

    public int SoTiet
    {
        get { return soTiet; }
        set { soTiet = value; }
    }

    public string GioHoc
    {
        get { return gioHoc; }
        set
        {
            if (value == "3,5,7" || value == "2,4,6" || value == "7,CN")
                gioHoc = value;
            else
                gioHoc = "3,5,7";
        }
    }

    public int SoHocVien
    {
        get { return soHocVien; }
        set { soHocVien = value; }
    }

    public string GiaoVien
    {
        get { return giaoVien; }
        set { giaoVien = value; }
    }

    // Property tính học phí của khóa học
    public double HocPhi
    {
        get
        {
            double heSoGioHoc = (gioHoc == "7,CN") ? 1.2 : 1.0;
            return soTiet * hocPhi1Tiet * heSoGioHoc;
        }
    }

    // Phương thức tính thù lao của giáo viên
    public double TinhThuLaoGiaoVien()
    {
        double thuLaoCoBan = soTiet * thuLao1Tiet;
        double thuLaoBonus = 0;

        if (soHocVien > soLuongToiThieu)
        {
            int soHocVienVuot = soHocVien - soLuongToiThieu;
            thuLaoBonus = soHocVienVuot * thuLaoThem;
        }

        return thuLaoCoBan + thuLaoBonus;
    }

    // Toán tử + để tạo khóa học mới với số tiết tăng thêm
    public static KhoaHoc operator +(KhoaHoc kh, int n)
    {
        KhoaHoc khoaHocMoi = new KhoaHoc(kh.maKhoaHoc, kh.tenKhoaHoc, kh.soTiet + n, kh.gioHoc, kh.soHocVien, kh.giaoVien);
        return khoaHocMoi;
    }

    // Phương thức xuất thông tin khóa học
    public void XuatKhoaHoc()
    {
        Console.WriteLine($"Mã: {maKhoaHoc}, Tên: {tenKhoaHoc}, Số tiết: {soTiet}, Buổi học: {gioHoc}, Học phí: {HocPhi:N0} VNĐ");
    }

    public override string ToString()
    {
        return $"Mã: {maKhoaHoc}, Tên: {tenKhoaHoc}, Số tiết: {soTiet}, Buổi học: {gioHoc}, Số HV: {soHocVien}, GV: {giaoVien}, Học phí: {HocPhi:N0} VNĐ";
    }
}

// Lớp DSKhoaHoc để quản lý danh sách khóa học
public class DSKhoaHoc
{
    private List<KhoaHoc> dsKhoaHoc;

    public DSKhoaHoc()
    {
        dsKhoaHoc = new List<KhoaHoc>();
    }

    // Đọc danh sách khóa học từ file
    public void DocTuFile(string tenFile)
    {
        try
        {
            if (!File.Exists(tenFile))
            {
                Console.WriteLine($"File {tenFile} không tồn tại!");
                return;
            }

            string[] lines = File.ReadAllLines(tenFile);
            dsKhoaHoc.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 6)
                {
                    string ma = parts[0].Trim();
                    string ten = parts[1].Trim();
                    int soTiet = int.Parse(parts[2].Trim());
                    string gioHoc = parts[3].Trim();
                    int soHV = int.Parse(parts[4].Trim());
                    string gv = parts[5].Trim();

                    KhoaHoc kh = new KhoaHoc(ma, ten, soTiet, gioHoc, soHV, gv);
                    dsKhoaHoc.Add(kh);
                }
            }
            Console.WriteLine($"Đã đọc thành công {dsKhoaHoc.Count} khóa học từ file!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi đọc file: {ex.Message}");
        }
    }

    // Thêm khóa học
    public void ThemKhoaHoc(KhoaHoc kh)
    {
        dsKhoaHoc.Add(kh);
    }

    // Tính tổng tiền thu về sau khi trả thù lao cho giáo viên
    public double TinhTongTienThuVe()
    {
        double tongThu = 0;
        double tongTra = 0;

        foreach (KhoaHoc kh in dsKhoaHoc)
        {
            tongThu += kh.HocPhi * kh.SoHocVien; // Tổng tiền thu từ học viên
            tongTra += kh.TinhThuLaoGiaoVien(); // Tổng tiền trả cho giáo viên
        }

        return tongThu - tongTra;
    }

    // Tính tổng số lớp
    public int TinhTongSoLop()
    {
        return dsKhoaHoc.Count;
    }

    // Lấy danh sách các khóa học có từ 15 học viên trở lên
    public List<KhoaHoc> LayKhoaHocTu15HV()
    {
        return dsKhoaHoc.Where(kh => kh.SoHocVien >= 15).ToList();
    }

    // Đếm số khóa học mà giáo viên x đang dạy
    public int DemKhoaHocCuaGiaoVien(string tenGiaoVien)
    {
        return dsKhoaHoc.Count(kh => kh.GiaoVien.Equals(tenGiaoVien, StringComparison.OrdinalIgnoreCase));
    }

    // Sắp xếp theo học phí giảm dần
    public void SapXepTheoHocPhiGiamDan()
    {
        dsKhoaHoc.Sort((kh1, kh2) => kh2.HocPhi.CompareTo(kh1.HocPhi));
    }

    // In các khóa học có tên x
    public void InKhoaHocTheoTen(string tenKhoaHoc)
    {
        var ketQua = dsKhoaHoc.Where(kh => kh.TenKhoaHoc.Equals(tenKhoaHoc, StringComparison.OrdinalIgnoreCase)).ToList();

        if (ketQua.Count > 0)
        {
            Console.WriteLine($"\n=== KHÓA HỌC CÓ TÊN '{tenKhoaHoc}' ===");
            foreach (KhoaHoc kh in ketQua)
            {
                kh.XuatKhoaHoc();
            }
        }
        else
        {
            Console.WriteLine($"Không tìm thấy khóa học có tên '{tenKhoaHoc}'");
        }
    }

    // In danh sách khóa học theo từng giờ học
    public void InKhoaHocTheoGioHoc()
    {
        // Khóa học buổi 2,4,6
        var kh246 = dsKhoaHoc.Where(kh => kh.GioHoc == "2,4,6").ToList();
        Console.WriteLine("\n=== KHÓA HỌC BUỔI 2,4,6 ===");
        foreach (KhoaHoc kh in kh246)
        {
            kh.XuatKhoaHoc();
        }

        // Khóa học buổi 3,5,7
        var kh357 = dsKhoaHoc.Where(kh => kh.GioHoc == "3,5,7").ToList();
        Console.WriteLine("\n=== KHÓA HỌC BUỔI 3,5,7 ===");
        foreach (KhoaHoc kh in kh357)
        {
            kh.XuatKhoaHoc();
        }

        // Khóa học cuối tuần 7,CN
        var kh7CN = dsKhoaHoc.Where(kh => kh.GioHoc == "7,CN").ToList();
        Console.WriteLine("\n=== KHÓA HỌC CUỐI TUẦN 7,CN ===");
        foreach (KhoaHoc kh in kh7CN)
        {
            kh.XuatKhoaHoc();
        }
    }

    // In toàn bộ danh sách khóa học
    public void InDanhSach()
    {
        Console.WriteLine("\n=== DANH SÁCH TẤT CẢ KHÓA HỌC ===");
        for (int i = 0; i < dsKhoaHoc.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {dsKhoaHoc[i]}");
        }
    }
}

// Lớp Program để test
public class Program
{
    public static void Main()
    {

        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        // Tạo đối tượng quản lý danh sách khóa học
        DSKhoaHoc ds = new DSKhoaHoc();

        // Tạo một số khóa học mẫu để test
        ds.ThemKhoaHoc(new KhoaHoc()); // Constructor mặc định
        ds.ThemKhoaHoc(new KhoaHoc("CS101", "C# Programming", 60, "3,5,7", 20, "Le Thi B"));
        ds.ThemKhoaHoc(new KhoaHoc("JS201", "JavaScript Advanced", 40, "7,CN", 15, "Tran Van C"));
        ds.ThemKhoaHoc(new KhoaHoc("PY301", "Python Programming", 50, "2,4,6", 8, "Nguyen Van A"));
        ds.ThemKhoaHoc(new KhoaHoc("CS102", "C# Programming", 45, "3,5,7", 25, "Le Thi B"));

        // Test các chức năng
        Console.WriteLine("=== DEMO CHƯƠNG TRÌNH QUẢN LÝ KHÓA HỌC ===\n");

        // In toàn bộ danh sách
        ds.InDanhSach();

        // Tính tổng tiền thu về
        Console.WriteLine($"\nTổng tiền thu về sau khi trả lương: {ds.TinhTongTienThuVe():N0} VNĐ");
        Console.WriteLine($"Tổng số lớp: {ds.TinhTongSoLop()}");

        // Lấy khóa học có từ 15 HV trở lên
        var khoaHoc15HV = ds.LayKhoaHocTu15HV();
        Console.WriteLine($"\nSố khóa học có từ 15 HV trở lên: {khoaHoc15HV.Count}");

        // Đếm khóa học của giáo viên
        Console.WriteLine($"Giáo viên 'Le Thi B' đang dạy: {ds.DemKhoaHocCuaGiaoVien("Le Thi B")} khóa học");

        // Sắp xếp theo học phí giảm dần
        ds.SapXepTheoHocPhiGiamDan();
        Console.WriteLine("\n=== SAU KHI SẮP XẾP THEO HỌC PHÍ GIẢM DẦN ===");
        ds.InDanhSach();

        // In khóa học theo tên
        ds.InKhoaHocTheoTen("C# Programming");

        // In khóa học theo giờ học
        ds.InKhoaHocTheoGioHoc();

        // Test toán tử +
        Console.WriteLine("\n=== TEST TOÁN TỬ + ===");
        KhoaHoc kh1 = new KhoaHoc("TEST01", "Test Course", 30, "2,4,6", 12, "Test Teacher");
        Console.WriteLine("Khóa học gốc:");
        kh1.XuatKhoaHoc();

        KhoaHoc kh2 = kh1 + 10; // Thêm 10 tiết
        Console.WriteLine("Khóa học sau khi + 10 tiết:");
        kh2.XuatKhoaHoc();

        Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}