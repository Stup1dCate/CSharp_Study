## Các giao diện – interface về collection thường dùng

1. IEnumerable<T>	
-> Triển khai nó nếu muốn duyệt phần tử bằng foreach, nó định nghĩa phương thức GetEnumerator trả về một enumerator.
2. ICollection<T>	
-> Giao diện này được triển khai bởi các generic collection. Với nó lấy tổng phần tử bằng thuộc tính Count, 
copy các phần tử vào mảng bằng CopyTo, thêm bớt phần tử với Add, Remove, Clear.
3. IList<T>	
-> Giao diện này kế thừa ICollection<T> (2) là một danh sách các phần tử truy cập được theo vị trí của nó. Nó có indexer, 
phương thức để chèn phần tử xóa phần tử Insert, RemoveAt.
4. ISet<T>	
-> Giao diện triển khai bởi các tập hợp.
5. IDictionary<TKey, TValue>	
-> Giao diện để triển khai loại dữ liệu lưu trữ theo cặp key, value.
6. ILookup<TKey, TValue>	
-> Giao diện để triển khai loại dữ liệu lưu trữ theo cặp key, value. Nhưng cho phép một key có nhiều giá trị.
7. IComparer<TKey, TValue>	
-> Giao diện để triển khai cho phép so sánh để sắp xếp Collection.
8. IEqualityComparer<TKey, TValue>	
-> Giao diện để triển khai cho phép so sánh bằng.