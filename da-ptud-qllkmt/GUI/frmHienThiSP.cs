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
using DTO;
namespace GUI
{
    public partial class frmHienThiSP : Form
    {
        BLLSanPham bllsp = new BLLSanPham();
        Helper hp = new Helper();
        public frmHienThiSP()
        {
            InitializeComponent();
            List<CL_Loaihienthi> cbb = new List<CL_Loaihienthi>();
            cbb.Add(new CL_Loaihienthi("Tất cả", "select * from SanPham "));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo thứ tự tăng dần", "select *  from SanPham order by LoaiSanPham, TenSanPham"));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo giá bán giảm dần", "select *  from SanPham order by GiaBan DESC"));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo giá bán tăng  dần", "select *  from SanPham order by GiaBan"));
            cbb.Add(new CL_Loaihienthi("Linh kiện có giá cao nhất", "select top 1 *  from SanPham order by GiaBan DESC"));
            cbbhienthi.DataSource = cbb;
            cbbhienthi.DisplayMember = "Ten";
            cbbhienthi.ValueMember = "Query";
            hienthilinkien(" select * from SanPham");
        }
        void hienthilinkien(string query)
        {
            dgv_hienthi.DataSource = bllsp.LoadSanPham(); 
        }

        private void btnBanra_Click(object sender, EventArgs e)
        {
            frmBanSanPham frm = new frmBanSanPham();
            hp.motrangcon(frm, frmTrangChuDanhChoNhanVien.pnltrang);


        }

        private void btnNhapvao_Click(object sender, EventArgs e)
        {

            frmNhapLinhKien frm = new frmNhapLinhKien();
            hp.motrangcon(frm, frmTrangChuDanhChoNhanVien.pnltrang);
        }



    }
}
