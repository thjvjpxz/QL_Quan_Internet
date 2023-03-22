using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ctrl_QLTK;

namespace QLTK
{
    public partial class QLTK : Form
    {
        private CXoa a;
        private CDoiMK doi;
        private CSearch tim;
        private CDoDL dodl;
        public QLTK()
        {
            InitializeComponent();
            a = new CXoa();
            doi = new CDoiMK();
            tim = new CSearch();
            dodl = new CDoDL();
        }
        public string get()
        {
            string user = "";
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow SelectedRow = dataGridView1.SelectedRows[0];
                user = SelectedRow.Cells["Tài khoản"].Value.ToString();
            }
            return user;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            FTaoTK tao = new FTaoTK();
            tao.ShowDialog();
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = dodl.DoDL1();
            dataGridView1.DataSource = dt;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string user = get();
            DataGridViewRow p = dataGridView1.SelectedRows[0];
            string k = p.Cells["Số phút"].Value.ToString();
            int l = int.Parse(k);
            if (l == 0)
            {
                a.xoatk(user);
                Form1_Load(sender, e);
                MessageBox.Show("Xóa tài khoản thành công!","Thông báo");
            }
            else
                MessageBox.Show("Số phút tài khoản phải bằng 0!","Thông báo");
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            string user = get();
            if (user != "")
            {
                FDoiMK doi = new FDoiMK(user);
                doi.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string tu = txtTuKhoa.Text;
            DataTable dt = tim.Search(tu);
            dataGridView1.DataSource = dt;
        }
    }
}
