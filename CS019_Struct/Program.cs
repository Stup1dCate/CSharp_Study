using System;

namespace CS019_Struct
{
    class Program
    {
        public struct Product
        {
            // DU LIEU
            public string name;
            public double price;
            public string Info{
                get { return $"{name}, {price}"; }
            }

            // PHUONG THUC
            public string getInfo()
            {
                return $"Ten san pham: {name}, gia san pham: {price}";
            }

            // Contructor (ham khoi tao)
            public Product(string _name, double _price)
            {
                name = _name;
                this.price = _price;
            }
        }

        public static void Main(string[] args)
        {
            Product sp1;
            sp1.name = "Iphone";
            sp1.price = 1000;

            Product sp2 = new Product("Nokia", 900);

            Console.WriteLine("San pham 1: " + sp1.getInfo());
            Console.WriteLine("San pham 2: " + sp2.getInfo());

            // sự khác biệt của struct và class:
            sp2 = sp1;
            sp2.name = "IphoneXS"; 
            Console.WriteLine("San pham 1: " + sp1.getInfo()); // khi gán sp1 cho sp2 và đổi tên của sp2 thì sp1 không bị ảnh hưởng (Với Class thì có)
            Console.WriteLine("San pham 2: " + sp2.getInfo());
            Console.WriteLine(sp2.Info);
        }
    }
}