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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(1000);
            splashScreenManager1.CloseWaitForm();
            frmTrangChu frm = new frmTrangChu();
            frm.Show();
            this.Hide();
        }
    }
}
