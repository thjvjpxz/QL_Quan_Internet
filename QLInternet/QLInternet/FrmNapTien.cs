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
    public partial class FrmNapTien : Form
    {
        CTrangThai tt;
        CNapTien nt;

        public FrmNapTien()
        {
            InitializeComponent();
            tt = new CTrangThai();
            nt = new CNapTien();
        }

        private void FrmNapTien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = nt.XemTTNapTien();

            foreach (DataGridViewColumn col in dataGridView1.Columns)
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Font = new Font("Times New Roman", 16);
            dataGridView1.RowTemplate.Height = 50;

        }

        private void FrmNapTien_Shown(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            string taiKhoan = row.Cells[0].Value + "";
            if (taiKhoan == "")
                MessageBox.Show("Vui lòng chọn tài khoản muốn nạp tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                FrmNap frmNap = new FrmNap(taiKhoan);
                frmNap.ShowDialog();
                DialogResult res = frmNap.result;
                if (res == DialogResult.OK)
                    dataGridView1.DataSource = nt.XemTTNapTien();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            string taiKhoan = row.Cells[0].Value + "";
            if (taiKhoan == "")
                MessageBox.Show("Vui lòng chọn tài khoản chuyển", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                FrmChuyen frmChuyen = new FrmChuyen(taiKhoan);
                frmChuyen.ShowDialog();
                DialogResult res = frmChuyen.res;
                if (res == DialogResult.OK)
                   dataGridView1.DataSource = nt.XemTTNapTien();
            }
        }
    }
}
