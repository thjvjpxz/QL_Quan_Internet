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
    public partial class FrmNap : Form
    {
        string TaiKhoan;
        CNapTien nt;
        public DialogResult result { get; set; }
        public FrmNap(string taiKhoan)
        {
            InitializeComponent();
            TaiKhoan = taiKhoan;
            nt = new CNapTien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tien = 0;
            if (cbbTien.Text == "")
                MessageBox.Show("Vui lòng nhập số tiền", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!int.TryParse(cbbTien.Text, out tien))
                MessageBox.Show("Số tiền phải là số", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (tien % 1000 != 0)
                MessageBox.Show("Số tiền phải chia hết cho 1000", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (nt.CongTien(txtTaiKhoan.Text, tien))
            {
                result = MessageBox.Show("Nạp thành công");
                this.Close();
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = TaiKhoan;
        }
    }
}
