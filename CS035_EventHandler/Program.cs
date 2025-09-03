using System;
/* CHÚ Ý: 
Trong triển khai lập trình, ưu tiên tạo ra những sự kiện bằng cách sử dụng EventHandler
tránh khai báo các delegate riêng để thống nhất toàn bộ chương trình
*/

namespace CS034_Event
{
    public delegate void SuKienNhapSo(int x);

    // xây dựng một lớp kế thừa từ EventArgs:
    class DataInput : EventArgs {
        public int data { set; get; }
        public DataInput(int x) => data = x;
    }
     
    // publisher: lớp phát sự kiện
    class UserInput
    {

        // public event SuKienNhapSo suKienNhapSo; 
        public event EventHandler suKienNhapSo; // ~ delegate void TYPE(object? sender, EventArgs args)
        // kiểu obj có thể nhận giá trị null
        public void Input()
        {
            do
            {
                Console.WriteLine("Nhap vao so nguyen: ");
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                // phát sự kiện: args ở đây được khởi xây dựng để làm lớp kế thừa 
                suKienNhapSo?.Invoke(this, new DataInput(i)); // đã xong bước khai báo sự kiện
                // sender có thể để null: suKienNhapSo?.Invoke(null, ...);
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
            input.suKienNhapSo += Canbachai; 
        }
        public void Canbachai(object sender, EventArgs e)
        {
            DataInput dataInput = (DataInput)e;
            int i = dataInput.data;
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
        public void TinhBinhPhuong(object sender, EventArgs e)
        {
            DataInput dataInput = (DataInput)e;
            int i = dataInput.data;
            Console.WriteLine($"Binh phuong cua so {i} la: {i*i}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // một trong những ứng dụng phổ biến của event:
            Console.CancelKeyPress += (sender, e) =>
            {
                // Khi bấm ctrl+C trong terminal sẽ hiện ra thông báo này
                Console.WriteLine();
                Console.WriteLine("Thoat ung dung");
            };


            // publisher
            UserInput userInput = new UserInput();
            userInput.suKienNhapSo += (sender, e) =>
            {
                DataInput dataInput = (DataInput)e;
                Console.WriteLine("Ban vua nhap so: " + dataInput.data);
            };

            // subrisher
            // subrisher tính căn bậc 2:
            SquareRoot squareRoot = new SquareRoot();
            squareRoot.Sub(userInput);
            // subrisher tính bình phương:
            Power power = new Power();
            power.Sub(userInput);
           

            userInput.Input();
        }
    }
}