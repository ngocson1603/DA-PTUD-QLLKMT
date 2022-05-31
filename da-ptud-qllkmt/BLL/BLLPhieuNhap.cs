﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLPhieuNhap
    {
        DALPhieuNhap dalphieunhap = new DALPhieuNhap();
        public BLLPhieuNhap()
        {

        }
        public List<View_PhieuNhap> LoadPN()
        {
            return dalphieunhap.GetDanhSachPN();
        }

        public List<View_CTPhieuNhap> LoadCTPN()
        {
            return dalphieunhap.GetDanhSachCTPN();
        }


        // them xoa sua pn

        public bool postPN(ThemPhieuNhap cthd)
        {
            return dalphieunhap.PostPN(cthd);
        }
        public bool deletePN(int ma)
        {
            return dalphieunhap.DeletePN(ma);
        }

        public bool putPN(ThemPhieuNhap cthd, int ma)
        {
            return dalphieunhap.PutPN(cthd, ma);
        }
        // them xoa ctpn

        public bool postCTPN(ThemCTPN cthd)
        {
            return dalphieunhap.PostCTPN(cthd);
        }
        public bool deleteCTPN(int ma)
        {
            return dalphieunhap.DeleteCTPN(ma);
        }
    }
}