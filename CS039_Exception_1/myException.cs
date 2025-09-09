using System;

namespace myException
{
    // hàm bắt lỗi tên
    public class NameEmptyException : Exception
    {
        public NameEmptyException() : base("Ten phai khac rong") { }
    }
    // hàm bắt lỗi tuổi
    public class AgeException : Exception
    {
        public int age { set; get; } // khởi tạo thuộc tính age để lưu tuổi không phù hợp khi người dùng nhập
        public AgeException(int _age) : base("Tuoi khong phu hop") // thông báo lỗi
        {
            age = _age; // giữ lại {age} để hiển thị tuổi sai 
        }
        // in chi tiết lỗi 
        public void Detail()
        {
            Console.WriteLine($"Tuoi {age}, khong nam trong khoang yeu cau (18-60)"); // thông báo chi tiết lỗi
        }
    }   
    
}
