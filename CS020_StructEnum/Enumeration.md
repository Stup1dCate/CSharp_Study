# Kiểu dữ liệu liệt kê

Ví dụ:
```cs
        enum HOCLUC
        {
            KEM = 2,
            TRUNGBINH, //TRUNGBINH sẽ = 3 (trước + 1)
            KHA = 6, 
            GIOI = 8,
            XUATSAC = 10
        }
```
<p>
  Ví dụ trên khai báo kiểu dữ liệu thuộc nhóm enumeration.
  có tên là <b>HOCLUC</b> với các giá trị (hằng) tương ứng là KEM, TRUNGBINH, KHA, v.v..
</p>

Mặc định, giá trị của hằng trong enum sẽ thuộc kiểu <b>int<b>. Tuy nhiên bạn có thể thay đổi thành kiểu khác. <br>Ví dụ:
```cs
enum Color : byte
{
    Red = 1,
    Green = 2,
    Blue = 3
}
```
