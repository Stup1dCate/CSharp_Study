using System;

/* PHƯƠNG THỨC ẢO - VIRTUAL METHOD
+ là phương thức được định nghĩa trong lớp cơ sở
+ phương thức này có thể bị ghi đè bởi lớp kế thừa
*/
namespace CS029_VirtualMethod
{
    class Product
    {
        protected double Price { set; get; }
        public virtual void ProductInfo() // đặt virtual phía sau phạm vi truy cập và phía trước kiểu lớp
        {
            Console.WriteLine($"Gia san pham: {Price}");
        }
        // phương thức ảo là phương thức mà nó sẽ được ghi đè lên nó 
        // => phương thức ProductInfo() này có thể bị ghi đè, định nghĩa lại bởi lớp kế thừa
        public void Test() => ProductInfo();
    }

    class Iphone : Product
    {
        public Iphone() => Price = 500;
        public override void ProductInfo() // phương thức được ghi đè là phương thức phải ghi lại đúng tên và cấu trúc từ lớp cơ sở
        {
            // phương thức được ghi đè trong lớp kế thừa phải thay thế từ "virtual" = "override" (ghi đè)
            Console.WriteLine("Dien thoai Iphone");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Iphone Ip = new Iphone();
            Ip.Test(); // ouput ban đầu là "Gia san pham: 500"; (Trong lop Product)
                       // output sau khi ghi đè: "Dien thoai Iphone"; (trong lop Iphone)
            // sau khi nạp trồng ở lớp kế thừa: Ip.Test() -> ProductInfo() (trong Product) -> ProductInfo() (trong Iphone - ghi đè lại)
        }
    }
}



