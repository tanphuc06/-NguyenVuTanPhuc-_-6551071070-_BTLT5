namespace chuong5bai1
{
    partial class FormBanHang
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMaSP = new TextBox();
            txtDonGia = new TextBox();
            txtSoLuong = new TextBox();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(397, 97);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(431, 39);
            txtMaSP.TabIndex = 0;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(397, 240);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(431, 39);
            txtDonGia.TabIndex = 1;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(397, 167);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(431, 39);
            txtSoLuong.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(315, 323);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(184, 44);
            btnThem.TabIndex = 3;
            btnThem.Text = " Thêm (F2)";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(615, 323);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(213, 44);
            btnXoaTrang.TabIndex = 4;
            btnXoaTrang.Text = "Xóa trắng (F5)";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(315, 396);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(513, 164);
            lstKetQua.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 104);
            label1.Name = "label1";
            label1.Size = new Size(181, 32);
            label1.TabIndex = 6;
            label1.Text = "Mã sản phẩm: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 247);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 7;
            label2.Text = "Đơn giá: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 174);
            label3.Name = "label3";
            label3.Size = new Size(131, 32);
            label3.TabIndex = 8;
            label3.Text = "Số lượng: ";
            // 
            // label4
            // 
            label4.BackColor = Color.Blue;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(1134, 77);
            label4.TabIndex = 9;
            label4.Text = "NHẬP LIỆU SIÊU THỊ MINI";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormBanHang
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 576);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(txtSoLuong);
            Controls.Add(txtDonGia);
            Controls.Add(txtMaSP);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            KeyPreview = true;
            Name = "FormBanHang";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSP;
        private TextBox txtDonGia;
        private TextBox txtSoLuong;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
