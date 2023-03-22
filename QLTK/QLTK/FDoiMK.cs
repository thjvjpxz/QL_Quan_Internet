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
    public partial class FDoiMK : Form
    {
        string User;
        private CDoiMK doi;
        public FDoiMK(string user)
        {
            InitializeComponent();
            User = user;
            doi = new CDoiMK();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "" || txtPass1.Text == "")
            {
                MessageBox.Show("Lỗi, vui lòng điền đầy đủ thông tin và chính xác!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text != txtPass1.Text)
            {
                MessageBox.Show("Lỗi, vui lòng điền đầy đủ thông tin và chính xác!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string pass = txtPass.Text;
                doi.doimk(User, pass);
                MessageBox.Show("Đổi mật khẩu thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
