using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DieuKhien;
using System.Data.SqlClient;

namespace FQLMay
{
    
    public partial class Form1 : Form
    {
        private CCheckMay check;
        private CAddMay add;
        private GetThongTIn get;
        private CUpdateMay update;
        private CDeleteMay delete;
        private CFindMay findmayy;
        public Form1()
        {
            check = new CCheckMay();
            add = new CAddMay();
            get = new GetThongTIn();
            update = new CUpdateMay();
            delete = new CDeleteMay();
            findmayy = new CFindMay();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Vui lòng nhập mã máy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (textBox2.Text == "")
                MessageBox.Show("Vui lòng nhập tên máy", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (add.AddMay(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Thêm máy thành công");
                textBox1.Focus();
                dataGridView1.DataSource = get.gettt();
            }
            else
                MessageBox.Show("Thêm máy thất bại");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = false;
            dataGridView1.Columns.Add("IDMay", "ID Máy");
            dataGridView1.Columns[0].DataPropertyName = "IDMay";
            dataGridView1.Columns.Add("TenMay", "Tên Máy");
            dataGridView1.Columns[1].DataPropertyName = "TenMay";
            dataGridView1.Columns.Add("TrangThai", "Trạng Thái");
            dataGridView1.Columns[2].DataPropertyName = "TrangThai";
            dataGridView1.Columns.Add("SoTG", "Số Thời Gian");
            dataGridView1.Columns[3].DataPropertyName = "SoTG";
            dataGridView1.Columns.Add("PhuongThucDung", "Phương Thức Dùng");
            dataGridView1.Columns[4].DataPropertyName = "PhuongThucDung";
            dataGridView1.Columns.Add("SoTien", "Số Tiền");
            dataGridView1.Columns[5].DataPropertyName = "SoTien";
            dataGridView1.Columns.Add("TimeStart", "TimeStart");
            dataGridView1.Columns[6].DataPropertyName = "TimeStart";

            dataGridView1.DataSource = get.gettt();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == dataGridView1.CurrentRow.Cells[0].Value.ToString())
            {
                if (update.UpdateMay(textBox1.Text, textBox2.Text))
                {
                    MessageBox.Show("Bạn đã sửa thông tin máy thành công");
                    dataGridView1.DataSource = get.gettt();
                }
                else
                    MessageBox.Show("Bạn sửa thông tin máy thất bại");
            }
            else
                MessageBox.Show("Bạn không thể sửa ID Máy");
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if(delete.DeleteMay(textBox1.Text))
            {
                dataGridView1.DataSource = get.gettt();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = findmayy.FindMay(textBox3.Text);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = get.gettt();
        }
    }
}
