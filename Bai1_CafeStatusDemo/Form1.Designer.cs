namespace Bai1_CafeStatusDemo;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem menuHeThong;
    private System.Windows.Forms.ToolStripMenuItem menuDoiMauNen;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem menuThoat;

    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblGioHienTai;
    private System.Windows.Forms.ToolStripStatusLabel lblTenQuan;
    private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Label lblWelcome;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();

        menuStrip1 = new System.Windows.Forms.MenuStrip();
        menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
        menuDoiMauNen = new System.Windows.Forms.ToolStripMenuItem();
        toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
        menuThoat = new System.Windows.Forms.ToolStripMenuItem();

        statusStrip1 = new System.Windows.Forms.StatusStrip();
        lblGioHienTai = new System.Windows.Forms.ToolStripStatusLabel();
        lblTenQuan = new System.Windows.Forms.ToolStripStatusLabel();
        lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();

        timer1 = new System.Windows.Forms.Timer(components);
        colorDialog1 = new System.Windows.Forms.ColorDialog();
        lblWelcome = new System.Windows.Forms.Label();

        menuStrip1.SuspendLayout();
        statusStrip1.SuspendLayout();
        SuspendLayout();

        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            menuHeThong
        });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(682, 28);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";

        // 
        // menuHeThong
        // 
        menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            menuDoiMauNen,
            toolStripSeparator1,
            menuThoat
        });
        menuHeThong.Name = "menuHeThong";
        menuHeThong.Size = new System.Drawing.Size(85, 24);
        menuHeThong.Text = "&Hệ thống";

        // 
        // menuDoiMauNen
        // 
        menuDoiMauNen.Name = "menuDoiMauNen";
        menuDoiMauNen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
        menuDoiMauNen.Size = new System.Drawing.Size(224, 26);
        menuDoiMauNen.Text = "Đổi &màu nền";
        menuDoiMauNen.Click += menuDoiMauNen_Click;

        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new System.Drawing.Size(221, 6);

        // 
        // menuThoat
        // 
        menuThoat.Name = "menuThoat";
        menuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
        menuThoat.Size = new System.Drawing.Size(224, 26);
        menuThoat.Text = "&Thoát";
        menuThoat.Click += menuThoat_Click;

        // 
        // statusStrip1
        // 
        statusStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lblGioHienTai,
            lblTenQuan,
            lblTrangThai
        });
        statusStrip1.Location = new System.Drawing.Point(0, 422);
        statusStrip1.Name = "statusStrip1";
        statusStrip1.Size = new System.Drawing.Size(682, 31);
        statusStrip1.TabIndex = 1;
        statusStrip1.Text = "statusStrip1";

        // 
        // lblGioHienTai
        // 
        lblGioHienTai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblGioHienTai.Name = "lblGioHienTai";
        lblGioHienTai.Size = new System.Drawing.Size(76, 25);
        lblGioHienTai.Text = "00:00:00";
        lblGioHienTai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

        // 
        // lblTenQuan
        // 
        lblTenQuan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblTenQuan.ForeColor = System.Drawing.Color.DarkBlue;
        lblTenQuan.Name = "lblTenQuan";
        lblTenQuan.Size = new System.Drawing.Size(465, 25);
        lblTenQuan.Spring = true;
        lblTenQuan.Text = "CAFE ÁNH DƯƠNG";
        lblTenQuan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // 
        // lblTrangThai
        // 
        lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblTrangThai.ForeColor = System.Drawing.Color.Green;
        lblTrangThai.Name = "lblTrangThai";
        lblTrangThai.Size = new System.Drawing.Size(126, 25);
        lblTrangThai.Text = "Đang mở cửa";
        lblTrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Interval = 1000;
        timer1.Tick += timer1_Tick;

        // 
        // lblWelcome
        // 
        lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
        lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        lblWelcome.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
        lblWelcome.Location = new System.Drawing.Point(0, 28);
        lblWelcome.Name = "lblWelcome";
        lblWelcome.Size = new System.Drawing.Size(682, 394);
        lblWelcome.TabIndex = 2;
        lblWelcome.Text = "CHÀO MỪNG BẠN ĐẾN VỚI\r\nQUÁN CAFE ÁNH DƯƠNG";
        lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(682, 453);
        Controls.Add(lblWelcome);
        Controls.Add(statusStrip1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        MinimumSize = new System.Drawing.Size(500, 300);
        Name = "Form1";
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Bài 1: Bảng trạng thái quán cà phê - CafeStatusDemo";
        Load += Form1_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        statusStrip1.ResumeLayout(false);
        statusStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}
