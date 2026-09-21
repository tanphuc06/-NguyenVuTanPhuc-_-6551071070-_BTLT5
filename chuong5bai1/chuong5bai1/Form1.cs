using System;
using System.Windows.Forms;

namespace chuong5bai1
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();

            // Bật thuộc tính bắt phím tắt cho toàn bộ Form
            this.KeyPreview = true;
        }

        // Xử lý phím tắt F2, F5 và Escape
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThem.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnXoaTrang.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Kích hoạt sự kiện FormClosing
                e.Handled = true;
            }
        }

        // Xử lý xác nhận trước khi đóng Form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy lệnh đóng form
            }
        }

        // Xử lý thêm dữ liệu vào ListBox
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaSP.Text) &&
                !string.IsNullOrWhiteSpace(txtSoLuong.Text) &&
                !string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                string ketQua = $"{txtMaSP.Text} | {txtSoLuong.Text} | {txtDonGia.Text}";
                lstKetQua.Items.Add(ketQua);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin sản phẩm!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Xử lý xóa trắng các ô nhập liệu
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus(); // Đưa con trỏ nhấp nháy về lại ô Mã SP
        }

        // Chặn ký tự chữ cái, chỉ cho phép nhập số và phím Backspace
        private void txtSoLuong_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}