using System;
/* KIỂU DỮ LIÊU ĐỘNG - DYNAMIC

*/
namespace CS027_DynamicType
{
    class Program
    {
        class Student
        {
            public string name { set; get; }
            public void Hello() => Console.WriteLine(name);
        }
        static void PrintInfo(dynamic obj)
        {
            /* Ví dụ với đối tượng obj khi ta truy cập vào thuộc tính Name thì chương trình khi biên dịch không báo lỗi
            Nếu khi chạy chương trình mà báo lỗi thì chỉ có lỗi trong lúc thực thi
            
            không cần biết đối tượng obj có những thuộc tính nào, vẫn có thể khai báo trước các thuộc tính đó mà không bị báo lỗi
            */
            obj.name = "AbcXyz";
            obj.Hello();
        }

        public static void Main(string[] args)
        {
            var tenbien2 = 123;
            // khi khai báo kiểu dữ liệu ngầm định ta phải gán giá trị ngay lập tức để chương trình biết được kiểu dữ liệu
            dynamic tenbien1; // với dynamic thì không nhất thiết phải gán luôn giá trị
                              // khi nào chạy thì mới biên dịch
                              // biến kiểu dynamic cũng có thể được gán bằng mọi kiểu dữ liệu như var và có thể truy cập được các thuộc tính kể cả khi thuộc tính chưa được khai báo  

            // int abc = 1;
            // PrintInfo(abc);
            // // khi biên dịch chương trình này sẽ không báo lỗi nhưng khi chạy thì có
            Student abc = new Student();
            PrintInfo(abc);
        }
    }
}