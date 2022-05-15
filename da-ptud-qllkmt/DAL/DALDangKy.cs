using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DTO;

namespace DAL
{
    public class DALDangKy
    {
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALDangKy()
        {

        }

        public List<KhachHang> loadThongTin(string user)
        {
            return qllk.KhachHangs.Where(t => t.Gmail.Equals(user)).Select(t => t).ToList();
        }

        private ApiService _apiService = new ApiService();

        public List<KhachHang> GetWatchInfoKH(string ma)
        {
            var response = _apiService.GetResponse(string.Format("api/KhachHang/{0}", ma));
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<List<KhachHang>>().Result;
            }
            return null;
        }

        public bool PutKhachHang(KhachHang pKH, string ten)
        {
            var response = _apiService.PutResponse(string.Format("api/KhachHang/{0}", ten), pKH);
            if (response == null)
                return false;
            else
                return true;
        }

        public bool PostDangKy(KhachHang pKH)
        {
            var response = _apiService.PostResponse("api/KhachHang/", pKH);
            if (response == null)
                return false;
            else
                return true;
        }

        //public bool dangKy(KhachHang kh)
        //{
        //    try
        //    {
        //        qllk.KhachHangs.InsertOnSubmit(kh);
        //        qllk.SubmitChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //public bool suaThongTin(string user, string pass, string tenkh,string ngays,string gioitinh,string diachi,string sdt)
        //{
        //    try
        //    {
        //        KhachHang kh = qllk.KhachHangs.Where(t => t.Gmail == user).FirstOrDefault();
        //        kh.Pass = pass;
        //        kh.TenKhachHang = tenkh;
        //        kh.Ngaysinh = DateTime.Parse(ngays);
        //        kh.GioiTinh = gioitinh;
        //        kh.DiaChi = diachi;
        //        kh.SDT = sdt;
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
