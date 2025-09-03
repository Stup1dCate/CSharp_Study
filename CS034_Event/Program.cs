using System;
/* Lập trình hướng sự kiện - Event:
    publisher -> class - phát sự kiện 
    subrisher -> class - nhận sự kiện
*/

namespace CS034_Event
{
    public delegate void SuKienNhapSo(int x);
    
    // publisher: lớp phát sự kiện
    class UserInput
    {
        // public SuKienNhapSo suKienNhapSo { set; get; }
        public event SuKienNhapSo suKienNhapSo; // khi khai báo một biến kiểu delegate sự kiện thì không thể khởi tạo phương thức get-set được
        public void Input()
        {
            do
            {
                Console.WriteLine("Nhap vao so nguyen: ");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                // phát sự kiện
                suKienNhapSo?.Invoke(i);
            }
            while (true);
        }
    }


    // subrisher: lớp nhận sự kiện khi sự kiện được phát
    // tính căn bậc 2
    class SquareRoot
    {
        // phương thức đăng kí sự kiện nhận số của class UserInput:
        public void Sub(UserInput input)
        {
            // input.suKienNhapSo = Canbachai;
            input.suKienNhapSo += Canbachai; // khi khai báo delegate event phải đổi thành phép toán += KHÔNG ĐƯỢC dùng phép gán

        }
        public void Canbachai(int i)
        // sự kiện nhận số này phải có dạng giống với delegate đã khai báo phía trên <public delegate void SuKienNhapSo(int x);>
        {
            Console.WriteLine($"Can bac 2 cua so {i} la: {Math.Sqrt(i)}");
        }
    }
    // tính bình phương
    class Power
    {
        public void Sub(UserInput input)
        {
            // input.suKienNhapSo = TinhBinhPhuong;
            input.suKienNhapSo += TinhBinhPhuong;

        }
        public void TinhBinhPhuong(int i)
        {
            Console.WriteLine($"Binh phuong cua so {i} la: {i*i}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // publisher
            UserInput userInput = new UserInput();
            userInput.suKienNhapSo += x =>
            {
                Console.WriteLine("Ban vua nhap so: " + x);
            };

            // subrisher
            // subrisher tính căn bậc 2:
            SquareRoot squareRoot = new SquareRoot();
            squareRoot.Sub(userInput);
            // subrisher tính bình phương:
            Power power = new Power();
            power.Sub(userInput);
            /*
            mặc dù cả 2 lớp đều đăng kí tự kiện cho các userInput nhưng chương trình chỉ nhận
            hàm cuối cùng đăng kí (mỗi khi có 1 hàm khác đăng kí thì chương trình sẽ huỷ hàm 
            đăng kí gần nhất đi và nhận hàm mới nhất) 
            => Vì vậy ta cần biết về delegate sự kiện (Event) để giải quyết vấn đề này
            */

            userInput.Input();
        }
    }
}