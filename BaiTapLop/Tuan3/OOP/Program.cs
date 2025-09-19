using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Chay Bai 1");
                Console.WriteLine("2. Chay Bai 2");
                Console.WriteLine("0. Thoat");
                Console.Write("Nhap lua chon: ");
                
                string input = Console.ReadLine();
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Vui long nhap so hop le!");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Bai1.Run();
                        break;
                    case 2:
                        Bai2.Run();
                        break;
                    case 0:
                        Console.WriteLine("Thoat chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }

                Console.WriteLine(); // xuong dong cho dep
            } while (choice != 0);
        }
    }

