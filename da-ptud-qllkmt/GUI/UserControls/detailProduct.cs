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

namespace GUI.UserControls
{
    public partial class detailProduct : UserControl
    {
        Helper hp = new Helper();
        public detailProduct()
        {
            InitializeComponent();
        }

        public Image GetImg(string direct, int w, int h)
        {
            Image i = Image.FromFile(direct);
            return (Image)(new Bitmap(i, new Size(w, h)));
        }
        public static string a;
        public void AddProducts(detailProducts s)
        {
            lblTenSanPham.Text = s.TenSP.ToString();
            lblTenLoai.Text = s.TenLoai.ToString();
            lblTenHang.Text = s.TenHang.ToString();
            lblGiaBan.Text = s.GiaBan.ToString();
            lblTonkho.Text = s.TonKho.ToString();
            string direct = hp.Directory() + s.Hinh;
            a = s.Hinh;
            pictureDetailSP.Image = GetImg(direct, pictureDetailSP.Width, pictureDetailSP.Height);       
            label8.Text = s.MaSP.ToString();
        }

        private void gunathoat_Click(object sender, EventArgs e)
        {
            Panel pnl = this.Parent as Panel;
            Form frm1 = pnl.Parent as Form;
            frm1.Close();


            frmProductList frm = new frmProductList();
            hp.motrangcon(frm, frmTrangChu.pnltrang);
        }

        public static string ma = "";
        public static string gia = "";
        public static string loai = "";
        public static string hang = "";
        public static string tensp = "";
        public static string tonkho = "";
        public static string anh = "";
        public static List<String> lstsp = new List<string>();
        public List<String> lst = new List<string>();

        private void gunaMua_Click(object sender, EventArgs e)
        {
            int b = 1;
            ma = label8.Text;
            gia = lblGiaBan.Text;
            loai = lblTenLoai.Text;
            hang = lblTenHang.Text;
            tensp = lblTenSanPham.Text;
            tonkho = b.ToString();
            anh = a;

            MessageBox.Show("Vui lòng kiểm tra trong phần giỏ hàng");

            lst.Add(tensp);
            lst.Add(loai);
            lst.Add(hang);
            lst.Add(gia);
            lst.Add(tonkho);
            lst.Add(anh);
            lst.Add(ma);
            lstsp.AddRange(lst);
        }
    }
}
