1. static void ListFileDirectory(string path)
Hàm tĩnh, không trả về giá trị, nhận tham số path là đường dẫn đến thư mục muốn duyệt (có thể là đường dẫn tương đối hoặc tuyệt đối).

2. String[] directories = System.IO.Directory.GetDirectories(path);
Lấy tất cả thư mục con trực tiếp trong path.
Kết quả là mảng chuỗi, mỗi phần tử thường là đường dẫn đầy đủ tới thư mục con (ví dụ C:\Abc\Xyz).
Chú ý: GetDirectories chỉ lấy 1 cấp con (không đệ quy).

3. String[] files = System.IO.Directory.GetFiles(path);
Lấy tất cả file nằm trực tiếp trong path (không bao gồm file trong các thư mục con).
Mỗi phần tử là đường dẫn đầy đủ tới file.

4. foreach (var file in files) { 
	Console.WriteLine(file); 
}
In đường dẫn mỗi file ra console. Ở đây in trước khi duyệt thư mục con.

5. foreach (var directory in directories) { 
	Console.WriteLine(directory); 
	ListFileDirectory(directory); 
}
Với mỗi thư mục con: in đường dẫn thư mục con, rồi gọi đệ quy ListFileDirectory(directory) để xử lý thư mục con đó theo cùng cách (in file của nó, rồi lặp lại cho thư mục con của nó).
Kết quả: traversal theo kiểu depth-first (duyệt sâu), thứ tự: in files của thư mục hiện tại → for mỗi subdir: in tên subdir → duyệt nội dung subdir.
