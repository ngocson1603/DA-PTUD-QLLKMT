using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLLGioHang
    {
        DALGioHang dalgiohang = new DALGioHang();
        public BLLGioHang()
        {

        }

        public bool themGioHang(ChiTietHoaDon cthd)
        {
            return dalgiohang.themGioHang(cthd);
        }

        public bool xoaGioHang(int ma)
        {
            return dalgiohang.xoaGioHang(ma);
        }

        public List<View_GioHang> loadGioHang(string tenkh)
        {
            return dalgiohang.loadGioHang(tenkh);
        }

        public List<SanPham> loadTenSP(int masp)
        {
            return dalgiohang.loadTenSP(masp);
        }
    }
}
