using System;
using System.IO;
/*
1. Đọc thông tin ổ đĩa
2. Làm việc với ổ đĩa bằng lớp Directory
3. Đường dẫn file và thư mục với lớp Path
4. làm việc với thư mục bằng lớp File (đọc - xoá - copy - ...)
5. Đọc ghi file với FileStream
6. Lưu trữ và đọc dữ liệu đối tượng từ file
*/
/*
Thuộc tính lớp DriveInfo:
1. IsReady
-> true ổ đĩa ở trạng thái sẵn sàng (hoạt động) – ví dụ ổ đĩa CD nếu không có đĩa thì không sẵn sàng false

2. DriveType
-> Kiểu ổ đĩa (System.IO.DriveType): CDRom, Fixed (ổ cố định - gắn trong máy), Network (ổ mạng), NoRootDirectory, Ram, Removable (USB), Unknown

3. VolumeLabel
-> Nhãn đĩa (nhẵn thư mục khi người dùng tạo một thư mục mới - ví dụ "New Volume")

4. DriveFormat
-> Chuỗi cho biết định dạng đĩa: NTFS (tệp hệ thống mặc định của Windown), FAT32, FAT, devfs ...

5. AvailableFreeSpace
-> Số byte có hiệu lực còn trống (theo hạn ngạch người dùng)

6. TotalFreeSpace
-> Số byte còn trống

7. TotalSize
-> Tổng số byte trên đĩa
*/
namespace CS041_1_file
{
    class Program
    {
        static void Main(string[] args)
        {
            // truy cập các thuộc tính của ổ đĩa
            DriveInfo dr = new DriveInfo("D");
            Console.WriteLine($"Drive: {dr.Name}");              // tên
            Console.WriteLine($"DriveType: {dr.DriveType}");     // kiểu
            Console.WriteLine($"Label: {dr.VolumeLabel}");       // nhãn
            Console.WriteLine($"Format: {dr.DriveFormat}");      // định dạng
            Console.WriteLine($"Size: {dr.TotalSize}");          // tổng dung lượng
            Console.WriteLine($"Free: {dr.TotalFreeSpace}");     // dung lượng khả dụng còn lại


            // lấy ra tất cả ổ đĩa có trên máy này:
            Console.WriteLine("\nHien thi thong tin tat ca cac o dia trong may: ");
            var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine($"Drive: {drive.Name}");
                Console.WriteLine($"DriveType: {drive.DriveType}");
                Console.WriteLine($"Label: {drive.VolumeLabel}");
                Console.WriteLine($"Format: {drive.DriveFormat}");
                Console.WriteLine($"Size: {drive.TotalSize}");
                Console.WriteLine($"Free: {drive.TotalFreeSpace}");
                Console.WriteLine("\n");
            }
        }
    }
}