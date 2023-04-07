using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTK;
using FQLMay;
using TaoHoaDon;
using QLy_Dai_Ly2;
using Thong_ke_2_;

namespace QLInternet
{
    public partial class FrmMain : Form
    {
        Form currentFormChild;
        Color[] colors = new Color[] { Color.Red, Color.Blue, Color.Yellow, Color.Green };
        int colorIndex = 0;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Lap_Phieu_Nhap());
            lblTB.Text = "Bạn đang ở Thống kê";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormXemTTPC());
            lblTB.Text = "Bạn đang ở Xem Trạng Thái Máy Tính";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
            lblTB.Text = "Chào mừng bạn đến với phần mềm Quản Lý Quán Internet của FourT";
            OpenChildForm(new FrmBackground());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lblTB.Text = "Chào mừng bạn đến với phần mềm Quản Lý Quán Internet của FourT";
            timer1.Enabled = true;
            OpenChildForm(new FrmBackground());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmNapTien());
            lblTB.Text = "Bạn đang ở Nạp Tiền";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTB.ForeColor = colors[colorIndex];
            colorIndex = (colorIndex + 1) % colors.Length;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLTKK());
            lblTB.Text = "Bạn đang ở Quản lý Tài Khoản";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FQLMay.Form1());
            lblTB.Text = "Bạn đang ở Quản Lý Máy";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TaoHoaDon.Form1());
            lblTB.Text = "Bạn đang ở Quản Dịch Vụ";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DaiLyForm());
            lblTB.Text = "Bạn đang ở Quản Lý Đại Lý";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát chứ ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void htro_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ấn OK sẽ chuyển tới link facebook người hỗ trợ!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
                System.Diagnostics.Process.Start(@"https://www.facebook.com/thi.17.8");
        }

    }
}
