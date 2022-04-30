using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLLTuVan
    {
        DALTuVan daltuvan = new DALTuVan();
        public BLLTuVan() { }

        public List<TenMayTinh> loadTen(){
            return daltuvan.loadTen();
        }

        public List<TinhTrangOne> LoadTinhTrang1(string tenmay)
        {
            return daltuvan.loadTinhTrang1(tenmay);
        }

        public List<View_TinhTrangTwo> LoadTinhTrang2(string tentt1)
        {
            return daltuvan.loadTinhTrang2(tentt1);
        }

        public List<View_TinhTrangThree> LoadTinhTrang3(string tentt1, string tentt2)
        {
            return daltuvan.loadTinhTrang3(tentt1, tentt2);
        }

        public List<View_Kq> LoadKetQua(string tentt1, string tentt2,string tentt3)
        {
            return daltuvan.loadKetQua(tentt1, tentt2, tentt3);
        }

        public List<View_Anh> LoadAnh(string kq)
        {
            return daltuvan.loadAnh(kq);
        }
    }
}
