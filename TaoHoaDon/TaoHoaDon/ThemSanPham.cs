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

namespace TaoHoaDon
{
    public partial class ThemSanPham : Form
    {
        CCheckSP checksp;
        CAddSP addsp;
        public ThemSanPham()
        {
            checksp = new CCheckSP();
            addsp = new CAddSP();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gia = Convert.ToInt32(textBox3.Text);
            int sl = Convert.ToInt32(textBox4.Text);
            if (checksp.CheckSP(textBox1.Text))
            {
                MessageBox.Show("Sản phẩm đã tồn tại trong bảng");
            }
            else if (addsp.AddSP(textBox1.Text, textBox2.Text, gia, sl))
            {
                MessageBox.Show("Bạn đã thêm sản phẩm thành công");
                this.Close();
            }
            else
                MessageBox.Show("Bạn thêm sản phẩm thất bại");
        }
    }
}
