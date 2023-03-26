using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Controller;

namespace TaoHoaDon
{
    public partial class Form1 : Form
    {
        CCapNhatSLBan capnhatslban;
        CXoaSP xoasp;
        CFindSP findsp;
        CGetBangThe getbangthe;
        CGetBangDoAn getbangdoan;
        CGetBangDoUong getbangdouong;
        CGetMon get;
        CAddHD add;
        CInsert insert;
        public Form1()
        {
            InitializeComponent();
            get = new CGetMon();
            getbangdoan = new CGetBangDoAn();
            getbangdouong = new CGetBangDoUong();
            getbangthe = new CGetBangThe();
            findsp = new CFindSP();
            xoasp = new CXoaSP();
            capnhatslban = new CCapNhatSLBan();
            add = new CAddHD();
            insert = new CInsert();

            comboBox1.Items.Add("Đồ Ăn");
            comboBox1.Items.Add("Đồ Uống");
            comboBox1.Items.Add("Thẻ Game");

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSize = false;
            dataGridView1.Columns.Add("IDSP", "Mã Sản Phẩm");
            dataGridView1.Columns[0].DataPropertyName = "IDSP";
            dataGridView1.Columns.Add("TenSP", "Tên Sản Phẩm");
            dataGridView1.Columns[1].DataPropertyName = "TenSP";
            dataGridView1.Columns.Add("GiaBan", "Giá Bán");
            dataGridView1.Columns[2].DataPropertyName = "GiaBan";
            dataGridView1.Columns.Add("SLTon", "Số Lượng Tồn");
            dataGridView1.Columns[3].DataPropertyName = "SLTon";
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.Rows.Count <= 0)
            {
                MessageBox.Show("Hóa đơn chưa có món ăn nào!");
                return;
            }
            double tong = Convert.ToInt32(txtTong.Text.ToString());
            int maHD = add.AddHD(tong);
                for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
                {
                    string ID = dgvHoaDon.Rows[i].Cells["ID"].Value.ToString();
                    int soLuong = Convert.ToInt32(dgvHoaDon.Rows[i].Cells["Soluong"].Value);
                    insert.insert(maHD, ID, soLuong);
                    capnhatslban.CapNhatSLBan(ID, soLuong);
                }
            MessageBox.Show("Lưu hoá đơn thành công!");
            if (checkBox1.Checked)
            {
                PrintDocument doc = new PrintDocument();
                doc.PrintPage += doc_PrintPage;
                PrintPreviewDialog dialog = new PrintPreviewDialog();
                dialog.Document = doc;
                dialog.ShowDialog();
            }
            dgvHoaDon.Rows.Clear();
            checkBox1.Checked = false;
            txtTong.Clear();
            Form1_Load(sender, e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown2.Value = 1;
            dataGridView1.DataSource = get.GetMon();
        }

        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            string title = "HÓA ĐƠN";
            Font fontTitle = new Font("Arial", 16, FontStyle.Bold);
            SizeF sizeTitle = g.MeasureString(title, fontTitle);
            float xTitle = e.MarginBounds.Left + (e.MarginBounds.Width - sizeTitle.Width) / 2;
            float yTitle = e.MarginBounds.Top;
            g.DrawString(title, fontTitle, Brushes.Black, xTitle, yTitle);
            Font fontTableHeader = new Font("Arial", 12, FontStyle.Bold);
            Font fontTableContent = new Font("Arial", 12, FontStyle.Regular);
            float xTable = e.MarginBounds.Left;
            float yCustomer = yTitle + sizeTitle.Height + 20;
            float yTable = yCustomer + 80;
            float[] columnWidths = { 100, 200, 150, 150, 150 };
            float rowHeight = fontTableContent.GetHeight();
            string[] columnHeaders = { "ID", "Tên", "Giá", "Số lượng", "Thành tiền" };
            for (int i = 0; i < columnHeaders.Length; i++)
            {
                g.DrawString(columnHeaders[i], fontTableHeader, Brushes.Black, xTable, yTable);
                xTable += columnWidths[i];
            }
            yTable += rowHeight;
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                string[] rowData = { dgvHoaDon.Rows[i].Cells["ID"].Value.ToString(), dgvHoaDon.Rows[i].Cells["TenMonAn"].Value.ToString(), 
                dgvHoaDon.Rows[i].Cells["Gia"].Value.ToString(), dgvHoaDon.Rows[i].Cells["SoLuong"].Value.ToString(), dgvHoaDon.Rows[i].Cells["ThanhTien"].Value.ToString() };
                xTable = e.MarginBounds.Left;
                for (int j = 0; j < rowData.Length; j++)
                {
                    g.DrawString(rowData[j], fontTableContent, Brushes.Black, xTable, yTable);
                    xTable += columnWidths[j];
                }
                yTable += rowHeight;
            }
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------------------------------", 
            new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(40, 600));
            float total = float.Parse(txtTong.Text.Replace(".", ""));
            string totalText = "Tổng tiền: " + string.Format("{0:#,##0}", total) + " đồng";
            Font fontTotal = new Font("Arial", 12, FontStyle.Bold);
            SizeF sizeTotal = g.MeasureString(totalText, fontTotal);
            float xTotal = e.MarginBounds.Right - sizeTotal.Width;
            float yTotal = e.MarginBounds.Bottom - sizeTotal.Height;
            float yhaha = e.MarginBounds.Top - sizeTotal.Height;
            g.DrawString(totalText, fontTotal, Brushes.Black, xTotal, 650);
            }

        private void dgvHoaDon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var row = dgvHoaDon.CurrentRow;
            if (row != null)
            {
                dgvHoaDon.Rows.Remove(row);
                txtTong.Text = tinhtong().ToString();
            }
        }

        public int tinhtong()
        {
            int tongtien = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                int thanhtien = Convert.ToInt32(dgvHoaDon.Rows[i].Cells["ThanhTien"].Value);
                tongtien += thanhtien;
            }
            return tongtien;
        }


        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string da = "Đồ Ăn";
            string du = "Đồ Uống";
            string the = "Thẻ Game";
            if (comboBox1.SelectedItem.ToString() == da)
            {
                dataGridView1.DataSource = getbangdoan.DoAn("Cơm", "Bún");
            }
            else if (comboBox1.SelectedItem.ToString() == du)
            {
                dataGridView1.DataSource = getbangdouong.DoUong("Đồ uống");
            }
            else if (comboBox1.SelectedItem.ToString() == the)
            {
                dataGridView1.DataSource = getbangthe.The("Thẻ");
            }
            else
            {
                //...
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = findsp.FindSP(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemSanPham fthemsp = new ThemSanPham();
            fthemsp.ShowDialog();
            dataGridView1.DataSource = get.GetMon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (xoasp.XoaSP(dataGridView1.CurrentRow.Cells["IDSP"].Value.ToString()))
            {
                MessageBox.Show("Bạn đã xóa sản phẩm thành công");
                dataGridView1.DataSource = get.GetMon();
            }
            else
                MessageBox.Show("Bạn xóa sản phẩm thất bại");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string maMon = dataGridView1.Rows[index].Cells[0].Value.ToString();
            string tenMon = dataGridView1.Rows[index].Cells[1].Value.ToString();
            int soLuongConLai = Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value);
            int gia = Convert.ToInt32(dataGridView1.Rows[index].Cells[2].Value);
            int qty = (int)numericUpDown2.Value;
            if (qty > soLuongConLai)
            {
                MessageBox.Show("Không đủ!");
                return;
            }
            double amount = gia * qty;
            dgvHoaDon.Rows.Add(maMon, tenMon, gia, qty, amount);
            numericUpDown2.Value = 1;
            txtTong.Text = tinhtong().ToString();
        }
    }
}
