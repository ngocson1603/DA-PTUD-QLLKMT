using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class detailProducts
    {
        public string TenSP { get; set; }

        public string TenLoai { get; set; }

        public string TenHang { get; set; }

        public string GiaBan { get; set; }

        public int TonKho { get; set; }

        public string Hinh { get; set; }

        public detailProducts()
        {
            TenSP = TenSP;
            TenLoai = TenLoai;
            TenHang = TenHang;
            GiaBan = GiaBan;
            TonKho = TonKho;
            Hinh = Hinh;
        }

        public detailProducts(string tensp,string tenloai,string tenhang,string giaban,int tonkho,string hinh)
        {
            TenSP = tensp;
            TenLoai = tenloai;
            TenHang = tenhang;
            GiaBan = giaban;
            TonKho = tonkho;
            Hinh = hinh;
        }
    }
}
