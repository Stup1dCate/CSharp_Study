using System;

namespace bai17_Class
{
    // PHƯƠNG THỨC HUỶ:
    class Student
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
            Console.WriteLine("Khoi tao doi tuong " + name);
        }
        ~Student() // => Phương thức huỷ: trùng với tên lớp và bắt đầu = dấu ngã, không có kiểu trả về + không có tham số
        {
            Console.ForegroundColor = ConsoleColor.Red;
            // khai báo hành động đối tượng sẽ làm khi bị huỷ
            Console.WriteLine("Huy doi tuong " + name);
            Console.ResetColor();
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            weapons sungluc; // hiện tại: null
            sungluc = new weapons(); // được khởi tạo
            sungluc.name = "Sung Luc";
            sungluc.thietLapDoSatThuong(5);

            // khởi tạo cùng lúc nhiều phương thức cho một đối tượng
            weapons sungMay = new weapons("Sung May", 15);

            Console.WriteLine(sungluc.satThuong);
            sungluc.tanCong();

            Console.WriteLine(sungMay.satThuong);
            sungMay.tanCong();

            // khợi tạo nhanh thuộc tính get/set
            sungluc.noiSanXuat = "USA";
            Console.WriteLine("Noi san xuat sung luc la: " + sungluc.noiSanXuat);




            Student student;

            // khởi tạo 1000 sinh viên => kiểm tra phương thức huỷ
            for (int i = 0; i < 100000; i++)
            {    
                student = new Student("Sinh vien "+i);
                student = null;
            }
            // Đến lúc khởi tạo một đối tượng sinh viên nhất định mà thiếu bộ nhớ thì chương trình tự động thu hồi các đối tượng sinh viên trước đó
            GC.Collect(); // lập tức thu hồi phương thức huỷ
        }
    }
}