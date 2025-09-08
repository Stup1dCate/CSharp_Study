#Mảng răng cưa

⌯⌲ Mỗi phần tử của nó lại là một mảng, thay vì là một dữ liệu cụ thể. (bắt buộc phải chung kiểu cơ sở)

Ta có thể hình dung như sau:

<p>
  – <b>Mảng hai chiều</b> bạn hãy hình dung nó như một ma trận. 
  Giả sử mảng 3×4, tức là có 3 hàng x 4 cột thì mỗi hàng đều phải có đủ 4 cột.

  – <b>Mảng răng cưa</b> thì khác. 
  Giả sử cũng có 3 hàng, nhưng hàng thứ nhất có thể có 5 cột, hàng thứ hai chỉ có 2 cột, hàng thứ 3 lại có 4 cột. 
  Rõ ràng nó “cộc lệch” chứ không tạo thành dạng ma trận.
  <img max-width="100%" src="https://github.com/user-attachments/assets/8930c861-ab28-4785-ba2e-3a2d7b5602c0" />
</p>


<b>Khai báo và khởi tạo: </b>
```cs
  data_type array_name[][] = new data_type[n][];     // n = số hàng

  array_name[0] = new data_type[n1]        //n1 = số cột ở hàng 1
  array_name[1] = new data_type[n2]       //n2 = số cột ở hàng 2
  array_name[2] = new data_type[n3]       //n3 = số cột ở hàng 3
```
<b>Gọn hơn: </b>

```cs
// Method 1
int arr_name[][] = new int[][]  { 
                                  new int[] {10, 20, 30 ,40},
                                   new int[] {50, 60, 70, 80, 90, 100},
                                   new int[] {110, 120}
                              }; 

                                       

// Method 2                                                                    
int[][] arr_name = { 
                                new int[] {10, 20, 30 ,40},
                                 new int[] {50, 60, 70, 80, 90, 100},
                                 new int[] {110, 120}
                             };     
                           

// Method 3                              
int[][] arr_name = {
                                  {10, 20, 30 ,40},
                                  {50, 60, 70, 80, 90, 100},
                                  {110, 120}
                              };
```

<b>Truy xuất: </b>
```cs
var value1 = numbers[0][0]; // truy xuất giá trị đầu tiên của mảng thành viên đầu tiên
var value2 = numbers[2][4]; // truy xuất giá trị thứ 4 của mảng thành viên số 2
```
