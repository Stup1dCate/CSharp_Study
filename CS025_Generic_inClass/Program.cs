using System;

namespace CS025_Generic_inClass
{
    class Program
    {
        class Product<A> // tạo ra một generic kiểu A của class Program
        {
            A ID;
            public void setID(A _id)
            {
                this.ID = _id;
            }
            public void PrintInfo()
            {
                Console.WriteLine($"ID = {this.ID}");
            }
        }
        public static void Main(string[] args)
        {
            // khởi tạo 2 đối tượng sản phẩm với 2 kiểu dữ liệu khác nhau:
            Product<int> sp1 = new Product<int>();
            sp1.setID(123);
            sp1.PrintInfo();

            Product<string> sp2 = new Product<string>();
            sp2.setID(abc);
            sp2.PrintInfo();

            // Kiểu dữ liệu List/Queue/Stack được xây dựng dựa trên kiểu dữ liệu Generic:
            /*
            List<int> list1 = new List<int>();
            Stack<int> stack;
            Queue<doulbe> q;
            */
        }
    }
}