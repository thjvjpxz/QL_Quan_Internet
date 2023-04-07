using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLInternet
{
    public partial class FrmDongMay : Form
    {
        int SoPhut;
        double TongTien;
        public FrmDongMay(int soPhut, double tongTien)
        {
            InitializeComponent();
            SoPhut = soPhut;
            TongTien = tongTien;
        }

        private void FrmDongMay_Load(object sender, EventArgs e)
        {
            lblTG.Text = SoPhut + "";
            lblTongTien.Text = Math.Round(TongTien, 2) + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
