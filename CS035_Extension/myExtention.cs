using System;

namespace myExtension;
// Đây là một ví dụ việc xây dựng một phương thức mở rộng 
public static class Xyz
{
    public static double Power(this double x) => x * x;
    public static double SquareRoot(this double x) => Math.Sqrt(x);
}