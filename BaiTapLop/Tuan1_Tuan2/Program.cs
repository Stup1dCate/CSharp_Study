/*
Bài tập chương 1: C# căn bản
*/
using System;
using System.Reflection.Metadata.Ecma335;
/*
* Viết chương trình nhập 2 số nguyên, xuất tổng, hiệu, tích, thương.
*/
/*
class Program
{
    static void Main()
    {
        // Nhập 2 số nguyên
        Console.Write("Nhap so thu nhat: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap so thu hai: ");
        int b = int.Parse(Console.ReadLine());

        // Xuất kết quả
        Console.WriteLine("Tong: " + (a + b));
        Console.WriteLine("Hieu: " + (a - b));
        Console.WriteLine("Tich: " + (a * b));

        if (b != 0)
        {
            // Thương (ép kiểu double để ra số thực)
            Console.WriteLine("Thuong: " + ((double)a / b));
        }
        else
        {
            Console.WriteLine("Khong the chia cho 0!");
        }
    }
}
*/

/*
* Viết chương trình nhập chiều dài, chiều rộng hình chữ nhật, xuất chu vi, diện tích của hình chữ nhật đó.
*/
/*
class Program
{
    static void Main()
    {
        // Nhập chiều dài, chiều rộng
        Console.Write("Nhap chieu dai: ");
        double d = double.Parse(Console.ReadLine());

        Console.Write("Nhap chieu rong: ");
        double r = double.Parse(Console.ReadLine());

        // Xuất kết quả
        Console.WriteLine("Chu vi hinh chu nhat: " + 2*(d + r));
        Console.WriteLine("Dien tich hinh chu nhat: " + (d * r));
    }
}
*/
/*
* Viết chương trình nhập bán kính hình tròn, xuất chu vi, diện tích của hình tròn đó.
*/
/*
class Program
{
    static void Main()
    {
        // Nhập bán kính
        Console.Write("Nhap ban kinh: ");
        double r = double.Parse(Console.ReadLine());
        // Xuất kết quả
        Console.WriteLine("Chu vi hinh tron: " + (2 * Math.PI * r));
        Console.WriteLine("Dien tich hinh tron: " + (Math.PI * r * r));
    }
}
*/
/*
* Viết chương trình nhập số nguyên N, kiểm tra và xuất kết quả N là số chẵn/lẻ.
*/
/*
class Program
{
    static void Main()
    {
        Console.Write("Nhap so nguyen N: ");
        int N = int.Parse(Console.ReadLine());
        if (N % 2 == 0) {
            Console.WriteLine(N + " la so chan.");
        } else
        {
            Console.WriteLine(N + " la so le.");
        }
    }
}
*/
/*
* Viết chương trình nhập số nguyên N, kiểm tra và xuất kết quả N là số âm/zero/dương.
*/
/*
class Program
{
    static void Main()
    {
        Console.Write("Nhap so nguyen N: ");
        int N = int.Parse(Console.ReadLine());
        if (N == 0)
        {
            Console.WriteLine(N + " la so zero");
        }
        else if (N > 0) {
            Console.WriteLine(N + " la so duong");
        }
        else
        {
            Console.WriteLine(N + " la so am");
        }
    }
}
*/
/*
* Viết chương trình nhập số tự nhiên N, kiểm tra và xuất kết quả N là số nguyên tố hay không.
*/
/*
class Program
{
    static bool IsNguyenTo(int n)
    {
        if(n < 2)
        {
            return false;
        }
        for (int i=2; (i*i)<=n; i++)
        {
            if(n%i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Nhap so tu nhien N: ");
        int N = int.Parse(Console.ReadLine());
        if (IsNguyenTo(N))
        {
            Console.WriteLine(N + " la so nguyen to.");
        } else
        {
            Console.WriteLine(N + " khong phai la so nguyen to");
        }
    }
}
*/
/*
* Viết chương trình nhập số tự nhiên N, xuất kết quả:
* a. Các số tự nhiên <=N và tổng của chúng
* b. Các số tự nhiên chẵn <=N và tổng của chúng
* c. Các số tự nhiên lẻ <=N và tổng của chúng
* d. Các số tự nhiên là số nguyên tố <=N và tổng của chúng
* e. N số nguyên tố đầu tiên
*/
/*
class Program
{
    public void CauA(int N)
    {
        int sum = 0;
        Console.Write("Cac so tu nhien: ");
        for (int i = 0; i <= N; i++)
        {
            Console.Write(i + " ");
            sum += i;
        }
        Console.Write("\n");
        Console.WriteLine("Tong cua chung: " + sum);
    }

    public void CauB(int N)
    {
        int sum = 0;
        Console.Write("Cac so chan: ");
        for (int i = 0; i <= N; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
                sum += i;
            }
        }
        Console.Write("\n");
        Console.WriteLine("Tong cua chung: " + sum);
    }

    public void CauC(int N)
    {
        int sum = 0;
        Console.Write("Cac so le: ");
        for (int i = 0; i <= N; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
                sum += i;
            }
        }
        Console.Write("\n");
        Console.WriteLine("Tong cua chung: " + sum);
    }
    public bool IsNguyenTo(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; (i * i) <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public void CauD(int N)
    {
        int sum = 0;
        Console.Write("Cac so nguyen to: ");
        for (int i = 0; i <= N; i++)
        {
            if (IsNguyenTo(i))
            {
                Console.Write(i + " ");
                sum += i;
            }
        }
        Console.Write("\n");
        Console.WriteLine("Tong cua chung: " + sum);
    }

    public void CauE (int N)
    {
        int length = 0;
        int i = 0;
        while (length < N)
        {
            if(IsNguyenTo(i))
            {
                Console.Write(i + " ");
                length++;
                i++;
            } else
            {
                i++;
            }
        }
    }

    static void Main()
    {
        Program p = new Program();

        Console.Write("Nhap so tu nhien N: ");
        int N = int.Parse(Console.ReadLine());

        p.CauA(N);
        p.CauB(N);
        p.CauC(N);
        p.CauD(N);
        p.CauE(N);
    }
}
*/
/*
* Viết chương trình nhập số tự nhiên N, nhập N phần tử của mảng a, xuất kết quả:
* a.Các phần tử của mảng a và tổng của chúng
* b. Các phần tử chẵn của mảng a và tổng của chúng
* c. Các phần tử lẻ của mảng a và tổng của chúng
* d. Các phần tử là số nguyên tố của mảng a và tổng của chúng
* e. Thêm 1 phần tử mới vào mảng
* f. Xóa phần tử thứ k của mảng a
* g. Nhập 1 số x, kiểm tra x có trong mảng a không, nếu có thì trả về vị trí của x trong mảng a
*/
class Program
{
    public void CauA(int[] a, int N)
    {
        int sum = 0;
        Console.Write("Mang: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(a[i] + " ");
            sum += a[i];
        }
        Console.WriteLine(" ");
        Console.WriteLine("Tong: " + sum);
    }

