using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller.NguyenKimThi;

namespace QLInternet.NguyenKimThi
{
    public partial class FormXemTTPC : Form
    {
        CGetInfoPC getinfo;
        CDongMay tt;

        public FormXemTTPC()
        {
            InitializeComponent();
            getinfo = new CGetInfoPC();
            tt = new CDongMay();
        }

        private void FormXemTTPC_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getinfo.xemTT();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn ?";
            string title = "Chú ý";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            DataGridViewRow row = dataGridView1.CurrentRow;
            int id = Convert.ToInt32(row.Cells[1].Value);
            if (result == DialogResult.OK && id == -1)
                MessageBox.Show("Máy đang ở trạng thái tắt", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Máy đã được khởi động lại");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int trangthai = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            string id = dataGridView1.CurrentRow.Cells[0].Value + "";
            if (trangthai == -1)
                MessageBox.Show("Máy đã ở trạng thái tắt, không thể tắt nữa!");
            else if (trangthai == 1)
                MessageBox.Show("Máy đang ở trạng thái có người sử dụng, không thể tắt");
            else
            {
                tt.DongMay(id);
                dataGridView1.DataSource = getinfo.xemTT();
                MessageBox.Show("Tắt thành công");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
