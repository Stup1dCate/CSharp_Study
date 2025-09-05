using System;

namespace CS036_StaticContructor
{
    /* Phương thức tĩnh (static) và trường dữ liệu tĩnh trong lớp C
    + đã là thành viên tĩnh thì không thuộc về đối tượng của lớp mà nó có thể truy cập thông qua tên lớp
    + có thể tạo phương thức tĩnh và trường dữ liệu tĩnh trong một lớp
    */
    class CountNumber
    {
        public static int number = 0;
        public static void Info()
        {
            Console.WriteLine("So lan truy cap: "+number);
        }
        public void Count() // mỗi lần gọi phương thức này thì dữ liệu number tăng lên một
        {
            // number++;
            CountNumber.number++;
            // không thể truy cập = this.number;
        }
    }

    // thành viên dữ liệu chỉ đọc (readonly): chỉ được phép đọc giá trị, không được phép gán giá trị
    class Student
    {
        // khai báo có từ "readonly" trước kiểu dữ liệu
        // thông tin được khai báo trước cho đối tượng readonly (bắt buộc)
        public readonly string name;
        // trường dữ liệu readonly thì không được phép gán giá trị trực tiếp như thế này: public readonly string name = "Nguyen Van A"; 

        // được gán trong phương thức khởi tạo
        public Student(string _name)
        {
            this.name = _name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // CountNumber.Info();
            // // truy cập vào dữ liệu tĩnh
            // Console.WriteLine(CountNumber.number);
            CountNumber c1 = new CountNumber();
            CountNumber c2 = new CountNumber();
            c1.Count();
            c2.Count();
            CountNumber.Info();


            // thành viên chỉ đọc (read only    )
            
            Student a = new Student("Vu Ngoc Tung");
            // a.name = "Vu Ngoc Tung"; => truy cập như này sẽ bị lỗi

            Console.WriteLine(a.name); // "a" ở đây phải được khai báo trước

        }
    }
}