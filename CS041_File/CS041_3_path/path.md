# Các phương thức thường dùng trong `System.IO.Path`
## 1. Path.DirectorySeparatorChar
Thuộc tính chứa ký tự phân cách đường dẫn thư mục (\ trên Windows, / trên *nix).

## 2. Path.PathSeparator
Thuộc tính chứa ký tự phân chia thư mục trong biến môi trường.

## 3. Combine
Kết hợp các chuỗi thành đường dẫn.
```csharp
var path = Path.Combine("home", "ReadMe.txt"); // "home/ReadMe.txt"
---

## 4. ChangeExtension
Thay đổi phần mở rộng của đường dẫn.
```csharp
var path = Path.ChangeExtension("/home/abc/ReadMe.txt", "md"); // "/home/abc/ReadMe.md"


## 5. GetDirectoryName
Lấy đường dẫn đến file (thư mục).
```csharp
var path = Path.GetDirectoryName("/home/abc/zyz/ReadMe.txt"); // "/home/abc/zyz"


## 6. GetExtension
Lấy phần mở rộng.
```csharp
var path = Path.GetExtension("/home/ReadMe.txt"); // ".txt"


## 7. GetFileName
Lấy tên file.
```csharp
var path = Path.GetFileName("/home/abc/ReadMe.txt"); // "ReadMe.txt"


## 8. GetFileNameWithoutExtension
Lấy tên file (không gồm phần mở rộng).
```csharp
var path = Path.GetFileNameWithoutExtension("/home/ReadMe.txt"); // "ReadMe"


## 9. GetFullPath
Lấy đường dẫn đầy đủ (từ đường dẫn tương đối).
```csharp
var path = Path.GetFullPath("ReadMe.txt");


## 10. GetPathRoot
Lấy gốc của đường dẫn.

## 11. GetRandomFileName
Tạo tên file ngẫu nhiên.
```csharp
var path = Path.GetRandomFileName();


## 12. GetTempFileName
Tạo file duy nhất, rỗng.
```csharp
var path = Path.GetTempFileName();
