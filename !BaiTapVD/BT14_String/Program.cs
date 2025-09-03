using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT14_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhập vào một chuỗi => chuyển đổi hết string thành các kí tự (char) để xét cụ thể từng kí tự
            /*
            1. Đếm xem có bao nhiêu kí tự thường
            2. Bao nhiêu kí tự in hoa
            3. Bao nhiêu số
            4. Bao nhiêu space
            5. Bao nhiêu kí tự khác
            */
            Console.WriteLine("Nhap vao mot chuoi: ");
            String str = "Hello World - date: 19/08/2025";
            int space = 0;
            int upperCase = 0;
            int lowerCase = 0;
            int number = 0;
            int kitu = 0;
            char[] list = str.ToCharArray();
            foreach (char c in list) {
                if (char.IsDigit(c))
                {
                    number++;
                }
                else if (char.IsUpper(c))
                {
                    upperCase++;
                }
                else if (char.IsLower(c))
                {
                    lowerCase++;
                }
                else if (char.IsWhiteSpace(c))
                {
                    space++;
                }
                else { 
                    kitu++;
                }
            }
            Console.WriteLine("Chuoi tren co {0} ki tu thuong, {1} ki tu hoa, {2} khoang trang, {3} ki tu so va {4} cac ki tu dac biet khac.", lowerCase, upperCase, space, number, kitu);
        }
    }
}
