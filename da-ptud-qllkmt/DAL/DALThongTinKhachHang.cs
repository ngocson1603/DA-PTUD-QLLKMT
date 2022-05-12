using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DTO;

namespace DAL
{
    public class DALThongTinKhachHang
    {
        private ApiService _apiService = new ApiService();

        //public List<Khoa> GetWatchList()
        //{
        //    var response = _apiService.GetResponse("api/Khoa/");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return response.Content.ReadAsAsync<List<Khoa>>().Result;
        //    }
        //    return null;
        //}

        //public List<View_Lop> GetWatchListLop()
        //{
        //    var response = _apiService.GetResponse("api/Lop/");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return response.Content.ReadAsAsync<List<View_Lop>>().Result;
        //    }
        //    return null;
        //}

        //public List<View_KhachHang> GetWatchListKhoaTheoMa(string ma)
        //{
        //    var response = _apiService.GetResponse(string.Format("api/Khoa/{0}", ma));
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return response.Content.ReadAsAsync<List<View_KhachHang>>().Result;
        //    }
        //    return null;
        //}

        //public bool PostKhoa(Khoa pKhoa)
        //{
        //    var response = _apiService.PostResponse("api/Khoa/", pKhoa);
        //    if (response == null)
        //        return false;
        //    else
        //        return true;
        //}
        //public bool XoaKhoa(Khoa pKhoa)
        //{
        //    var response = _apiService.PostResponse("api/Khoa/", pKhoa);
        //    if (response == null)
        //        return false;
        //    else
        //        return true;
        //}
    }
}
