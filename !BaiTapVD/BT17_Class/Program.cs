using System;

namespace BT17_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo bằng constructor mặc định
            Student s1 = new Student();
            s1.ShowInfo();
            Console.WriteLine("Diem dat tieu chuan: " + s1.IsPassed());
            Console.WriteLine("----------------------------");

            // Khởi tạo bằng constructor có tham số
            Student s2 = new Student(1, "Nguyen Van A", 20, 8.5);
            s2.ShowInfo();
            Console.WriteLine("Diem dat tieu chuan: " + s2.IsPassed());
            Console.WriteLine("----------------------------");

            // Dùng setter để thay đổi giá trị
            Student s3 = new Student();
            s3.Id = 2;
            s3.Name = "Tran Thi B";
            s3.Age = 19;
            s3.Score = 4.2;
            s3.ShowInfo();
            Console.WriteLine("Diem dat tieu chuan: " + s3.IsPassed());
        
        }
    }
}
