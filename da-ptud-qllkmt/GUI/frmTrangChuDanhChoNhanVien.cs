using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmTrangChuDanhChoNhanVien : Form
    {
        Helper hp = new Helper();
        public frmTrangChuDanhChoNhanVien()
        {
            InitializeComponent();
        }
        public static Panel pnltrang;

        private void hiệnThịSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmHienThiSP(), panel1);
        }

        private void frmTrangChuDanhChoNhanVien_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmHienThiSP(), panel1);
            pnltrang = panel1;
        }
    }
}
