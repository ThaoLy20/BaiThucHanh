using QuanLyNhanSu.DataAccess.DAL;
using QuanLyNhanSu.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.Business
{
    class LuongBUS
    {
        LuongDAL luongdal = new LuongDAL();
        
        Data dt = new Data();
        public DataTable getLuong()
        {
            return luongdal.getLuong();
        }
        public DataTable GetLuongtheoManv(string manv)
        {
            return luongdal.GetLuongtheoManv(manv);
        }
        public DataTable GetLuongtheoTG(int thang, int nam)
        {
            return luongdal.GetLuongtheoTG(thang, nam);
        }
        public void insertL(LuongDTO l)
        {
            luongdal.insertL(l);
        }
        public void updateL(LuongDTO l, string ma)
        {
            luongdal.updateL( l, ma);
        }
        public void deleteL(string ma)
        {
            luongdal.deleteL(ma);
        }
        public DataTable Search(String condi)
        {
            return luongdal.Search(condi);
        }
        public bool CheckMa(string maluong, string manhanvien)
        {
            return luongdal.CheckMa(manhanvien, maluong);
        }
        public bool CheckThangNam(string manv,int Thang,int Nam)
        {
            return luongdal.CheckThangNam(manv,Thang,Nam);
        }
    }
}
