using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace QLInternet
{
    public partial class FrmChuyen : Form
    {
        string TaiKhoan;
        CNapTien nt;
        public DialogResult res { get; set; }
        public FrmChuyen(string taiKhoan)
        {
            InitializeComponent();
            TaiKhoan = taiKhoan;
            nt = new CNapTien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            if (txtTaiKhoanNhan.Text == "")
                MessageBox.Show("Vui lòng nhập tài khoản nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtTaiKhoan.Text == txtTaiKhoanNhan.Text)
                MessageBox.Show("Tài khoản nhận không được trùng với tài khoản chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!int.TryParse(cbbTien.Text, out soTien))
                MessageBox.Show("Số tiền phải là số", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (soTien % 1000 != 0)
                MessageBox.Show("Số tiền phải chia hết cho 1000", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (nt.TruTien(txtTaiKhoan.Text, soTien, txtTaiKhoanNhan.Text))
            {
                res = MessageBox.Show("Chuyển thành công");
                this.Close();
            }
            else
                MessageBox.Show("Không đủ tiền", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FrmChuyen_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = TaiKhoan;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
