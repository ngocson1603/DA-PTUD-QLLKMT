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
using DTO;
using BLL;

namespace GUI
{
    public partial class frmTrangChuNhanVien1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Helper hp = new Helper();
        BLLDangNhap blldn = new BLLDangNhap();
        public static Panel pnltrang;
        public static string manv;
        public frmTrangChuNhanVien1()
        {
            InitializeComponent();
        }

        private void frmTrangChuNhanVien1_Load(object sender, EventArgs e)
        {
            pnltrang = panel2;

            string ma = blldn.loadmanv(frmDN.taikhoan);
            manv = ma;
            string ten = blldn.loadtentheoma(ma);

            txtChao.Caption = ten;
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (a == DialogResult.Yes)
            {
                frmBanSanPham.laygiatri = false;
                Close();
                frmDN f = new frmDN();
                f.Show();
            }
        }

        private void btnSanPham_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmQuanLySP(), panel2);
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmNhanVien(), panel2);
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmKhachHang(), panel2);
        }

        private void btnBaoHanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmBaoHanh(), panel2);
        }

        private void btnNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmNhapLinhKien(), panel2);
        }

        private void btnXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmBanSanPham(), panel2);
        }

        private void btnHangLoai_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmLSPHSX(), panel2);
        }

        private void btnDonDatHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmDonDatHang(), panel2);
        }

        private void btnNPP_ItemClick(object sender, ItemClickEventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmNPP(), panel2);
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBackup frm = new frmBackup();
            frm.ShowDialog();
        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }
    }
}