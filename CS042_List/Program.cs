using System;
using System.Collections.Generic;

namespace CS042_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // khai báo list: List<kiểu dữ liệu> tên_danh_sách = new List<kiểu dữ liệu>();
            List<int> numbers = new List<int>();
            // List<string> names = new List<string>();
            // List<double> scores = new List<double>();


            // Thêm phần tử
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.AddRange(new int[] { 40, 50, 60 }); // Thêm nhiều phần tử cùng lúc (thêm mảng phần tử)


            // Chèn phần tử (sử dụng phương thức Insert)
            numbers.Insert(1, 15);  // Chèn 15 vào vị trí chỉ số 1


            // Truy cập phần tử
            // cách 1: Dùng vòng lặp foreach
            Console.WriteLine("Danh sach phan tu trong List (su dung vong lap for):");
            Console.WriteLine("So luong phan tu: " + numbers.Count);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }
            // cách 2: Truy cập từ phần tử theo index
            Console.WriteLine("Phan tu o vi tri chi so 3: " + numbers[2]);
            Console.WriteLine("Phan tu o vi tri chi cuoi danh sach: " + numbers[numbers.Count-1]);
            // cách 3: Dùng vòng lặp foreach
            Console.WriteLine("Cac phan tu trong List (su dung vong lap foreach):");
            foreach (int num in numbers)
            {
                Console.WriteLine(num + " ");
            }

            // Xóa phần tử
            numbers.Remove(20);     // Xóa theo giá trị - 20
            numbers.RemoveAt(0);    // Xóa theo vị trí phần tử - chỉ số 0


            // Tìm kiếm phần tử
            int index = numbers.IndexOf(30); // Tìm vị trí phần tử có giá trị 30
            if (index != -1) // Nếu tìm thấy 
            Console.WriteLine("30 nam o vi tri phan tu thu " + index + ".");
            
            else Console.WriteLine("30 khong ton tai o trong danh sach.");
            


            // Xóa toàn bộ danh sách
            numbers.Clear();
            Console.WriteLine("Da xoa danh sach. So luong phan tu: " + numbers.Count); // xoá HẾT phần tử trong danh sách
            // Giải phóng tham chiếu đến danh sách (nếu không dùng nữa)
            numbers = null; // xoá hẳn danh sách
        }
    }
}