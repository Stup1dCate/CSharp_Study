using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void txtSoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUCLN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBCNN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);

            // Hiển thị cả UCLN và BCNN
            txtUCLN.Text = UCLN(a, b).ToString();
            txtBCNN.Text = BCNN(a, b).ToString();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtSoA.Text = "";
            txtSoB.Text = "";
            txtUCLN.Text = "";
            txtBCNN.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }
    }
}
