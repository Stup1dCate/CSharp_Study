using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        private Dictionary<int, Button> seatButtons;
        private HashSet<int> selectedSeats;
        private HashSet<int> soldSeats;
        private Dictionary<int, int> seatPrices;

        // Giá vé theo lô
        private const int PRICE_A = 10000;
        private const int PRICE_B = 15000;
        private const int PRICE_C = 20000;

        public Form1()
        {
            InitializeComponent();
            InitializeSeats();
        }

        private void InitializeSeats()
        {
            seatButtons = new Dictionary<int, Button>
            {
                {1, btn1}, {2, btn2}, {3, btn3}, {4, btn4}, {5, btn5},
                {6, btn6}, {7, btn7}, {8, btn8}, {9, btn9}, {10, btn10},
                {11, btn11}, {12, btn12}, {13, btn13}, {14, btn14}, {15, btn15}
            };

            selectedSeats = new HashSet<int>();
            soldSeats = new HashSet<int>();

            // Khởi tạo giá vé cho từng ghế
            seatPrices = new Dictionary<int, int>
            {
                // Lô A: ghế 1-5
                {1, PRICE_A}, {2, PRICE_A}, {3, PRICE_A}, {4, PRICE_A}, {5, PRICE_A},
                // Lô B: ghế 6-10
                {6, PRICE_B}, {7, PRICE_B}, {8, PRICE_B}, {9, PRICE_B}, {10, PRICE_B},
                // Lô C: ghế 11-15
                {11, PRICE_C}, {12, PRICE_C}, {13, PRICE_C}, {14, PRICE_C}, {15, PRICE_C}
            };

            // Đặt text cho các button và gán sự kiện click
            foreach (var seat in seatButtons)
            {
                seat.Value.Text = seat.Key.ToString();
                seat.Value.BackColor = Color.White; // Màu trắng cho ghế chưa bán
                seat.Value.Click += SeatButton_Click;
            }

            // Khởi tạo textbox thành tiền
            txtThanhTien.Text = "0";
            txtThanhTien.ReadOnly = true;

            // Gán sự kiện cho các button chức năng
            btnChon.Click += btnChon_Click;
            btnHuyBo.Click += btnHuyBo_Click;
            btnKetThuc.Click += btnKetThuc_Click;
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int seatNumber = int.Parse(clickedButton.Text);

            // Kiểm tra nếu ghế đã bán
            if (soldSeats.Contains(seatNumber))
            {
                MessageBox.Show($"Ghế số {seatNumber} đã được bán!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xử lý chọn/bỏ chọn ghế
            if (selectedSeats.Contains(seatNumber))
            {
                // Bỏ chọn ghế - đổi về màu trắng
                selectedSeats.Remove(seatNumber);
                clickedButton.BackColor = Color.White;
            }
            else
            {
                // Chọn ghế - đổi sang màu xanh
                selectedSeats.Add(seatNumber);
                clickedButton.BackColor = Color.Blue;
            }

            // Cập nhật tổng tiền tạm tính
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            int total = 0;
            foreach (int seat in selectedSeats)
            {
                total += seatPrices[seat];
            }
            txtThanhTien.Text = total.ToString();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác nhận thanh toán
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn mua {selectedSeats.Count} vé?\nTổng tiền: {txtThanhTien.Text} VNĐ",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đánh dấu ghế đã bán và đổi màu vàng
                foreach (int seat in selectedSeats)
                {
                    soldSeats.Add(seat);
                    seatButtons[seat].BackColor = Color.Yellow;
                }

                // Hiển thị thông báo thành công
                MessageBox.Show($"Thanh toán thành công!\nSố vé: {selectedSeats.Count}\nTổng tiền: {txtThanhTien.Text} VNĐ",
                              "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa danh sách ghế đang chọn
                selectedSeats.Clear();
                txtThanhTien.Text = "0";
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Không có ghế nào đang được chọn!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Xác nhận hủy bỏ
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn hủy bỏ các ghế đang chọn?",
                "Xác nhận hủy bỏ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đổi màu ghế đang chọn về trắng
                foreach (int seat in selectedSeats)
                {
                    seatButtons[seat].BackColor = Color.White;
                }

                // Xóa danh sách ghế đang chọn
                selectedSeats.Clear();
                txtThanhTien.Text = "0";

                MessageBox.Show("Đã hủy bỏ các ghế đang chọn!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn kết thúc chương trình?",
                "Xác nhận kết thúc",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Phương thức tiện ích để hiển thị thông tin về các lô ghế
        private void ShowSeatInfo()
        {
            string info = "THÔNG TIN GIÁ VÉ:\n";
            info += $"Lô A (ghế 1-5): {PRICE_A:N0} VNĐ/vé\n";
            info += $"Lô B (ghế 6-10): {PRICE_B:N0} VNĐ/vé\n";
            info += $"Lô C (ghế 11-15): {PRICE_C:N0} VNĐ/vé\n\n";
            info += "CHÚ THÍCH MÀU SẮC:\n";
            info += "• Màu trắng: Ghế trống\n";
            info += "• Màu xanh: Ghế đang chọn\n";
            info += "• Màu vàng: Ghế đã bán";

            MessageBox.Show(info, "Thông tin rạp chiếu phim",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Sự kiện Load form để hiển thị thông tin
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowSeatInfo();
        }
    }
}