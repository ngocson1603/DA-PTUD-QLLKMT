using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLDangKy
    {
        DALDangKy daldangky = new DALDangKy();
        public BLLDangKy() { }

        public List<KhachHang> loadThongTin(string user)
        {
            return daldangky.loadThongTin(user);
        }

        public List<KhachHang> loadKhachHangAPI(string tenkh)
        {
            return daldangky.GetWatchInfoKH(tenkh);
        }

        //public bool dangKy(KhachHang kh)
        //{
        //    return daldangky.dangKy(kh);
        //}

        public bool suaKhachHang(KhachHang kh,string ten)
        {
            return daldangky.PutKhachHang(kh,ten);
        }

        public bool themKhachHang(KhachHang kh)
        {
            return daldangky.PostDangKy(kh);
        }

        //public bool suaThongTin(string user, string pass, string tenkh, string ngays, string gioitinh, string diachi, string sdt)
        //{
        //    return daldangky.suaThongTin( user,  pass,  tenkh,  ngays,  gioitinh,  diachi,  sdt);
        //}
    }
}
