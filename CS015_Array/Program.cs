// Doi' voi' string
string sinhVien1 = "Nguyen van A";
string sinhVien2 = "Tran van B";
string sinhVien3 = "Bui thi C";

Console.WriteLine(sinhVien1);
Console.WriteLine(sinhVien2);
Console.WriteLine(sinhVien3);

// Mảng (array) chứa các phần tử là string
string[] ds;
ds = new string[3];

ds[0] = "Nguyen van A";
ds[1] = "Tran van B";
ds[2] = "Bui Thi C";


Console.WriteLine(ds[0]);
Console.WriteLine(ds[1]);
Console.WriteLine(ds[2]);


for (int i = 0; i <= 2; i++)
{
    Console.WriteLine(ds[i]);
}


// Cách khai báo:
int[] mangSoNguyen;
string[] string1 = new string[2] {"Dien Thoai", "May tinh"}; // nếu khai báo luôn phần tử thì phải khai báo rõ ràng
double[] number = { 0.1, 20, 0.36 , 10, 22.5};

mangSoNguyen = new int[3]; // một mảng có kiểu dữ liệu số nguyên với 3 phần tử
// gán phần tử:
mangSoNguyen[0] = 1;
mangSoNguyen[1] = 2;
mangSoNguyen[2] = 0;
// nếu khai báo thêm phần tử vượt quá giới hạn -> lỗi: mangSoNguyen[3] = n;

// Duyet mang:
int soPhanTu = number.Length;
// 1
for (int i = 0; i < soPhanTu; i++)
{
    Console.WriteLine(number[i]);
}
// 2
for (int i = soPhanTu-1; i >= 0; i--)
{
    Console.WriteLine(number[i]);
}
// 3
foreach (var i in number)
{
    Console.WriteLine(i);
}
// Một số phương thức trên mảng một chiều (mảng số)


Console.WriteLine($"So luong phan tu: {number.Length}");
Console.WriteLine($"Chieu cua mang: {number.Rank}");
Console.WriteLine($"So luong phan tu: {number.Min()}");
Console.WriteLine($"So luong phan tu: {number.Max()}");
Console.WriteLine($"So luong phan tu: {number.Sum()}");

Array.Sort(number);
foreach (var i in number)
{
    Console.WriteLine(i);
}



// Mảng nhiều chiều (mảng 2 chiều <=> ma trận):
// Cấu trúc:
double[,] number2 = new double[2, 3] { { 2, 3, 4.5 }, { 1, 9.2, 8 } };

/*
hoặc gán từng phần tử:
number2 [0, 0] = 1 => phần tử đầu tiên (cột - hàng đầu tiên) bằng 1
number2 [0, 1] = 2 => ...
...
*/

// duyệt mảng 2 chiều
int row = 2, col = 3;
for (int i = 0; i < row; i++) {
    for (int j = 0; j < col; j++)
    {
        Console.Write(number2[i, j] + " ");
    }
    Console.WriteLine();
    // phải trình bày như này mới ra được cụ thể cột và dòng
}






