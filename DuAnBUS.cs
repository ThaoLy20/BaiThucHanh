using QuanLyNhanSu.DataAccess.DAL;
using QuanLyNhanSu.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.Business
{
    class DuAnBUS
    {
        DuAnDAL dadal = new DuAnDAL();
        Data dt = new Data();
        public DataTable getDuAn()
        {
            return dadal.getDuAn();
        }
       public void insertDA(DuAnDTO da)
        {
             dadal.insertDA(da);
        }
        public void updateDA(DuAnDTO da, string ma)
        {
            dadal.updateDA(da, ma);
        }
        public void deleteDA(string ma)
        {
            dadal.deleteDA(ma);
        }
        public DataTable Search(String condi)
        {
            return dadal.Search(condi);
        }
    }
}
