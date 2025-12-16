# 2024 - 2025 - HK1
### Bài l: 
![Đề bài](image.png) </br>
**Kết quả output:**
value10 </br>
**Giải thích:**
Trình biên dịch chọn Base.display() dựa trên kiểu khai báo (Base), không phải kiểu thực tế (Derrived).
Derrived.display() không ghi đè (override) mà chỉ che giấu (hide) phương thức cha.
Vì vậy gọi Base.display(), in value ban đầu = 10.

### Bài 2:
![Đề bài](image-1.png)
``` csharp
using System;

namespace Bai2
{
    class Program
    {
        // hàm tính giai thừa
        public static double GiaiThua(double num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
                return num * GiaiThua(num - 1);
        }
        
        // hàm tính tổng
        public static double Sum(double x, double n)
        {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(x, i) / GiaiThua(2 + i);
            }
            return sum;
        }
        
        static void Main(string[] args)
        {
            double x, n;
            double result = 0;
            
            // Nhập giá trị x
            Console.WriteLine("Nhap vao gia tri x:");
            x = Convert.ToDouble(Console.ReadLine());
            
            // Xử lý trường hợp đặc biệt khi x = 0
            if (x == 0)
            {
                result = 1 / GiaiThua(2);
                Console.WriteLine("Ket qua la: " + result);
                return;
            }
            
            // Nhập và kiểm tra giá trị n
            Console.WriteLine("Nhap vao gia tri n:");
            while (true)
            {
                n = Convert.ToDouble(Console.ReadLine());
                if (n > -2)
                    break;
                Console.WriteLine("Gia tri cua n phai > -2. Vui long nhap lai gia tri cua n:");
            }
            
            result = Sum(x, n);
            Console.WriteLine("Ket qua la: " + result);
        }
    }
}
```

