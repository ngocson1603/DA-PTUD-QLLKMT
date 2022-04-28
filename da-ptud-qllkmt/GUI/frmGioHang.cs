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
    public partial class frmGioHang : Form
    {
        public frmGioHang()
        {
            InitializeComponent();
            
        }

        private void frmGioHang_Load(object sender, EventArgs e)
        {
            txtMaSP.Text = UserControls.detailProduct.ma;
            txtGiaTien.Text = UserControls.detailProduct.gia;
            txtTK.Text = frmDN.taikhoan;
            tinhTien();
        }

        public void tinhTien()
        {
            cboSoLuong.SelectedIndex = 0;
            int sl = int.Parse(cboSoLuong.SelectedItem.ToString());
            int gia = int.Parse(txtGiaTien.Text);
            int kq = sl * gia;
            txtTongTien.Text = kq.ToString();
        }

        private void cboSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sl = int.Parse(cboSoLuong.SelectedItem.ToString());
            int gia = int.Parse(txtGiaTien.Text);
            int kq = sl * gia;
            txtTongTien.Text = kq.ToString();
        }
    }
}
