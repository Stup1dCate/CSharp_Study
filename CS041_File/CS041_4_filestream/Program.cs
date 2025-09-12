using System;
using System.IO;
using System.Text;

namespace CS041_4_filestream
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "data.dat";
            using var stream = new FileStream(path, FileMode.OpenOrCreate); // thêm "using" vào đầu để giải phóng bộ nhớ khi sử dụng xong

            // ghi dữ liệu
            byte[] buffer = { 1, 2, 3 };
            int offset = 0; // bắt đầu ghi từ phần tử số 0
            int count = buffer.Length; // in số byte = số lượng phần tử (mảng trên mỗi phần tử = 1 byte)
            stream.Write(buffer, offset, count);

            // đưa con trỏ về đầu file trước khi đọc
            stream.Seek(0, SeekOrigin.Begin);// nếu không có dòng này thì con trỏ ban đầu nằm ở cuối file => phải đưa lại về đầu để đọc

            // đọc dữ liệu
            byte[] readBuffer = new byte[count];
            int byte_count = stream.Read(readBuffer, offset, count); // đếm số byte đọc được
            Console.WriteLine($"So file doc duoc: {byte_count}");
            Console.WriteLine("Noi dung doc duoc: " + string.Join(", ", readBuffer));

            // chuyển đổi int --> bytes 
            int abc = 12345;
            var bytes_abc = BitConverter.GetBytes(abc);
            int abc_back = BitConverter.ToInt32(bytes_abc, 0);
            Console.WriteLine($"Int ban đầu: {abc}, sau khi convert: {abc_back}");

            // chuyển đổi string --> bytes
            string s = "Xyz";
            var bytes_s = Encoding.UTF8.GetBytes(s);
            string s_back = Encoding.UTF8.GetString(bytes_s, 0, bytes_s.Length);
            Console.WriteLine($"Chuoi ban dau: {s}, sau khi convert: {s_back}");
        }
    }
}
