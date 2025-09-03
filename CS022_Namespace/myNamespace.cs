using System;

namespace myNamespace
{
    public class Class1
    {
        public static void XinChao()
        {
            Console.WriteLine("Xin chao CSharp tu Class1");
            // mặc định phải là System.Console.WriteLine(...) => nhưng chương trình đã có 'using System' ở dòng đầu tiên rồi nên không cần ghi lại
        }
    }
    namespace Abc // namespace này (Abc) nằm trong namespace cha là myNamespace
    {
        public class Class1 // Class1 nhưng là của namespace Abc
        {
            public static void XinChao()
            {
                Console.WriteLine("Xin chao CSharp tu Class1 / Abc");
            }
        }
        // namespace Xyz => trong namespace Abc có thể chứa tiếp namespace con khác nữa
    }
}