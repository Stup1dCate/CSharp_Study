using System;

namespace bai14_String
{
    class Program
    {
        static void Main(string[] args)
        {
            /* KHAI BÁO:
            string <tên biến> = "<xâu ký tự>"
            */
            // CÁC THAO TÁC CƠ BẢN:
            int year = 2025;
            string thongbao =
            $@"Xin chao {year,10}, 
            nam sau la nam {year + 1}";
            // {year, -10} => tạo khoảng cách 10 đơn vị phía trước yeả thành khoảng trắng (ngược lại -10 thì phía sau)
            // kí hiệu @ để ghi string trên nhiều dòng
            // kí hiệu $ để trèn kí hiệu bên ngoài vào string (year)
            Console.WriteLine(thongbao);


            // CÁC THAO TÁC KHÁC VỚI STRING:
            // 1. khai báo mặc định:
            string str1 = "Day la mot chuoi";
            Console.WriteLine("Chuoi vua nhap la: " + str1);


            // 2. khai báo nguyên văn:
            string str2 = @"D:\Day la mot chuoi"; // nếu không có "@" sẽ báo lỗi
            Console.WriteLine("Chuoi vua nhap la: " + str2);


            // 3. các kí hiệu đặc biệt phải thêm '\' ở phía trước để tránh lỗi:
            string str3 = "Day la mot chuoi: \t \n\"Day la chuoi do\"";
            Console.WriteLine(str3);


            // 4. chuyển đổi chuỗi:
            int num = 123;
            string str4 = num.ToString(); // cách 1
            string str5 = num + ""; // cách 2
            string str6 = Convert.ToString(num); // cách 3
            Console.WriteLine(str4); Console.WriteLine("Day la chuoi str4 co kieu du lieu: " + str4.GetType().ToString());
            Console.WriteLine(str5); Console.WriteLine("Day la chuoi str5 co kieu du lieu: " + str5.GetType().ToString());
            Console.WriteLine(str6); Console.WriteLine("Day la chuoi str6 co kieu du lieu: " + str6.GetType().ToString());


            // 5. tách chuỗi thành các kí tự lẻ và cho vào một mảng:
            string str7 = "Hello World";
            char[] str_list = str7.ToCharArray();
            Console.WriteLine(str_list);
            Console.WriteLine(str_list.GetType().ToString());


            // 6. length (trả về độ dài chuỗi bao gồm cả space):
            Console.WriteLine(str1.Length);
            Console.WriteLine("Ki tu thu 4 cua chuoi str1 la: " + str1[4]);


            // 7. So sánh 2 chuỗi: (tương tự với so sánh 2 char - lớn hơn trả về 1 và ngược lại. 0 khi bằng nhau)
            Console.WriteLine(str7.CompareTo(str1));


            // 8. kiểm tra tồn tại chuỗi con (true/false):
            bool check = str3.Contains(str1);
            Console.WriteLine(check);



            // 9. Hàm Copyto (sao chép chuỗi)
            char[] str_list_2 = new char[6]; // tạo một list có độ dài = 6
            // gán 2 giá trị đầu tiên lần lượt là 'a' và 'b'
            str_list_2[0] = 'a';
            str_list_2[1] = 'b';
            Console.WriteLine(str_list_2); // trả về "ab"
            str7.CopyTo(1, str_list_2, 2, 4);
            /*
            1 -> chuỗi str7 được copy vào str_list_2
            2 -> số 1: copy từ vị trí index 1 của chuỗi str7
            3 -> số 4: copy 4 kí tự (tính từ index 1 của chuỗi str7)
            4 -> số 2: copy đè vào vị trí index 2 của str_list_2
            */
            Console.WriteLine(str_list_2);


            // 10. Kiểm tra một chuỗi kết thúc bằng chuỗi gì 
            bool check_1 = str7.EndsWith("orld");
            Console.WriteLine(check_1); // true


            // 11. Gán chuỗi theo string.Format (output):
            int n = 16;
            string output = string.Format("n = {0} va can bac 2 cua n la {1}", n, Math.Sqrt(n));
            // 2 dòng dưới đây tương đương nhau về output
            Console.WriteLine(output);
            Console.WriteLine("n = {0} va can bac 2 cua n la {1}", n, Math.Sqrt(n));


            // 12. Hàm Equals (so sánh 2 chuỗi có giống nhau không)
            string str8 = "nigga";
            string str9 = "nigga";
            // bool check_equals = str8.Equals(str9) => ouput == check_equals; hoặc:
            Console.WriteLine(str8.Equals(str9));


            // 13. Chèn thêm chuỗi con vào chuỗi cha
            string str10 = "bruh";
            // str.Insert(n, str1) ==> n là vị trí cần chèn và str1 là chuỗi cần chèn vào chuỗi str
            str9 = str9.Insert(5, str10);
            Console.WriteLine(str9);


            // 14. IndexOf => trả về vị trí xuất hiện chuỗi nhập vào lần đầu tiên trong chuỗi cha
            string str11 = "aaabbbbccccc123";
            int first_A_str11 = str11.IndexOf('a');
            Console.WriteLine(first_A_str11);

            // 15. LastindexOf => ngược lại với IndexOf, trả về vị trí cuối cùng xuất hiện chuỗi con nhập vào
            int Last_A_str11 = str11.LastIndexOf('a');
            Console.WriteLine(Last_A_str11);


            // 16. Remove(index, count). Xoá phần tử ở vị trí index và xoá count phần tử từ ví trí đó trở đi
            str11 = str11.Remove(3, 2); // xoá phần tử ở vị trí index = 3 và xoá 2 phần tử 
            Console.WriteLine(str11);


            // 17. Replace(old_str, new_str)
            str11 = str11.Replace("cc", "dd");
            Console.WriteLine(str11);


            // 18. bool StartsWith
            bool check_str11 = str11.StartsWith("aa"); // true
            // hoặc có thể ghi tắt: Console.WriteLine(str11.StartsWith("aa"););
            Console.WriteLine(check_str11);


            // 19. Substring(i, n) => lấy từ vị trí i và lấy n kí tự
            string str11_sub = str11.Substring(4, 3);
            Console.WriteLine(str11_sub);


            // 20. ToLower() => chuyển đổi tất cả chuỗi thành kí tự thường
            string str12 = "I'm the NIGGEST man";
            Console.WriteLine(str12.ToLower()); // in trực tiếp mà không thay đổi trước thì sẽ không làm ảnh hưởng giá trị gốc của chuỗi ban đầu


            // 21. Trim() => xoá bỏ khoảng trắng đầu - cuối chuỗi
            string str13 = "         Day    la            khoang       trang     ";
            Console.WriteLine(str13.Trim());

            // 22. TrimEnd() => chỉ xoá khoảng trắng ở cuối chuỗi
            // 23. TrimStart() => chỉ xoá khoảng trắng ở đầu chuỗi


            // 24. str.Split => tách chuỗi trả về mảng
            string str14 = @"C:\User\Desktop\nam3_hk1\C#\bai14_String.cs";
            string[] str14_list = str14.Split('\\'); // vì "\" là kí tự đặc biệt nên phải viết 2 lần và phải nằm trong nháy kép
            Console.WriteLine(str14_list[0]);
            Console.WriteLine(str14_list[1]);
            Console.WriteLine(str14_list[2]);
            Console.WriteLine(str14_list[3]);
            Console.WriteLine(str14_list[4]);
            Console.WriteLine(str14_list[5]);


            // 25. string.Join(k, list): gần trái ngược với Split => nối các phần tử của một list thành 1 chuỗi (k là kí hiệu để nối, list là dsach các phần tử muốn nối)
            string str15 = string.Join("+", str14_list); // nối lại VD trên bằng dấu "+" thay "\" như ban đầu
            Console.WriteLine(str15);

        }
    }
}
