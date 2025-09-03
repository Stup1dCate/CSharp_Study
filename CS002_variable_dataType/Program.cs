/*
** Data types - Các kiểu dữ liệu:
Kiểu C#	| Số byte |  Kiểu .NET |    Mô tả
byte	    1	       Byte	        Số nguyên dương không dấu từ 0 đến 255
char	    2	       Char	        Ký tự Unicode
bool	    1	       Boolean	    Giá trị logic true / false
sbyte	    1	       SByte	    Số nguyên có dấu từ -128 đến 127
short	    2	       Int16	    Số nguyên có dấu từ -32.768 đến 32.767
ushort	    2	       UInt16	    Số nguyên dương không dấu từ 0 đến 65.535
int	        4	       Int32	    Số nguyên có dấu từ -2.147.483.647 đến 2.147.483.647
uint	    4	       UInt32	    Số nguyên không dấu từ 0 đến 4.294.967.295
float	    4	       Single	    Kiểu dấu chấm động, giá trị xấp xỉ từ -3.4E-38 đến 3.4E+38, với 7 chữ số có nghĩa
double	    8	       Double	    Kiểu dấu chấm động có độ chính xác gấp đôi, giá trị xấp xỉ từ -1.7E-308 đến 1.7E+308, với 15-16 chữ số có nghĩa
decimal	    8	       Decimal	    Có độ chính xác đến 28 con số và giá trị thập phân, dùng trong tính toán tài chính. Kiểu này cần hậu tố m hoặc M
long	    8	       Int64	    Số nguyên có dấu, giá trị trong khoảng -9.223.372.036.854.775.808 -> 9.223.372.036.854.775.807
ulong	    8	       UInt64	    Số nguyên không dấu từ 0 đến 0xffffffffffffffff

8 bit - với bit đầu tiên là số 0 -> biểu thị cho số dương
                               1 -> biểu thị cho số âm   

** Variable - Biến/khai báo biến và khởi tạo biến:
=> Nếu gán giá trị cụ thể cho biến luôn (byte age = 20;) thì được gọi là khởi tạo biến
   Nếu không gán giá trị cụ thể nào cho biến thì được gọi là khai biến (byte age;)

float var = 1.4f -> phải có chữ "f" sau giá trị được gán
string Name = "Tùng" -> giá trị được gán phải nằm trong dấu <" ">

** Các quy tắc đặt tên biến: 
    + tên biến phân biệt hoa thường -> ưu tiên đặt theo kiểu camel như thường lệ
    + không đặt trùng tên biến với keyword có sẵn
    + không bắt đầu tên biến bằng số
    + không dùng kí tự đặc biệt cho tên biến (! # $ ^ ...)

** Ép kiểu dữ liệu:
    + Ép từ dữ liệu bé hơn -> dữ liệu lớn hơn: Không bị mất dữ liệu
        byte x = 40;
        int y = x;
        => Không báo lỗi vì kiểu byte << int
    + Ép từ dữ liệu lớn hơn -> dữ liệu bé hơn: báo lỗi
        int x = 40;
        short y = x;
        => báo lỗi. Nếu đúng phải là:
            int x = 40;
            short y = (short)x; // ép kiểu

** Kiểu dữ liệu nội suy - implicitType:
    + var y = 123; 
    => kiểm tra bằng cách:
    Console.Write(y.GetType().ToString());
    y = 12.3; // báo lỗi, do khác với kiểu khai báo ban đầu
    + var z = "abc";

# CHÚ Ý: Chỉ sử dụng kiểu dữ liệu nội suy khi KHÔNG thực sự biết trước kiểu dữ liệu của biến. 
KHÔNG KHUYẾN KHÍCH sử dụng vì tốn bộ nhớ #

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0; // khởi tạo biến
            int age; // khai báo biến
            float diemTB = 3.4f;
            string Name = "Tung Vu";
            Console.WriteLine("So luong la: {0} \nDiem trung binh la: {1}", count, diemTB);
            // Console.Write(" {0}, {1}, ... ,{n}", var0, var1, ... ,varn) => cách xuất giá trị nhiều biến


            Console.WriteLine("Ep kieu: ");
            int x = 2;
            int y = 3;
            float z = x / y; // nếu ở đây không ép kiểu thì giá trị của z luôn = 0
            float z2 = (float)  x / y; // đã ép kiểu
            Console.WriteLine("Gia tri cua z la: " + z);
            Console.WriteLine("Gia tri cua z2 la: {0}", z2);
            // Sử dụng dấu "+" trong trường hợp chỉ muốn in ra 1 giá trị
            // Sử dụng dấu "," khi muốn in ra nhiều giá trị và phải có thứ tự


            // Giới hạn của giá trị được ép kiểu
            int k = 10000000; // giá trị thoả mãn kiểu dữ liệu interger
            byte l = (byte) k;
            Console.WriteLine("Gia tri cua l sau khi ep kieu la: " + l);


            // implicitType:
            var h = 123;
            Console.WriteLine("Kieu du lieu cua bien la: " + h.GetType().ToString()); // => interger
            // sau dòng lệnh trên thì chương trình hiểu h có kiểu dữ liệu là Int32
            // y = 12.3; nếu ở đây gán giá trị => lỗi 
            var o = 12.4; // nếu khai báo kiểu var => chương trình tự động gán cho kiểu double -> tốn bộ nhớ (thay vì float -> tích kiệm hơn)
            Console.WriteLine("Kieu du lieu cua bien la: " + o.GetType().ToString()); // => double

            Console.ReadKey();
        }
    }
}
