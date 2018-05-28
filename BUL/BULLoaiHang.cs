using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using DAL;
namespace BUL
{
    public class BULLoaiHang
    {
        DALLoaiHang dalLH = new DALLoaiHang();

        public List<LoaiHang> layTatCaLoaiHang()
        {
            return dalLH.layTatCaLoaiHang();
        }
    }
}
