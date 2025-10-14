using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private List<int> daySo = new List<int>();
        private ErrorProvider errorProvider = new ErrorProvider();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNhapSo.Text))
            {
                errorProvider.SetError(txtNhapSo, "Vui lòng nhập số!");
                return;
            }

            if (!int.TryParse(txtNhapSo.Text, out int so))
            {
                errorProvider.SetError(txtNhapSo, "Dữ liệu nhập không phải là số!");
                return;
            }
            daySo.Add(so);
            txtDayVuaNhap.Text = string.Join(" ", daySo);

            TinhToanTong();

            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        private void TinhToanTong()
        {
            int tongPhanTu = daySo.Sum();
            txtTongPhanTu.Text = tongPhanTu.ToString();

            // Tính tổng chẵn
            int tongChan = daySo.Where(x => x % 2 == 0).Sum();
            txtTongChan.Text = tongChan.ToString();

            // Tính tổng lẻ
            int tongLe = daySo.Where(x => x % 2 != 0).Sum();
            txtTongLe.Text = tongLe.ToString();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            // Xóa sạch các textBox và danh sách
            txtNhapSo.Clear();
            txtDayVuaNhap.Clear();
            txtTongPhanTu.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            daySo.Clear();
            errorProvider.Clear();

            txtNhapSo.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
    }
}