### Bài 3:
#### Giả sử form cần làm gọi với tên biến là: Form1
**Giao diện:**
3.1
``` csharp
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyHangHoa
{
    public partial class Form1 : Form
    {
        private string connectionString = "connectionString"; // "connectionString -> chuỗi kết nối cho trước của đề bài"
        
        public Form1()
        {
            InitializeComponent();
        }

        // 3.2. Hàm load dữ liệu lên DataGridView khi load form
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            LoadDataToComboBox();
        }

        private void LoadDataToDataGridView()
        {
            string query = @"
                SELECT m.Mahang, m.Tenhang, l.Tenloai, m.Ngaysx, m.Soluong, m.Dongia, m.Ghichu
                FROM Mathang m
                INNER JOIN Loaihang l ON m.Maloai = l.Maloai
                ORDER BY m.Mahang";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                dataGridView1.DataSource = dt;
                
                // Đặt tên cột hiển thị
                dataGridView1.Columns["Mahang"].HeaderText = "Mã Hàng";
                dataGridView1.Columns["Tenhang"].HeaderText = "Tên Hàng";
                dataGridView1.Columns["Tenloai"].HeaderText = "Tên Loại";
                dataGridView1.Columns["Ngaysx"].HeaderText = "Ngày SX";
                dataGridView1.Columns["Soluong"].HeaderText = "Số Lượng";
                dataGridView1.Columns["Dongia"].HeaderText = "Đơn Giá";
                dataGridView1.Columns["Ghichu"].HeaderText = "Ghi Chú";
            }
        }

        // 3.3. Hàm load dữ liệu lên ComboBox Tên loại
        private void LoadDataToComboBox()
        {
            string query = "SELECT Maloai, Tenloai FROM Loaihang ORDER BY Tenloai";
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                cboTenLoai.Items.Clear();
                cboTenLoai.Items.Add("Tất cả"); // Thêm option "Tất cả"
                
                while (reader.Read())
                {
                    cboTenLoai.Items.Add(new ComboboxItem
                    {
                        Text = reader["Tenloai"].ToString(),
                        Value = reader["Maloai"].ToString()
                    });
                }
                reader.Close();
                
                if (cboTenLoai.Items.Count > 0)
                    cboTenLoai.SelectedIndex = 0;
            }
        }

        // 3.4. Hàm cho nút Lọc
        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (cboTenLoai.SelectedItem == null)
                return;

            string query;
            SqlParameter param = null;

            if (cboTenLoai.SelectedItem.ToString() == "Tất cả")
            {
                query = @"
                    SELECT m.Mahang, m.Tenhang, l.Tenloai, m.Ngaysx, m.Soluong, m.Dongia, m.Ghichu
                    FROM Mathang m
                    INNER JOIN Loaihang l ON m.Maloai = l.Maloai
                    ORDER BY m.Mahang";
            }
            else
            {
                query = @"
                    SELECT m.Mahang, m.Tenhang, l.Tenloai, m.Ngaysx, m.Soluong, m.Dongia, m.Ghichu
                    FROM Mathang m
                    INNER JOIN Loaihang l ON m.Maloai = l.Maloai
                    WHERE m.Maloai = @Maloai
                    ORDER BY m.Mahang";
                
                param = new SqlParameter("@Maloai", ((ComboboxItem)cboTenLoai.SelectedItem).Value);
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (param != null)
                    cmd.Parameters.Add(param);
                
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                dataGridView1.DataSource = dt;
            }
        }

        // 3.5. Hàm cho nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMahang.Text))
            {
                MessageBox.Show("Vui lòng chọn một mặt hàng để sửa!");
                return;
            }

            string query = @"
                UPDATE Mathang 
                SET Tenhang = @Tenhang, 
                    Maloai = @Maloai, 
                    Ngaysx = @Ngaysx, 
                    Soluong = @Soluong, 
                    Dongia = @Dongia, 
                    Ghichu = @Ghichu
                WHERE Mahang = @Mahang";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                
                cmd.Parameters.AddWithValue("@Mahang", txtMahang.Text);
                cmd.Parameters.AddWithValue("@Tenhang", txtTenhang.Text);
                cmd.Parameters.AddWithValue("@Maloai", GetMaLoaiFromComboBox());
                cmd.Parameters.AddWithValue("@Ngaysx", dtpNgaySX.Value);
                cmd.Parameters.AddWithValue("@Soluong", Convert.ToInt32(txtSoluong.Text));
                cmd.Parameters.AddWithValue("@Dongia", Convert.ToDecimal(txtDongia.Text));
                cmd.Parameters.AddWithValue("@Ghichu", txtGhichu.Text);

                conn.Open();
                int result = cmd.ExecuteNonQuery();
                
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadDataToDataGridView();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
        }

        // 3.6. Hàm cho nút Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            txtTenhang.Focus();
        }

        private void ClearTextBoxes()
        {
            txtMahang.Text = "";
            txtTenhang.Text = "";
            txtSoluong.Text = "";
            txtDongia.Text = "";
            txtGhichu.Text = "";
            dtpNgaySX.Value = DateTime.Now;
            cboTenLoai.SelectedIndex = 0;
        }

        // Hàm hỗ trợ lấy mã loại từ ComboBox
        private string GetMaLoaiFromComboBox()
        {
            if (cboTenLoai.SelectedItem is ComboboxItem item)
                return item.Value.ToString();
            return "";
        }

        // Sự kiện click trên DataGridView để hiển thị dữ liệu lên TextBox
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                
                txtMahang.Text = row.Cells["Mahang"].Value.ToString();
                txtTenhang.Text = row.Cells["Tenhang"].Value.ToString();
                txtSoluong.Text = row.Cells["Soluong"].Value.ToString();
                txtDongia.Text = row.Cells["Dongia"].Value.ToString();
                txtGhichu.Text = row.Cells["Ghichu"].Value.ToString();
                dtpNgaySX.Value = Convert.ToDateTime(row.Cells["Ngaysx"].Value);
                
                // Tìm và chọn đúng loại hàng trong ComboBox
                string tenloai = row.Cells["Tenloai"].Value.ToString();
                foreach (var item in cboTenLoai.Items)
                {
                    if (item is ComboboxItem cbi && cbi.Text == tenloai)
                    {
                        cboTenLoai.SelectedItem = cbi;
                        break;
                    }
                }
            }
        }
    }

    // Lớp hỗ trợ cho ComboBox
    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        
        public override string ToString()
        {
            return Text;
        }
    }
}
```


