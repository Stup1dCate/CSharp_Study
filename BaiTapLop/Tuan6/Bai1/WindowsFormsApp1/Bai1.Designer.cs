namespace WindowsFormsApp1
{
    partial class Bai1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.lblSoA = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtUCLN = new System.Windows.Forms.TextBox();
            this.txtBCNN = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(103, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "BCNN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(103, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "UCLN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoB
            // 
            this.lblSoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoB.AutoSize = true;
            this.lblSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoB.Location = new System.Drawing.Point(103, 161);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(59, 25);
            this.lblSoB.TabIndex = 1;
            this.lblSoB.Text = "Số B";
            this.lblSoB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSoA
            // 
            this.lblSoA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoA.AutoSize = true;
            this.lblSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoA.Location = new System.Drawing.Point(103, 100);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(60, 25);
            this.lblSoA.TabIndex = 0;
            this.lblSoA.Text = "Số A";
            this.lblSoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSoA
            // 
            this.txtSoA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoA.Location = new System.Drawing.Point(212, 103);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(430, 30);
            this.txtSoA.TabIndex = 4;
            this.txtSoA.TextChanged += new System.EventHandler(this.txtSoA_TextChanged);
            // 
            // txtSoB
            // 
            this.txtSoB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSoB.Location = new System.Drawing.Point(212, 164);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(430, 30);
            this.txtSoB.TabIndex = 5;
            this.txtSoB.TextChanged += new System.EventHandler(this.txtSoB_TextChanged);
            // 
            // txtUCLN
            // 
            this.txtUCLN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUCLN.BackColor = System.Drawing.Color.White;
            this.txtUCLN.Enabled = false;
            this.txtUCLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUCLN.Location = new System.Drawing.Point(212, 223);
            this.txtUCLN.Name = "txtUCLN";
            this.txtUCLN.ReadOnly = true;
            this.txtUCLN.Size = new System.Drawing.Size(430, 30);
            this.txtUCLN.TabIndex = 6;
            this.txtUCLN.TextChanged += new System.EventHandler(this.txtUCLN_TextChanged);
            // 
            // txtBCNN
            // 
            this.txtBCNN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBCNN.BackColor = System.Drawing.Color.White;
            this.txtBCNN.Enabled = false;
            this.txtBCNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBCNN.Location = new System.Drawing.Point(212, 284);
            this.txtBCNN.Name = "txtBCNN";
            this.txtBCNN.ReadOnly = true;
            this.txtBCNN.Size = new System.Drawing.Size(430, 30);
            this.txtBCNN.TabIndex = 7;
            this.txtBCNN.TextChanged += new System.EventHandler(this.txtBCNN_TextChanged);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThucHien.Location = new System.Drawing.Point(108, 365);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(114, 40);
            this.btnThucHien.TabIndex = 8;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTiepTuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTiepTuc.Location = new System.Drawing.Point(326, 365);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(114, 40);
            this.btnTiepTuc.TabIndex = 9;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThoat.Location = new System.Drawing.Point(528, 365);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 40);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.Color.Red;
            this.labelTieuDe.Location = new System.Drawing.Point(243, 28);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(364, 29);
            this.labelTieuDe.TabIndex = 11;
            this.labelTieuDe.Text = "Ước số chung - Bội số chung";
            this.labelTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTieuDe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.txtBCNN);
            this.Controls.Add(this.txtUCLN);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.lblSoA);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtUCLN;
        private System.Windows.Forms.TextBox txtBCNN;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label labelTieuDe;
    }
}

