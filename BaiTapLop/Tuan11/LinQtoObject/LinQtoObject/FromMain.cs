using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections;


namespace LinQtoObject
{
    public partial class FromMain : Form
    {
        public FromMain()
        {
            InitializeComponent();
        }


        private void LoadFrom(object sender, EventArgs e)
        {
            txtMangA.Text = "4,6,-3,0,56,4,36,12,-98,34";
            txtMangB.Text = "12,-4,67,23,99,66,36,18,0";
        }

        private int[] ChuyenDoi(TextBox txt)
        {
            try
            {
                return txt.Text.Split(',', (char)StringSplitOptions.RemoveEmptyEntries)
                               .Select(s => int.Parse(s.Trim()))
                               .ToArray();
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập các số hợp lệ, cách nhau bằng dấu phẩy.");
                return new int[0];
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] manga = ChuyenDoi(txtMangA);
            var result = from i in manga
                         where i > 4
                         select i;
            txtKetQua.Clear();
            foreach (var i in result)
            {
                txtKetQua.Text = txtKetQua.Text + i.ToString() + ",";
            }
           
        }

        private void btnGiatritangdan_Click(object sender, EventArgs e)
        {
            int[] manga = ChuyenDoi(txtMangA);
            var result = from i in manga
                         orderby i
                         select i;
            txtKetQua.Clear();
            foreach (var i in result)
            {
                txtKetQua.Text = txtKetQua.Text + i.ToString() + ",";
            }
        }

        private void btnGiatribe4nho8_Click(object sender, EventArgs e)
        {
            int[] manga = ChuyenDoi(txtMangA);
          
            var result = from i in manga
                         where i > 4 && i < 8
                         select i;
            txtKetQua.Clear();
            txtKetQua.Clear();
            foreach (var i in result)
            {
                txtKetQua.Text = txtKetQua.Text + i.ToString() + ",";
            }
        }

        private void btnGiatricotrongA_Click(object sender, EventArgs e)
        {
            int[] a = ChuyenDoi(txtMangA);
            int[] b = ChuyenDoi(txtMangB);
           
            var result = from i in a
                         from j in b
                         where i == j
                         select i;
            txtKetQua.Clear();
            foreach (var i in result)
            {
                txtKetQua.Text = txtKetQua.Text + i.ToString() + ",";
            }
        }

        private void btnManglonhon4_Click(object sender, EventArgs e)
        {
            int[] a = ChuyenDoi(txtMangA);
            var result = a.Where(x => x > 4);
            txtKetQua.Clear();
            foreach (var i in result)
            {
                txtKetQua.Text = txtKetQua.Text + i.ToString() + ",";
            }
        }

        private void btnChuoichuae_Click(object sender, EventArgs e)
        {
           
            ArrayList chuoi = new ArrayList()
    {
        "zero", "one", "two", "four", "five",
        "six", "seven", "eight", "nine", "ten"
    };

            
            txtMangB.Text = string.Join(", ", chuoi.Cast<string>());

            
            var result = chuoi.Cast<string>()
                              .Where(s => s.Contains("e"));

            
            txtKetQua.Text = string.Join(", ", result);
        }


        private void btnTimsvcomatrongdanhsach_Click(object sender, EventArgs e)
        {
            ArrayList listSv = new ArrayList();

            listSv.Add(new SinhVienDTO("sv01", "nguyen minh thuan", "099999555", "thuan@gmail.com", "binh chanh"));
            listSv.Add(new SinhVienDTO("sv02", "le van hoang", "091234567", "hoang@gmail.com", "quan 1"));
            listSv.Add(new SinhVienDTO("sv03", "tran thi my linh", "098765432", "mylinh@gmail.com", "tan binh"));
            listSv.Add(new SinhVienDTO("sv04", "pham van loc", "093333444", "locpham@gmail.com", "go vap"));
            listSv.Add(new SinhVienDTO("sv05", "nguyen hoai nam", "097777888", "hoainam@gmail.com", "thu duc"));
            listSv.Add(new SinhVienDTO("sv06", "doan quoc bao", "095555666", "quocbao@gmail.com", "binh thanh"));

            string maCantim = txtMangB.Text.Trim();

            
            var result = listSv.Cast<SinhVienDTO>()
                               .Where(sv => sv.Masv == maCantim)
                               .Select(sv => $"{sv.Masv} - {sv.TenSv} - {sv.Sdt} - {sv.Email} - {sv.DiaChi}");

            
            if (!result.Any())
            {
                txtKetQua.Text = "Không tìm thấy sinh viên!";
                return;
            }

            txtKetQua.Text = string.Join("\r\n", result);
        }

    }
}
