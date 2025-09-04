using System;
using System.Linq;
using myExtension; // phải using file mã nguồn cần khởi tạo extention

namespace CS035_Extension;

// Muốn định nghĩa các lớp extention thì bắt buộc phải định nghĩa trong phương thức static
static class Abc
{
    public static void Print(this string s, ConsoleColor color)
    // phương thức này muốn mở rộng đối tượng của phương thức nào, thì tham số đầu tiên phải là đối tượng của lớp đó 
    // tham số đầu tiên phải thêm từ khoá "this"
    {
        Console.ForegroundColor = color;
        Console.WriteLine(s);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // ví dụ về extention:
        int[] arr = { 1, 3, 5, 2, 4 };
        int max = arr.Max(); // Max() là phương thức mở rộng có sẵn
        Console.WriteLine(max);

        string s = "Hello World";
        s.Print(ConsoleColor.Green);

        // áp dụng nhiều lần
        "CSharp".Print(ConsoleColor.Red);
        "is".Print(ConsoleColor.Blue);
        "the".Print(ConsoleColor.Yellow);
        "best".Print(ConsoleColor.Green);

        // ví dụ việc xây dựng một phương thức mở rộng 
        double a = 2.5;
        Console.WriteLine(a.Power());
        Console.WriteLine(a.SquareRoot());
    }
}