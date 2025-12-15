# 2022 - 2023 - HK1
## Phần 1:
### Bài l: viết hàm kiểm tra năm nhuận
``` csharp
public static bool IsLeapYear(int year)
{
    return (year % 400 == 0) || (year % 4 == 0 && year % 100 !=0)
}
```
#### hoặc:
``` csharp
public static bool IsLeapYear(int year)
{
    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 !=0)) return true;
    else return false;
}
```

### Bài 2: viết phương thức đảo ngược chuõi
#### Trong C#, string là immutable (bất biến) -> không thể thay đổi nội dung của một string sau khi nó được tạo ra. Suy ra, đổi qua array
``` csharp
private static void ReverseString(string a)
{
    char[] charArray = a.ToCharArray();
    Array.Reverse(charArray);
    string a_reversed = new string(charArray);
}
```

### Bài 3:
``` csharp
namespace Name
{
    class Person
    {
        private string Name;

        public Person(string name)
        {
            this.Name = name;
        }
        
        private void ShowSecret()
        {
            Console.WriteLine("Your name: " + Name);
        }

        private static void DoSomething(String job)
        {
            Console.WriteLine("Do job: " + job);
        }
    }

    class Diary
    {
        public void Logging()
        {
            DoSomething("Code Csharp");
            ShowSecret();
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            Person a = new Person("Tom");
            String name = a.Name;
            a.ShowSecret();
            Person.DoSomething();
        }
    }
}
```
#### Kết quả của chương trình này là: Không biên dịch được (Compile erorr), tại vì các lỗi như sau:
+ "String name = a.Name;" và "a.ShowSecret();" lỗi các dòng này, private chỉ có thể truy cập được trong class Person
+ "DoSomething()" và "ShowSecret" là class của Person không thể truy cập từ Diary
+ Person.Dosomthing(); trong Main cần một tham số kiểu String (nếu các lỗi trên được ghi rõ access modifier thì đây là lỗi chính của bài)
#### Trong C#, nếu không ghi rõ access modifier (public/private), thì mặc định là private TRONG class

### Bài 4: Khởi tạo và sử dụng Delegate có kiểu int và tham số truyền vào có kiểu string cho mỗi phương thức ConvertStringToInt và ShowString 
``` csharp
using System;

public class Program
{
    // Khai báo kiểu dữ liệu delegate
    public delegate int StringProcessor(string stringValue);
    // kiểu trả về "int", kiểu truyền vào "string"

    static int ConvertStringToInt(string stringValue)   // trả về số tương ứng được ghi từ dạng string
    {
        return int.TryParse(stringValue, out int result) ? result : 0;
    }

    static int ShowString(string stringValue)           // hàm này phải trả về int nên dữ liệu được chọn là độ dài chuỗi
    {
        Console.WriteLine(stringValue);
        return stringValue.Length;
    }

    public static void Main()
    {
        // Khởi tạo delegate
        StringProcessor converter = ConvertStringToInt;
        StringProcessor shower = ShowString;
        
        // Sử dụng delegate
        int num = converter("123");
        int length = shower("Hello");
        
        Console.WriteLine($"Số: {num}, Độ dài: {length}");
    }
}
``` 

## Phần 2:
### Câu 1: 
Viết phương thức tính tiền lãi khi gửi tích kiệm tại ngân hàng
Chương trình cho phép người dùng nhập vào ba giá trị:
+ số tiền gửi có tên biến cho ô textbox: txttiengui
+ lãi suất năm (%) có tên biến cho ô textbox: txtlaixuat
+ Số năm gửi tiền tích kiệm có tên biến cho ô textbox: nudnam
+ Button Tính có tên biến: bttinh
+ Button Xoá có tên biến: btxoa
+ Richtextbox có tên biến: rtbketqua
Tiền lãi người gửi nhận được mỗi năm được tính theo công thức: Tiền lãi = tiền gửi * lãi suất / 100
Tiền lãi = số tiền gửi * lãi suất / 100
Tiền thu được gốc và lãi mỗi năm = số tiền gửi có được mỗi năm + tiền lãi
Tiền thu được gốc và lãi cho năm hiện tại được dùng làm số tiền gửi cho năm tiếp theo

Mô tả: </br>
    Số tiền gửi = 100 </br>
    Lãi suất năm = 10 </br>
    Năm = 2 </br>
Thì: </br>
    Tiền thu được gốc và lãi năm 1 = 100 + 100*10/100 = 110 </br>
    Tiền thu được gốc và lãi năm 2 = 110 + 110*10/100 = 121 </br>
    Kết quả số tiền gốc và lãi có thể có hoặc không có số thập phân: 110 = 110.0 = 110.00 </br>
    
![Giao diện](image.png)  
Yêu cầu: Chỉ cần viết phương thức xử lý cho sự kiện
+ Button Tính sẽ tính kết quả trả về bằng Richtextbox như hình trên
+ Button Xoá sẽ đưa về trạng thái như lúc ben đầu (tất cả các ô textbox đều rỗng)
+ Button Thoát sẽ thoát chương trình

#### Bài làm



