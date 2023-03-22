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
    public partial class FTaoTK : Form
    {
        public CTaoTK a;
        public FTaoTK()
        {
            InitializeComponent();
            a = new CTaoTK();
;
        }
        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            string tk = txtUser.Text;
            string mk = txtPass.Text;
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                if (a.taotk(tk, mk))
                {
                    MessageBox.Show("Tạo tài khoản thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                    txtUser.Clear();
                    txtPass.Clear();
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");

            
        }
    }
}
