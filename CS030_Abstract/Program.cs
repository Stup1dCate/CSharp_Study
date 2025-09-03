using System;

/* LỚP TRỪU TƯỢNG - ABSTRACT
+ Trong lớp trừu tượng, còn có thể khai báo phương thức trừu tượng với từ khóa abstract,
phương thức này không có thân (chỉ có tên - tham số), nó yêu cầu lớp kế thừa BẮT BUỘC phải nạp chồng (override)
+ không được dùng để tạo ra các đối tượng mà chỉ dùng để làm cơ sở cho các lớp kế thừa 
*/
namespace CS029_VirtualMethod
{
    abstract class Product // lớp này (abstract) không được dùng để tạo ra các đối tượng
    {
        protected double Price { set; get; }
        public abstract void ProductInfo(); // không có thân (chỉ có tên và tham số)
        public void Test() => ProductInfo();
    }

    class Iphone : Product // vì lớp này kế thừa từ lớp abstract nên bắt buộc phải ghi đè (override) lại 
    {
        public Iphone() => Price = 500;
        public override void ProductInfo()
        {
            Console.WriteLine("Dien thoai Iphone");
            Console.WriteLine($"Gia san pham {Price}");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Iphone Ip = new Iphone();
            Ip.Test(); 
        }
    }
}



