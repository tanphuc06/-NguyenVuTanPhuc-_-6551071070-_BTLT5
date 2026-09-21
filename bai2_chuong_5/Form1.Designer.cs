namespace bai2_chuong_5
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            pnlCanvas = new Panel();
            lblViTri = new Label();
            lblTrangThai = new Label();
            SuspendLayout();
            // 
            // pnlCanvas
            // 
            pnlCanvas.BackColor = Color.White;
            pnlCanvas.BorderStyle = BorderStyle.FixedSingle;
            pnlCanvas.Location = new Point(20, 55);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(760, 375);
            pnlCanvas.TabIndex = 0;
            pnlCanvas.Paint += pnlCanvas_Paint;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
            pnlCanvas.MouseDown += pnlCanvas_MouseDown;
            pnlCanvas.MouseMove += pnlCanvas_MouseMove;
            pnlCanvas.MouseUp += pnlCanvas_MouseUp;
            // 
            // lblViTri
            // 
            lblViTri.AutoSize = true;
            lblViTri.Location = new Point(20, 15);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(88, 23);
            lblViTri.TabIndex = 1;
            lblViTri.Text = "X: 0, Y: 0";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(660, 15);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(83, 23);
            lblTrangThai.TabIndex = 2;
            lblTrangThai.Text = "Sẵn sàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTrangThai);
            Controls.Add(lblViTri);
            Controls.Add(pnlCanvas);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng vẽ mini";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCanvas;
        private Label lblViTri;
        private Label lblTrangThai;
    }
}