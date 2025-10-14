namespace Bai2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNhapSo = new System.Windows.Forms.Label();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtDayVuaNhap = new System.Windows.Forms.TextBox();
            this.lblDayVuaNhap = new System.Windows.Forms.Label();
            this.txtTongPhanTu = new System.Windows.Forms.TextBox();
            this.lblTongPhanTu = new System.Windows.Forms.Label();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.lblTongChan = new System.Windows.Forms.Label();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.lblTongLe = new System.Windows.Forms.Label();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            btnNhap.Click += btnNhap_Click;
            btnTiepTuc.Click += btnTiepTuc_Click;
            btnThoat.Click += btnThoat_Click;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Dãy Số và Tính Tổng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNhapSo
            // 
            this.lblNhapSo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNhapSo.AutoSize = true;
            this.lblNhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNhapSo.Location = new System.Drawing.Point(33, 91);
            this.lblNhapSo.Name = "lblNhapSo";
            this.lblNhapSo.Size = new System.Drawing.Size(81, 20);
            this.lblNhapSo.TabIndex = 1;
            this.lblNhapSo.Text = "Nhập số :";
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhapSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNhapSo.Location = new System.Drawing.Point(120, 85);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(236, 26);
            this.txtNhapSo.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNhap.Location = new System.Drawing.Point(385, 83);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 30);
            this.btnNhap.TabIndex = 3;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            // 
            // txtDayVuaNhap
            // 
            this.txtDayVuaNhap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDayVuaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDayVuaNhap.Location = new System.Drawing.Point(155, 140);
            this.txtDayVuaNhap.Name = "txtDayVuaNhap";
            this.txtDayVuaNhap.Size = new System.Drawing.Size(305, 26);
            this.txtDayVuaNhap.TabIndex = 5;
            // 
            // lblDayVuaNhap
            // 
            this.lblDayVuaNhap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDayVuaNhap.AutoSize = true;
            this.lblDayVuaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDayVuaNhap.Location = new System.Drawing.Point(33, 146);
            this.lblDayVuaNhap.Name = "lblDayVuaNhap";
            this.lblDayVuaNhap.Size = new System.Drawing.Size(116, 20);
            this.lblDayVuaNhap.TabIndex = 4;
            this.lblDayVuaNhap.Text = "Dãy vừa nhập:";
            // 
            // txtTongPhanTu
            // 
            this.txtTongPhanTu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTongPhanTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTongPhanTu.Location = new System.Drawing.Point(385, 199);
            this.txtTongPhanTu.Name = "txtTongPhanTu";
            this.txtTongPhanTu.Size = new System.Drawing.Size(75, 26);
            this.txtTongPhanTu.TabIndex = 7;
            // 
            // lblTongPhanTu
            // 
            this.lblTongPhanTu.AutoSize = true;
            this.lblTongPhanTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTongPhanTu.Location = new System.Drawing.Point(33, 205);
            this.lblTongPhanTu.Name = "lblTongPhanTu";
            this.lblTongPhanTu.Size = new System.Drawing.Size(212, 20);
            this.lblTongPhanTu.TabIndex = 6;
            this.lblTongPhanTu.Text = "Tổng các phần tử trong dãy";
            // 
            // txtTongChan
            // 
            this.txtTongChan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTongChan.Location = new System.Drawing.Point(141, 266);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(67, 26);
            this.txtTongChan.TabIndex = 9;
            // 
            // lblTongChan
            // 
            this.lblTongChan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTongChan.AutoSize = true;
            this.lblTongChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTongChan.Location = new System.Drawing.Point(33, 269);
            this.lblTongChan.Name = "lblTongChan";
            this.lblTongChan.Size = new System.Drawing.Size(102, 20);
            this.lblTongChan.TabIndex = 8;
            this.lblTongChan.Text = "Tổng chẵn : ";
            // 
            // txtTongLe
            // 
            this.txtTongLe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTongLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTongLe.Location = new System.Drawing.Point(393, 266);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.Size = new System.Drawing.Size(67, 26);
            this.txtTongLe.TabIndex = 11;
            // 
            // lblTongLe
            // 
            this.lblTongLe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTongLe.AutoSize = true;
            this.lblTongLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTongLe.Location = new System.Drawing.Point(308, 272);
            this.lblTongLe.Name = "lblTongLe";
            this.lblTongLe.Size = new System.Drawing.Size(79, 20);
            this.lblTongLe.TabIndex = 10;
            this.lblTongLe.Text = "Tổng lẻ : ";
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTiepTuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTiepTuc.Location = new System.Drawing.Point(87, 365);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(105, 30);
            this.btnTiepTuc.TabIndex = 12;
            this.btnTiepTuc.Text = "Tiếp Tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThoat.Location = new System.Drawing.Point(289, 365);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 30);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 427);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.txtTongLe);
            this.Controls.Add(this.lblTongLe);
            this.Controls.Add(this.txtTongChan);
            this.Controls.Add(this.lblTongChan);
            this.Controls.Add(this.txtTongPhanTu);
            this.Controls.Add(this.lblTongPhanTu);
            this.Controls.Add(this.txtDayVuaNhap);
            this.Controls.Add(this.lblDayVuaNhap);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtNhapSo);
            this.Controls.Add(this.lblNhapSo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNhapSo;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtDayVuaNhap;
        private System.Windows.Forms.Label lblDayVuaNhap;
        private System.Windows.Forms.TextBox txtTongPhanTu;
        private System.Windows.Forms.Label lblTongPhanTu;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.Label lblTongChan;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.Label lblTongLe;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.Button btnThoat;
    }
}

