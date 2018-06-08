using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;
namespace BUL
{
   public class BULHoaDon
    {
        DALHoaDon DALHoaDon = new DALHoaDon();
       public List<HoaDon> layds()
        {
            return DALHoaDon.layTatCHD();
        }
        public void themHoaDon(HoaDon hoaDon)
        {
            DALHoaDon.themHoaDon(hoaDon);
        }
        public DataTable hienHoaDon()
        {
            return DALHoaDon.inHoaDon();
        }
        public DataTable timHoaDon(HoaDon hoaDon)
        {
            return DALHoaDon.timHoaDon(hoaDon);
        }
    }
}
