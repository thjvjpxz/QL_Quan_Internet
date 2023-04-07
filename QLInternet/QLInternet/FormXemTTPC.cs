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
    public partial class FormXemTTPC : Form
    {
        CTrangThai tt;
        public FormXemTTPC()
        {
            InitializeComponent();

            tt = new CTrangThai();
        }

        private void FormXemTTPC_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = tt.GetInfoPC();

            // Căn giữa các cột
            foreach (DataGridViewColumn col in dataGridView1.Columns)
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dataGridView1.Font = new Font("Times New Roman", 16);
            dataGridView1.RowTemplate.Height = 50;
        }
        // Đóng máy
        private void button2_Click(object sender, EventArgs e)
        {
            //string id = dataGridView1.CurrentRow.Cells[0].Value + "";
            string trangThai = dataGridView1.CurrentRow.Cells[2].Value + "";
            string title = "Thông báo";
            string message = "Máy chưa được mở";
            if (trangThai == "Tắt" || trangThai == "Bật")
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                tmrClock.Enabled = false;
                double TongTien;
                string tg = dataGridView1.CurrentRow.Cells[3].Value + "";
                int h = Convert.ToInt32(tg.Substring(0, 2));
                int m = Convert.ToInt32(tg.Substring(3, 2));
                int s = Convert.ToInt32(tg.Substring(6, 2)) + (m * 60) + (h * 60 * 60);
                if (tt.DongMay(dataGridView1.CurrentRow.Cells[0].Value + "", s, out TongTien))
                {
                    FrmDongMay frmDong = new FrmDongMay((int)s / 60, TongTien);
                    frmDong.ShowDialog();
                    dataGridView1.DataSource = tt.GetInfoPC();
                }
                else
                    MessageBox.Show("Đóng thất bại", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView1.ClearSelection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Bạn có chắc chắn ?";
            string title = "Chú ý";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            DataGridViewRow row = dataGridView1.CurrentRow;
            string tt = row.Cells[2].Value + "";
            if (result == DialogResult.OK)
            {
                if (tt == "Tắt")
                    MessageBox.Show("Máy đang ở trạng thái tắt", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Máy đã được khởi động lại");
            }
            dataGridView1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string trangthai = dataGridView1.CurrentRow.Cells[2].Value + "";
            string id = dataGridView1.CurrentRow.Cells[0].Value + "";
            if (trangthai == "Tắt")
                MessageBox.Show("Máy đã ở trạng thái tắt, không thể tắt nữa!");
            else if (trangthai == "Mở")
                MessageBox.Show("Máy đang ở trạng thái có người sử dụng, không thể tắt");
            else
            {
                tt.TatMay(id);
                dataGridView1.DataSource = tt.GetInfoPC();
                MessageBox.Show("Tắt thành công");
            }
            dataGridView1.ClearSelection();
        }
        // Mở máy
        private void button1_Click(object sender, EventArgs e)
        {
            string title = "Thông báo";
            string tbTat = "Máy phải đang ở trạng thái bật thì mới mở được";
            string trangthai = dataGridView1.CurrentRow.Cells[2].Value + "";
            if (trangthai == "Tắt")
                MessageBox.Show(tbTat, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (trangthai == "Mở")
                MessageBox.Show("Máy đang ở trạng thái mở", title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                tmrClock.Enabled = true;
                DateTime StartTime = DateTime.Now;

                //Lấy số h:m:s
                string time = StartTime.ToString("yyyy-MM-dd HH:mm:ss");
                string id = dataGridView1.CurrentRow.Cells[0].Value + "";
                // oBam = dataGridView1.CurrentRow.Cells[2].RowIndex;
                if (tt.MoMay(id, time))
                {
                    MessageBox.Show("Mở thành công");
                    dataGridView1.DataSource = tt.GetInfoPC();
                    
                }
                else
                    MessageBox.Show("Mở thất bại", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView1.ClearSelection();
            }

        }

        private void FormXemTTPC_Shown(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == "Tắt")
                    row.Cells[2].Style.BackColor = Color.Red;
                else if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == "Mở")
                    row.Cells[2].Style.BackColor = Color.Lime;
                else if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == "Bật")
                    row.Cells[2].Style.BackColor = Color.Yellow;

        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == "Mở")
                {
                    DateTime startTime;
                    tt.GetTimeStart(row.Cells[0].Value.ToString(), out startTime);
                    TimeSpan dem = DateTime.Now - startTime;
                    string time = dem.Hours + ":" + dem.Minutes + ":" + dem.Seconds;
                    int h = dem.Hours;
                    int m = dem.Minutes;
                    int s = dem.Seconds + (m * 60) + (h * 3600);
                    double SoTien = CTrangThai.QuyDoiGiayTien(s);
                    row.Cells[3].Value = time;
                    row.Cells[5].Value = SoTien;
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tt.GetInfoPC();

            foreach (DataGridViewRow row in dataGridView1.Rows)
                if (row.Cells[2].Value != null && row.Cells[2].Value.ToString() == "Mở")
                {
                    DateTime startTime;
                    tt.GetTimeStart(row.Cells[0].Value.ToString(), out startTime);
                    TimeSpan dem = DateTime.Now - startTime;
                    string time = dem.Hours + ":" + dem.Minutes + ":" + dem.Seconds;
                    int h = dem.Hours;
                    int m = dem.Minutes;
                    int s = dem.Seconds + (m * 60) + (h * 3600);
                    double SoTien = CTrangThai.QuyDoiGiayTien(s);
                    row.Cells[3].Value = time;
                    row.Cells[5].Value = SoTien;
                }
            tmrClock.Enabled = true;
            dataGridView1.ClearSelection();
        }
    }
}
