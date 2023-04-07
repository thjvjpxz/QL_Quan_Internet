using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLInternet
{
    public partial class FrmLoginStart : Form
    {
        // Đặt kích thước viền
        const int borderWidth = 1;

        // Vẽ viền lên form
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                Color.FromArgb(64, 64, 64), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(64, 64, 64), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(64, 64, 64), borderWidth, ButtonBorderStyle.Solid,
                Color.FromArgb(64, 64, 64), borderWidth, ButtonBorderStyle.Solid);
        }

        // Xử lý sự kiện di chuyển form
        private Point lastLocation;
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        public FrmLoginStart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "a")
            {
                MessageBox.Show("Đăng nhập thành công");
                FrmMain frm = new FrmMain();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
