using System;
/* KIỂU DỮ LIỆU NULL

+ null là một giá trị cố định nó biểu thị không có đối tượng nào cả, 
có nghĩa là biến có giá trị null không có tham chiếu (trỏ) đến đối tượng nào (không có gì).

+ null chỉ có thể gán được cho các biến kiểu tham chiếu (biến có kiểu dữ liệu là các lớp), 
không thể gán null cho những biến có kiểu dữ liệu dạng tham trị như int, float, bool ...

*/
namespace CS028_Null
{
    class Abc
    {
        public void XinChao() => Console.WriteLine("Xin chao");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Abc a = null; // nếu muốn a tham chiếu đến một đối tượng cụ thể thì a phải != null
            Abc b = new Abc();

            // cách kiểm tra và thi hành khi khác null: 
            if (a != null) a.XinChao(); // cách đầy đủ
            b?.XinChao();               // cách ngắn gọn hơn

            // những biến kiểu tham trị thì không được phép gán giá trị null (int, float, ...)
            // int i = null; => báo lỗi

            // KHAI BÁO BIẾN NULLABLE (những biến có thể nhận giá trị hoặc null)
            // ví dụ một biến kiểu tham trị có thể được để trống (null)
            int? age; // khai báo có dấu "?" trước tên biến
            age = null; // sau đó gán null như bình thường

            age = 10;
            if (age.HasValue) // có thể ghi là (age != null) như bình thường
            {
                //int _age = age.Value;
                int _age = (int)age;
                // nếu ở đây đã xác định được kiểu dữ liệu của biến rồi thì ta có thể ép kiểu theo kiểu dữ liệu của biến luôn
                // không cần .Value để đọc thuộc tính giá trị nữa
                Console.WriteLine(_age);
            } 
        }
    }
}