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

        public bool dangKy(KhachHang kh)
        {
            return daldangky.dangKy(kh);
        }
    }
}
