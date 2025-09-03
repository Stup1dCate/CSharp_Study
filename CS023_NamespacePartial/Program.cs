using static System.Console;
namespace CS023_NamespacePartial
{
    // phương thức partical giúp chia nhỏ các file mã nguồn nhỏ ra để dễ quản lý với các dự án lớn
    class Program
    {
        static void Main(string[] args)
        {
            Product.product = new Product.product();
            product.name = "Lenovo";
            product.price = "24500";
            product.description = "Day la san pham";
            Console.WriteLine(product.GetInfo());

           // product.manufactory = Product.product.Manufactory; => gọi đến nested class
        }
    }
}