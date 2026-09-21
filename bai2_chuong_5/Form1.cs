using System.Drawing.Drawing2D;
using System.Reflection;

namespace bai2_chuong_5
{
    public partial class Form1 : Form
    {
        private bool dangVe = false;                                   // đang giữ chuột trái?
        private readonly List<List<Point>> cacNet = new List<List<Point>>();  // mọi nét đã vẽ
        private List<Point> netHienTai = new List<Point>();            // nét đang vẽ

        public Form1()
        {
            InitializeComponent();

            // Bật double buffer cho Panel để nét vẽ không bị nhấp nháy
            typeof(Panel).GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic)!
                .SetValue(pnlCanvas, true);
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;   // chỉ vẽ bằng chuột trái

            dangVe = true;
            netHienTai = new List<Point> { e.Location };  // bắt đầu nét mới
            cacNet.Add(netHienTai);
            lblTrangThai.Text = "Đang vẽ...";
            pnlCanvas.Invalidate();
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Luôn cập nhật tọa độ, dù đang vẽ hay không
            lblViTri.Text = $"X: {e.X}, Y: {e.Y}";

            if (dangVe)
            {
                netHienTai.Add(e.Location);
                pnlCanvas.Invalidate();
            }
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            dangVe = false;
            lblTrangThai.Text = "Sẵn sàng";
        }

        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cacNet.Clear();
                pnlCanvas.Invalidate();   // vẽ lại: Panel trắng hoàn toàn
            }
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen buut = new Pen(Color.Black, 3))
            using (SolidBrush co = new SolidBrush(Color.Black))
            {
                buut.StartCap = LineCap.Round;
                buut.EndCap = LineCap.Round;
                buut.LineJoin = LineJoin.Round;

                foreach (List<Point> net in cacNet)
                {
                    if (net.Count == 1)
                    {
                        // Chỉ nhấn chuột không kéo: vẽ một chấm nhỏ
                        g.FillEllipse(co, net[0].X - 1.5f, net[0].Y - 1.5f, 3f, 3f);
                    }
                    else if (net.Count > 1)
                    {
                        g.DrawLines(buut, net.ToArray());   // nối các điểm liên tiếp
                    }
                }
            }
        }
    }
}