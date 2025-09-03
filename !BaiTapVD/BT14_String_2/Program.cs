using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BT14_String_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            1. str1 = "English = 78 Science = 83 Math = 68 History = 65";
            Tính tổng các giá trị số phía trên và tính TBC.

            2. Viết chương trình cho trước một mật khẩu hợp lệ và bắt người dùng nhập vào mật khẩu và kiểm tra xem mk vừa nhập có hợp lệ không? 
            + mk hợp lệ phải có ít nhất 6 kí tự (chứa ít nhất 1 chữ cái hoa - thường đều được)
            + chứa ít nhất 1 số
            + người dùng nhập vào sai quá 5 lần thì thoát chương trình

            3. Viết chương trình chuyển hoá tin nhắn qua mật mã theo hướng:
                #a = "abcdefghijklmnopqrstuvwxyz";
                #b = "zxcvbnmasdfghjklqwertyuiop";

            4. Đếm số lượng từ "C#" xuất hiện trong chuỗi:
            str2 = "Hejlsberg was C#'s principal designer and lead architect at Microsoft,
            and had been previously involved with the design of Turbo Pascal,
            Embarcadero Delphi (formerly CodeGear Delphi, Inprise Delphi and Borland Delphi),
            and Visual J++. In interviews and technical papers, he has stated that flaws in most major
            programming languages (e.g. C++, Java, Delphi, and Smalltalk) drove the fundamentals of the Common Language Runtime (CLR),
            which, in turn, drove the design of the C# language.
            James Gosling, who created the Java programming language in 1994, and Bill Joy,
            a co-founder of Sun Microsystems, the originator of Java, called C# an "imitation" of Java;"

            5. Viết chương trình tách chữ và số thành 2 chuỗi riêng biệt
            */

            // Bai1:
            Console.WriteLine("Bai 1: ");
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string[] list = str1.Split(' '); // chia mảng ban đầu thành các mảng con (cách nhau 1 dấu cách)
            string str1_result = "";
            int sum = 0;
            foreach (string x in list) { // kiểm tra từng phần tử trong list
                foreach (char c in x) { // nếu phần tử x có chứa số -> lập tức thêm x vào result (không thêm từng kí tự của x)
                    if (char.IsDigit(c)) {
                        str1_result += x + " "; // mỗi phần tử x cách nhau 1 dấu cách
                        break;
                    }
                }
            }
            Console.WriteLine(str1_result); // ra được một chuỗi x chỉ chứa toàn số (nhưng đang ở dạng string)
            str1_result = str1_result.Trim(); // loại bỏ khoảng trắng ở đầu và cuối chuỗi
            string[] list_2 = str1_result.Split(' '); // tách chuỗi x ra thành các chuỗi con chứa các số cần lấy ra
            foreach (string x in list_2) {
                sum += int.Parse(x); // tính tổng
            }
            Console.WriteLine("Tong gia tri cac chu so trong mang ban dau la: {0} va gia tri trung binh cong la: {1}", sum, (float)sum/list_2.Length);



            // Bai2:
            Console.WriteLine("\nBai 2: ");
            Console.WriteLine("Nhap vao mot mat khau (it nhat 6 ki tu, it nhat 1 chu cai va 1 chu so): ");
            string pass = Console.ReadLine(); //123456a
            
            bool check_pass = true;
            while (check_pass)
            {
                int count_num = 0;
                int count_letter = 0;
                foreach (char c in pass)
                {
                    if (char.IsDigit(c))
                    {
                        count_num++;
                    }
                    else if (char.IsLetter(c))
                    {
                        count_letter++;
                    }
                }
                if (count_num * count_letter != 0 && pass.Length >= 6)
                {
                    check_pass = false;
                }
                else
                {
                    Console.WriteLine("Nhap lai mat khau (it nhat mot ki tu so hoac chu va phai co do dai it nhat 6 ki tu): ");
                    pass = Console.ReadLine();
                    check_pass = true;
                }
            }



            // Bai3:
            Console.WriteLine("\nBai 3: ");
            Console.WriteLine("Nhap vao mot doan ma can chuyen doi: ");
            string str4 = Console.ReadLine();
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "zxcvbnmasdfghjklqwertyuiop";
            string str4_result = "";
            /* Cách sử dụng StringBuilder
            StringBuilder str4_result = new StringBuilder();
            for (int i = 0; i < str4.Length; i++)
            {
            char ch = str4[i];

            int index = a.IndexOf(ch);
            if (index != -1)
            {
                str4_result.Append(b[index]);
            }
            else
            {
                index = a.ToUpper().IndexOf(ch);
                if (index != -1) {
                    str4_result.Append(char.ToUpper(b[index]));
                }
                    else {
                        str4_result.Append(ch);
                    }
                }
            }
            */
            for (int i = 0;i < str4.Length; i++)
            {
                for(int j = 0; j < a.Length; j++)
                {
                    if (str4[i] == a[j])
                    {
                        str4_result += b[j];
                    }
                }
            }
            Console.WriteLine("input sau khi duoc giai ma la: "+str4_result);



            // Bai4:
            Console.WriteLine("\nBai 4: ");

            string str2 = "Hejlsberg was C#'s principal designer and lead architect at Microsoft," +
            "and had been previously involved with the design of Turbo Pascal," +
            "Embarcadero Delphi(formerly CodeGear Delphi, Inprise Delphi and Borland Delphi)," +
            "and Visual J++.In interviews and technical papers, he has stated that flaws in most major" +
            "programming languages(e.g.C++, Java, Delphi, and Smalltalk) drove the fundamentals of the Common Language Runtime(CLR)," +
            "which, in turn, drove the design of the C# language." +
            "James Gosling, who created the Java programming language in 1994, and Bill Joy," +
            "a co-founder of Sun Microsystems, the originator of Java, called C# an \"imitation\" of Java.";

            int count_java = 0;
            string[] part = str2.Split(new char[] { ' ', ',', '.', '!', ':' }); // loại bỏ các dấu kí tự đặc biệt nằm ngay cạnh từ cần kiểm tra
            for (int i = 0; i < part.Length; i++)
            {
                if (part[i].ToLower() == "java")
                {
                    count_java++;
                }
            }
            Console.WriteLine("So luong tu java dem duoc trong cau tren la: " + count_java);



            // Bai5:
            Console.WriteLine("\nBai 5: ");

            string str3 = "abcd!1234@:nigga36";
            string str3_num = "";
            string str3_letter = "";
            char[] part1 = str3.ToCharArray();
            for (int i = 0; i < part1.Length; i++)
            {
                char c = str3.ElementAt(i);
                if (char.IsLetter(c))
                {
                    str3_letter += c;
                }
                else if (char.IsDigit(c))
                {
                    str3_num += c;
                }
            }
            Console.WriteLine("Chuoi str3 tach thanh chu la: "+str3_letter);
            Console.WriteLine("Chuoi str3 tach thanh so la: "+str3_num);
        }
    }
}
