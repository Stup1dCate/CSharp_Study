using System;
using System.IO;

namespace CS041_2_directory
{
    /*
        DIRECTORY:
    Exists(path)	        Kiểm tra xem thư mục có tồn tại (true) hay không (false).
    CreateDirectory(path)	Tạo thư mục, trả về đối tượng System.IO.DirectoryInfo chứa thông tin thư mục.
    Delete(path)	        Xóa thư mục.
    GetFiles(path)	        Lấy các file trong thư mục.
    GetDirectories(path)	Lấy các thư mục trong thư mục.
    Move(src, des)	        Di chuyển thư mục.
    */

    class Program
    {
        // Sử dụng hàm đệ quy để liệt kê hết tất cả các file và thư mục con của một thư mục:
        static void ListFileDirectory(string path)
        {
            String[] directories = System.IO.Directory.GetDirectories(path);
            String[] files = System.IO.Directory.GetFiles(path);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
                ListFileDirectory(directory); // Đệ quy
            }
        }
        static void Main(string[] args)
        {
            // kiểm tra sự tồn tại của thư mục:
            string path = "Xyz";
            Directory.CreateDirectory(path);    // nếu không khởi tạo thư mục từ trước hoặc không có lệnh khởi tạo thì thư mục "Xyz" không tồn tại để kiểm tra
            Directory.Delete(path);             // xoá đường dẫn nhập vào
            if (Directory.Exists(path)) Console.WriteLine($"{path} - ton tai");
            else Console.WriteLine($"{path} - khong ton tai");

            // lấy ra tất cả các file trong cùng 1 thư mục:
            string path_1 = "obj";
            var files = Directory.GetFiles(path_1);             // lấy ra tất cả các thư mục con trực tiếp trong thư mục obj
            var directories = Directory.GetDirectories(path_1);   // lấy ra tất cả các thư mục con là subdirector (thư mục chứa các thư mục con khác - nó là con của obj) trong thư mục obj

            Console.WriteLine("Cac thu muc con subdirector trong obj la:");
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
            /* nếu ở đây muốn liệt kê tiếp các file con trong thư mục Debug (obj\Debug\) thì có thể tạo một đối tượng chứa đường dẫn
            là string path_2 = "Debug" và chạy hàm đệ quy phía trên
            */

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Cac thu muc con truc tiep trong obj la:");
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }


            // Liệt kê hết tất cả các file và thư mục con của một thư mục:
            Console.WriteLine("\nTat ca cac file - thu muc con nam trong thu muc \"obj\" la:");
            ListFileDirectory(path_1);

            // ví dụ chỉ muốn duyệt mình các file con của Debug (nằm trong obj):
            string path_2 = @"obj\Debug"; 
            /*
            vì file Debug là thư mục con không cùng cấp với obj nên phải ghi là @"obj/Debug" 
            ghi "obj\Debug" => không có @ để xác định đường link -> sai
            ghi "Debug" hay @"Debug" => không chứa thư mục cha là "obj" -> sai
            */
            Console.WriteLine("\nTat ca cac file - thu muc con nam trong thu muc \"Debug\" la:");
            ListFileDirectory(path_2);

            

        }
    }
}