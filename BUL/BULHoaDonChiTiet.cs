using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BUL
{
  public  class BULHoaDonChiTiet
    {
        DALHoaDonChiTiet DALHoaDonChiTiet = new DALHoaDonChiTiet();

        public List<HoaDonChiTiet> layHD()
        {
            return DALHoaDonChiTiet.layTatCHDCT();
        }
        public void themHDCT(HoaDonChiTiet hoaDonChiTiet)
        {
            DALHoaDonChiTiet.themHoaDonCT(hoaDonChiTiet);
        }
    }
}
