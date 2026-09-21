namespace Bai1_CafeStatusDemo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Để màu nền Form hiển thị xuyên suốt
        lblWelcome.BackColor = Color.Transparent;

        // Cập nhật trạng thái và thời gian ngay khi mở ứng dụng
        CapNhatThoiGianVaTrangThai();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        CapNhatThoiGianVaTrangThai();
    }

    private void CapNhatThoiGianVaTrangThai()
    {
        DateTime now = DateTime.Now;

        // Cập nhật đồng hồ thời gian thực HH:mm:ss ở góc trái StatusStrip
        lblGioHienTai.Text = now.ToString("HH:mm:ss");

        // Giờ hoạt động của quán: từ 6h00 sáng đến trước 22h00 tối
        if (now.Hour >= 6 && now.Hour < 22)
        {
            lblTrangThai.Text = "Đang mở cửa";
            lblTrangThai.ForeColor = Color.Green;
        }
        else
        {
            lblTrangThai.Text = "Đã đóng cửa";
            lblTrangThai.ForeColor = Color.Red;
        }
    }

    private void menuDoiMauNen_Click(object sender, EventArgs e)
    {
        using (ColorDialog colorDialog = new ColorDialog())
        {
            colorDialog.Color = this.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }
    }

    private void menuThoat_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}

