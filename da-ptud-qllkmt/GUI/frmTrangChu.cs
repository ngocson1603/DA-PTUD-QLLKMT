using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using BLL;

namespace GUI
{
    public partial class frmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Helper hp = new Helper();
        public frmTrangChu()
        {
            InitializeComponent();
            pnltrang = panel1;
            txtChao.Caption += "Xin chào : " + frmDN.taikhoan;
        }

        public static Panel pnltrang;

        public Form currentchildform;
        public void motrangcon(Form trangcon)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();

            }
            currentchildform = trangcon;
            trangcon.TopLevel = false;
            trangcon.FormBorderStyle = FormBorderStyle.None;
            trangcon.Dock = DockStyle.Fill;
            panel1.Controls.Add(trangcon);
            panel1.Tag = trangcon;
            trangcon.BringToFront();
            trangcon.Show();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if (a == DialogResult.Yes)
            {
                Close();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            if (a == DialogResult.Yes)
            {
                Close();
                frmDN f = new frmDN();
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmProductList(),panel1);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmGioHang(), panel1);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmGiaoDien(), panel1);
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            hp.motrangcon(new frmGiaoDien(),panel1);
        }
    }
}