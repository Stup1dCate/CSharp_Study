using System;

namespace bai16_Methods
{
    public class Tinhtoan
    {
        // nếu tham số truyền vào là số nguyên hay số thực thì sẽ thực hiện hàm tương ứng 
        // mặc dù có cùng tên nhưng khác kiểu trả về => phụ thuộc vào tham số truyền vào ở Program
        public static int Tong(int a, int b)
        {
            return a + b;
        }
        public static float Tong(float a, float b)
        {
            return a + b;
        }
    }
}

