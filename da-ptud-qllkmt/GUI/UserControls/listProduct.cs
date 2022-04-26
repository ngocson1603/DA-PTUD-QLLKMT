using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI.UserControls
{
    public partial class listProduct : UserControl
    {
        Helper hp = new Helper();
        public static string ten = "";
        public listProduct()
        {
            InitializeComponent();
        }

        public Image GetImg(string direct, int w, int h)
        {
            Image i = Image.FromFile(direct);
            return (Image)(new Bitmap(i, new Size(w, h)));
        }

        public void AddProducts(productList s)
        {
            string direct = hp.Directory() + s.Anh;
            pictureHinh.Image = GetImg(direct, pictureHinh.Width, pictureHinh.Height);
            lblTenSanPham.Text = s.TenSP.ToString();
        }

        private void pictureHinh_Click(object sender, EventArgs e)
        {
            frmProductList frm1 = new frmProductList();
            frm1.Hide();
            ten = lblTenSanPham.Text;
            frmTrangChu frm = new frmTrangChu();
            frm.motrangcon(new frmDetailProduct());
        }
    }
}
