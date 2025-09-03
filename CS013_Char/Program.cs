using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* Cú pháp:
        Cách 1: char <tên biến> = '<ký tự>';
        ex: char ch1 = 'a';
        Cách 2: char <tên biến> = (char) <mã ASCII>;
        ex: char ch2 = 65; // == 'A'
        */
        /* CHÚ Ý:
        + kí tự nằm trong ngoặc nháy đơn ('') KHÔNG được sử dụng nháy kép ("")
        + kí tự phải KHÁC chữ số
        */
            char ch1 = 'A'; 
            Console.WriteLine(ch1);
            Console.WriteLine("Kieu du lieu cua bien tren la: "+ch1.GetType().ToString());
            char ch2 = (char) 64;
            Console.WriteLine(ch2);



        // ÉP KIỂU:
            char ch3 = char.Parse("b"); // Stỉng "b" chỉ có một kí tự mới ép sang char được
            Console.WriteLine(ch3);
            Console.WriteLine(ch3.GetType().ToString());

        // CHUYỂN ĐỔI KIỂU DỮ LIỆU: <=> gần như tương đương với ép kiểu
            char ch4 = Convert.ToChar("c");
            Console.WriteLine(ch4);
            Console.WriteLine(ch4.GetType().ToString());



        // So sánh 2 ký tự với nhau: kí tự đứng trước (có mã ASCII bé hơn) trả về kết quả âm và ngược lại. Bằng nhau thì kết quả = 0
            char ch5 = 'a'; // ASCII = 97
            char ch6 = 'b'; // ASCII = 98
            char ch7 = 'a'; // ASCII = 97
            Console.WriteLine(ch5.CompareTo(ch6)); // 97 - 98 = -1 => return -1
            Console.WriteLine(ch6.CompareTo(ch7)); // 98 - 97 = 1 => return 1
            Console.WriteLine(ch5.CompareTo(ch7)); // 97 - 97 = 0 => return 0

            Console.WriteLine(ch5.Equals(ch7)); // 97 = 97 => return True
            Console.WriteLine(ch5.Equals(ch6)); // 97 != 98 => return False



            // CHAR METHOD: (kiểm tra true/false)
            /*
            Cú pháp:	                Nội dung:	                                        Ví dụ:
            Char.IsDigit(ch)	        True nếu char truyền vào là chữ số (0,1,2,...)	    Char.IsDigit('1')
            Char.IsLetter(ch)	        True nếu char truyền vào là chữ cái (a,b,c,A..)	    Char.IsLetter('a')
            Char.IsWhiteSpace(ch)	    True nếu char truyền vào là space	                Char.IsWhiteSpace(' ')
            Char.IsLower(ch)	        True nếu char truyền vào là ký tự thường	        Char.IsLower('b')
            Char.IsUpper(ch)	        True nếu char truyền vào là ký tự viết hoa	        Char.IsUpper('B')
            */
            Console.WriteLine(Char.IsDigit('1'));
            Console.WriteLine(Char.IsLetter('a'));
            Console.WriteLine(Char.IsWhiteSpace(' '));
            Console.WriteLine(Char.IsLower('b'));
            Console.WriteLine(Char.IsUpper('B'));
        }
    }
}
