## File Steam - System.IO.Stream 
1. CanRead: Cho biết stream hỗ trợ việc đọc hay không

2. CanWrite: Cho biết stream hỗ trợ việc ghi hay không

3. CanSeek: Cho biết stream hỗ trợ dịch chuyển con trỏ hay không

4. CanTimeout: Cho biết stream có đặt được time out

5. Length: Cho biết kích thước (byte) của stream

6. Position: Đọc hoặc thiết lập vị trí đọc (thiết lập thì stream phải hỗ trợ Seek)

7. ReadTimeout: Đọc hoặc thiết lập giá trị (mili giây) dành cho tác vụ đọc stream trước khi time out phát sinh

8. WriteTimeout: Đọc hoặc thiết lập giá trị (mili giây) dành cho tác vụ ghi stream trước khi time out phát sinh

## Các FileMode khi khởi tạo đối tượng stream
1. FileMode.Append – Nối thêm vào cuối file đã có sẵn nội dung (chỉ ghi, không đọc; nếu file chưa có thì sẽ tạo mới).

2. FileMode.Create – Tạo file mới; nếu file đã tồn tại thì ghi đè lên nội dung cũ.

3. FileMode.CreateNew – Tạo file mới; nếu file đã tồn tại thì báo lỗi.

4. FileMode.Open – Mở file đã có; nếu file không tồn tại thì báo lỗi.

5. FileMode.OpenOrCreate – Mở file nếu tồn tại, ngược lại thì tạo file mới.

6. FileMode.Truncate – Mở file đã có và xóa toàn bộ nội dung, giữ nguyên file rỗng để ghi mới.


