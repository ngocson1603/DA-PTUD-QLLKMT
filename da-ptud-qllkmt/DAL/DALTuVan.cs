using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALTuVan
    {
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALTuVan() { }

        public List<TenMayTinh> loadTen()
        {
            return qllk.TenMayTinhs.Select(t => t).ToList();
        }

        public List<TinhTrangOne> loadTinhTrang1(string tenmay)
        {
            return qllk.TinhTrangOnes.Where(t => t.TenMay.Equals(tenmay)).Select(t => t).ToList();
        }

        public List<View_TinhTrangTwo> loadTinhTrang2(string tentt1)
        {
            var tinhtrang2 = from lk in qllk.View_TinhTrangTwos where lk.TenTinhTrangOne == tentt1 select lk;
            return tinhtrang2.ToList();
        }

        public List<View_TinhTrangThree> loadTinhTrang3(string tentt1, string tentt2)
        {
            var tinhtrang3 = from lk in qllk.View_TinhTrangThrees where lk.TenTinhTrangOne == tentt1 && lk.TenTinhTrangTwo == tentt2 select lk;
            return tinhtrang3.ToList();
        }

        public List<View_Kq> loadKetQua(string tentt1, string tentt2,string tentt3)
        {
            var tinhtrang3 = from lk in qllk.View_Kqs where lk.TenTinhTrangOne == tentt1 && lk.TenTinhTrangTwo == tentt2 && lk.TenTinhTrangThree == tentt3 select lk;
            return tinhtrang3.ToList();
        }

        public List<View_Anh> loadAnh(string kq)
        {
            var anh = from lk in qllk.View_Anhs where lk.KetQua == kq select lk;
            return anh.ToList();
        }
    }
}
