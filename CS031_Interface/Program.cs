using System;
/* GIAO DIỆN - INTERFACE: 
+ Có ý nghĩa gần giống với lớp abstract, chỉ có điều khai báo thì dùng từ khóa interface thay cho từ khóa class 
+ TẤT CẢ các phương thức đều khai báo KHÔNG có thân (chỉ có tên - nghĩa là phương thức abstract ...) 
+ Lớp triển khai giao diện (lớp kế thừa) bắt buộc phải định nghĩa lại (không cần từ khóa overrid) tất cả các phương thức này, 
cũng có một điều khác là lớp kế thừa có thể kế thừa nhiều giao diện.
*/
namespace CS031_Interface
{
    interface IHinhHoc
    {
        public double TinhChuVi();
        public double TinhDienTich();

    }
    class HinhChuNhat : IHinhHoc // lớp hcn kế thừa IHinhHoc
    {
        public HinhChuNhat(double _a, double _b) // pthuc khoi tao
        {
            a = _a;
            b = _b;
        }
        // pthuc get/setter
        public double a { set; get; }
        public double b { set; get; }

        public double TinhChuVi()
        {
            return 2 * (a + b);
        }

        public double TinhDienTich()
        {
            return a * b;
        }

    }
    class Hinhtron : IHinhHoc
    // có thể triển khai nhiều giao diện khác với cách trình bày: "Hinhtron : IHinhHoc, Giaodien2, Giaodien3 ,..."
    {
        public Hinhtron(double _r) => r = _r;
        public double r { set; get; }
        public double TinhChuVi()
        {
            return 2 * r * Math.PI;
        }

        public double TinhDienTich()
        {
            return r*r*Math.PI;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat(4, 5);
            Console.WriteLine($"Dien tich hinh chu nhat: {hcn.TinhDienTich()} va chu vi la: {hcn.TinhChuVi()}");

            Hinhtron ht = new Hinhtron(3);
            Console.WriteLine($"Dien tich hinh tron: {ht.TinhDienTich()} va chu vi la: {ht.TinhChuVi()}");

            // đây cũng chính là cách triển khai giao diện trong OOP.
            // Mặc dù đối tượng tạo ra là khác nhau nhưng cách triển khai code dự trên giao diện vẫn giống nhau (code sẽ triển khai khác nhau dựa trên các trường hợp cụ thể)
            
        }
    }
}