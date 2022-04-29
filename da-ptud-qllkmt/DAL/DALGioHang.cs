﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALGioHang
    {
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        public DALGioHang()
        {

        }

        public List<View_GioHang> loadGioHang(string tenkh)
        {
            return qllk.View_GioHangs.Where(t => t.Gmail.Equals(tenkh)).Select(t => t).ToList();
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

        public bool xoaGioHang(int ma)
        {
            ChiTietHoaDon cthd = qllk.ChiTietHoaDons.Where(t => t.MaHoaDon == ma).FirstOrDefault();
            try
            {
                qllk.ChiTietHoaDons.DeleteOnSubmit(cthd);
                qllk.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
