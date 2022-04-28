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
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(1000);
            splashScreenManager1.CloseWaitForm();
            frmTrangChu frm = new frmTrangChu();
            frm.Show();
            this.Hide();

            taikhoan = txtUserName.Text;
        }

        private void gunathoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if (a == DialogResult.Yes)
            {

                Close();
            }
        }
    }
}
