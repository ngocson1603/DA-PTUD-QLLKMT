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

        public void AddProducts(detailProducts s)
        {
            lblTenSanPham.Text = s.TenSP.ToString();
            lblTenLoai.Text = s.TenLoai.ToString();
            lblTenHang.Text = s.TenHang.ToString();
            lblGiaBan.Text = s.GiaBan.ToString();
            lblTonkho.Text = s.TonKho.ToString();
            string direct = hp.Directory() + s.Hinh;
            pictureDetailSP.Image = GetImg(direct, pictureDetailSP.Width, pictureDetailSP.Height);       
        }
    }
}
