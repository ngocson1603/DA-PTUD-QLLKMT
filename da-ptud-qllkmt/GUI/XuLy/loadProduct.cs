using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.XuLy
{
    public class loadProduct
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.QL_CUAHANGLINHKIENMAYTINH);
        DataSet ds_SinhVien = new DataSet();
        public loadProduct()
        {
            LoadSP();
            LoadSPDetail();
        }
        public void LoadSP()
        {
            string caulenh = "select Image,TenSanPham from SanPham";

            SqlDataAdapter ds_sv = new SqlDataAdapter(caulenh, conn);

            ds_sv.Fill(ds_SinhVien, "SanPham");
            DataColumn[] key = new DataColumn[1];

            key[0] = ds_SinhVien.Tables["SanPham"].Columns[0];

            ds_SinhVien.Tables["SanPham"].PrimaryKey = key;
        }



        public DataTable LoadDLSP()
        {
            return ds_SinhVien.Tables["SanPham"];
        }

        public void LoadSPDetail()
        {
            string caulenh = "select TenSanPham,TenLoaiSanPham,TenHangSanXuat,GiaBan,TonKho,Image,MaSanPham from SanPham,LoaiSanPham,HangSanXuat where SanPham.HangSanXuat = HangSanXuat.MaHangSanXuat and SanPham.LoaiSanPham = LoaiSanPham.MaLoaiSanPham and TenSanPham = N'" + UserControls.listProduct.ten + "'";

            SqlDataAdapter ds_sv = new SqlDataAdapter(caulenh, conn);

            ds_sv.Fill(ds_SinhVien, "SanPhamDetail");
            DataColumn[] key = new DataColumn[1];

            key[0] = ds_SinhVien.Tables["SanPhamDetail"].Columns[0];

            ds_SinhVien.Tables["SanPhamDetail"].PrimaryKey = key;
        }



        public DataTable LoadDLSPDetail()
        {
            return ds_SinhVien.Tables["SanPhamDetail"];
        }
    }
}
