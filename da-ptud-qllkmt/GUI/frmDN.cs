using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDN : Form
    {
        public frmDN()
        {
            InitializeComponent();
        }

        public static string taikhoan = "";

        private void gunardangnhap_Click(object sender, EventArgs e)
        {
            taikhoan = txtUserName.Text;
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(1000);
            splashScreenManager1.CloseWaitForm();
            frmTrangChu frm = new frmTrangChu();
            frm.Show();
            this.Hide();
        }

        private void gunathoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if (a == DialogResult.Yes)
            {

                Close();
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.Show();
            this.Hide();
        }

        private void txtPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void check_DangNhap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
