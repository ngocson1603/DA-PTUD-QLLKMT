using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALDangNhap
    {
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALDangNhap()
        {

        }
        public bool Kiemtradangnhapkhachhang(string gmail,string pass)
        {
            return qllk.KhachHangs.Where(t => t.Gmail == gmail && t.Pass == pass).FirstOrDefault() != null;
        }
        public bool Kiemtradangnhapnhanvien(string tendn, string pass)
        {
            return qllk.Users.Where(t => t.TenDangNhap == tendn && t.Password == pass).FirstOrDefault() != null;
        }
    }
}
