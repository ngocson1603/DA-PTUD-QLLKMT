using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class frmTrangChuNhanVien : Form
    {
        Helper hp = new Helper();
        BLLDangNhap blldn = new BLLDangNhap();
        public frmTrangChuNhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (a == DialogResult.Yes)
            {
                Close();
                frmDN f = new frmDN();
                f.Show();
            }
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            //ActivateButton(sender);
            frmQuanLySP frm2 = new frmQuanLySP();
            frm2.TopLevel = false;
            panel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            //ActivateButton(sender);
            frmNhanVien frm2 = new frmNhanVien();
            frm2.TopLevel = false;
            panel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            //ActivateButton(sender);
            frmKhachHang frm2 = new frmKhachHang();
            frm2.TopLevel = false;
            panel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void btn_NhapSP_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            //ActivateButton(sender);
            frmNhapLinhKien frm2 = new frmNhapLinhKien();
            frm2.TopLevel = false;
            panel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void btn_BanSP_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            //ActivateButton(sender);
            frmBanSanPham frm2 = new frmBanSanPham();
            frm2.TopLevel = false;
            panel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void btn_NhaPhanPhoi_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            //ActivateButton(sender);
            frmNPP frm2 = new frmNPP();
            frm2.TopLevel = false;
            panel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void btn_HeThong_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            //ActivateButton(sender);
            frmLSPHSX frm2 = new frmLSPHSX();
            frm2.TopLevel = false;
            panel2.Controls.Add(frm2);
            frm2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }
        public static Panel pnltrang;
        public static string manv;

        private void frmTrangChuNhanVien_Load(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hp.motrangcon(new frmHienThiSP(), panel2);
            pnltrang = panel2;

            string ma = blldn.loadmanv(frmDN.taikhoan);
            manv = ma;
            string ten = blldn.loadtentheoma(ma);

            lblxinchao.Text = "Xin Chào : " + ten;
        }
    }
}
