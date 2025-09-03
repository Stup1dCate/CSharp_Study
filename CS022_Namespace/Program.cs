/* Định nghĩa 
    namespace trong C#:
+ Là không gian tên dùng để tổ chức và phân loại các class, struct, interface, enum, delegate…
+ Nó giúp tránh xung đột tên (nếu nhiều class có cùng tên nhưng ở namespace khác nhau thì vẫn dùng được).
+ Có thể hiểu namespace giống như “thư mục” để chứa code, giúp dự án rõ ràng và dễ quản lý.
*/

using System;
// System cũng có thể được đặt tên khác (vd: X => đầy đủ là X.Console.WriteLine(...))
using static System.Console; // sử dụng phương thức tĩnh => Mỗi lần WriteLine/ReadLine không cần ghi đầy đủ System.Console .. nữa 
// using static System.Math; tương tự như trên
using myNamespace;
using Xyz = myNamespace.Abc; // đặt tên cho namespace Abc
// => từ đây dễ thấy Class1 bị trùng tên ở 2 namespace là Abc (namespace con) và myNamespace (namespace cha). Nên ta phải đặt tên phân biệt cho namespace Abc

namespace CS022_Namespace // Đây là namespace
/* trong namespace chứa: class, struct, enum, interface, ...
và chứa cả namspace con

*/
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1.XinChao();
            // mặc định: myNamespace.Class1.XinChao(); => Cũng như System chỉ cần gọi 'using myNamespace' để không cần lặp lại cách gọi này
            Xyz.Clas1.XinChao();
            // mặc định: myNamespace.Abc.Class1.XinChao();

            
        }
    }


}




