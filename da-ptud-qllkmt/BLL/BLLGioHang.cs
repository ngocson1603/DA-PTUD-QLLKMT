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
        public bool postGioHang(ThemGioHang cthd)
        {
            return dalgiohang.PostGioHang(cthd);
        }
        public bool deleteGioHang(int ma)
        {
            return dalgiohang.DeleteGio(ma);
        }
        public bool postGioHangCTHD(ThemCTHD cthd)
        {
            return dalgiohang.PostChiTietHD(cthd);
        }
        public bool deleteGioHangCTHD(int ma)
        {
            return dalgiohang.DeleteCTHD(ma);
        }
        public bool themGioHang(ChiTietHoaDon cthd)
        {
            return dalgiohang.themGioHang(cthd);
        }


        //public List<View_GioHang> loadGioHang(string tenkh)
        //{
        //    return dalgiohang.loadGioHang(tenkh);
        //}

        public List<View_GioHang> loadGioHangAPI(string tenkh)
        {
            return dalgiohang.GetWatchListGioHang(tenkh);
        }

        public List<View_CTHD> loadHDAPI()
        {
            return dalgiohang.GetWatchListGioHangSP();
        }

        public List<View_BieuMauGio> loadBieuMauGioHangAPI(string tenkh)
        {
            return dalgiohang.GetWatchListBieuMauGioHang(tenkh);
        }

        public List<ChiTietHoaDon> loadBieuMau(string tenkh)
        {
            return dalgiohang.loadBieuMau(tenkh);
        }

        public List<SanPham> loadTenSP(int masp)
        {
            return dalgiohang.loadTenSP(masp);
        }
    }
}
