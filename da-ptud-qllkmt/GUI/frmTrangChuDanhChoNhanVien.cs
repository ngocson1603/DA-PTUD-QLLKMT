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
        BLLDangNhap blldn = new BLLDangNhap();
        public frmTrangChuDanhChoNhanVien()
        {
            InitializeComponent();

        }
        public static Panel pnltrang;
        public static string manv;
        private void hiệnThịSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmHienThiSP(), panel1);
            panel1.Controls.Add(statusBar1);
        }

        private void frmTrangChuDanhChoNhanVien_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmHienThiSP(), panel1);
            pnltrang = panel1;

            string ma = blldn.loadmanv(frmDN.taikhoan);
            manv = ma;
            string ten = blldn.loadtentheoma(ma);

            statusBar1.Text = "Xin Chào : " + ten;
            panel1.Controls.Add(statusBar1);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmNhapLinhKien(), panel1);
            panel1.Controls.Add(statusBar1);
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmBanSanPham(), panel1);
            panel1.Controls.Add(statusBar1);
        }

        private void quảnLýHãngLoàiSXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmLSPHSX(), panel1);
            panel1.Controls.Add(statusBar1);
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmKhachHang(), panel1);
            panel1.Controls.Add(statusBar1);
        }

        private void quảnLýNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmNhanVien(), panel1);
            panel1.Controls.Add(statusBar1);
        }

        private void quảnLýNhàPhânPhốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmNPP(), panel1);
            panel1.Controls.Add(statusBar1);
        }

        private void thôngKêSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpSảnPhảmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmQuanLySP(), panel1);
            panel1.Controls.Add(statusBar1);
        }
    }
}
