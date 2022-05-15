using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALGioHang
    {
        private ApiService _apiService = new ApiService();
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALGioHang()
        {

        }

        public List<View_GioHang> loadGioHang(string tenkh)
        {
            return qllk.View_GioHangs.Where(t => t.Gmail.Equals(tenkh)).Select(t => t).ToList();
        }

        public List<View_BieuMauGio> loadBieuMauGio(string tenkh)
        {
            return qllk.View_BieuMauGios.Where(t => t.Gmail.Equals(tenkh)).Select(t => t).ToList();
        }

        public List<View_GioHang> GetWatchListGioHang(string ma)
        {
            var response = _apiService.GetResponse(string.Format("api/GioHang/{0}", ma));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_GioHang>>().Result;
            }
            return null;
        }

        public List<View_BieuMauGio> GetWatchListBieuMauGioHang(string ma)
        {
            var response = _apiService.GetResponse(string.Format("api/BieuMauGio/{0}", ma));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<View_BieuMauGio>>().Result;
            }
            return null;
        }

        public List<ChiTietHoaDon> loadBieuMau(string tenkh)
        {
            return qllk.ChiTietHoaDons.Where(t => t.Gmail.Equals(tenkh)).Select(t => t).ToList();
        }

        public List<SanPham> loadTenSP(int masp)
        {
            var tensp = from lk in qllk.SanPhams where lk.MaSanPham == masp select lk;
            return tensp.ToList();
        }
        public bool PostGioHang(ThemGioHang pCT)
        {
            var response = _apiService.PostResponse("api/GioHang/", pCT);
            if (response == null)
                return false;
            else
                return true;
        }
        public bool DeleteGio(int ma)
        {
            var response = _apiService.DeleteResponse(string.Format("api/GioHang/{0}", ma));
            if (response == null)
                return false;
            else
                return true;
        }
        public bool themGioHang(ChiTietHoaDon cthd)
        {
            try
            {
                qllk.ChiTietHoaDons.InsertOnSubmit(cthd);
                qllk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //public bool xoaGioHang(int ma)
        //{
        //    ChiTietHoaDon cthd = qllk.ChiTietHoaDons.Where(t => t.MaHoaDon == ma).FirstOrDefault();
        //    try
        //    {
        //        qllk.ChiTietHoaDons.DeleteOnSubmit(cthd);
        //        qllk.SubmitChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
    }
}