    public void CauB(int[] a, int N)
    {
        int sum = 0;
        Console.Write("So chan: ");
        for (int i = 0; i < N; i++)
        {
            if (a[i] % 2 == 0)
            {
                Console.Write(a[i] + " ");
                sum += a[i];
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Tong: " + sum);
    }

    public void CauC(int[] a, int N)
    {
        int sum = 0;
        Console.Write("So le: ");
        for (int i = 0; i < N; i++)
        {
            if (a[i] % 2 != 0)
            {
                Console.Write(a[i] + " ");
                sum += a[i];
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Tong: " + sum);
    }

    public bool IsNguyenTo(int n)
    {
        if (n < 2)
        {
            return false;
        }
        for (int i = 2; (i * i) <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public void CauD(int[] a, int N)
    {
        int sum = 0;
        Console.Write("So nguyen to: ");
        for (int i = 0; i < N; i++)
        {
            if (IsNguyenTo(a[i]))
            {
                Console.Write(a[i] + " ");
                sum += a[i];
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Tong: " + sum);
    }

    public void CauE(ref int[] a, ref int N, int value)
    {
        Array.Resize(ref a, N + 1);
        a[N] = value;
        N++;
        Console.Write("Mang sau khi them: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }

    public void CauF(ref int[] a, ref int N, int k)
    {
        if (k >= 0 && k < N)
        {
            for (int i = k; i < N - 1; i++)
                a[i] = a[i + 1];
            Array.Resize(ref a, N - 1);
            N--;
            Console.Write("Mang sau khi xoa: ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

        }
        else
        {
            Console.WriteLine("Vi tri k khong hop le!");
        }
    }

    public void CauG(int[] a, int N, int x)
    {
        int index = Array.IndexOf(a, x);
        if (index != -1)
            Console.WriteLine($"Tim thay {x} tai vi tri {index}");
        else
            Console.WriteLine($"{x} khong co trong mang.");
    }

    static void Main()
    {
        Program p = new Program();
        Console.Write("N = ");
        int N = int.Parse(Console.ReadLine());

        int[] a = new int[N];

        for (int i = 0; i < N; i++)
        {
            Console.Write("a[" + i + "]: ");
            a[i] = int.Parse(Console.ReadLine());
        }

        p.CauA(a, N);
        p.CauB(a, N);
        p.CauC(a, N);
        p.CauD(a, N);

        Console.Write("Nhap phan tu can them: ");
        int value = int.Parse(Console.ReadLine());
        p.CauE(ref a, ref N, value);

        Console.Write("Nhap vi tri k can xoa: ");
        int k = int.Parse(Console.ReadLine());
        p.CauF(ref a, ref N, k);

        Console.Write("Nhap so x can tim: ");
        int x = int.Parse(Console.ReadLine());
        p.CauG(a, N, x);
    }
}
/*
Viết chương trình nhập chuỗi s, xuất kết quả:
a.Độ dài của s
b. Xóa bỏ khoảng trắng thừa của s
c. Đếm số từ của s và xuất mỗi từ một dòng
d. Nhập số tự nhiên k, xuất k ký tự bên trái của s, k ký tự bên phải của s
e. Nhập số tự nhiên k, n. Xuất n ký tự của s kể từ vị trí k.
*/

