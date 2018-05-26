using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class BULHang
    {
        DALHang dalHang = new DALHang();
        public List<Hang> layTatCaHang()
        {
            return dalHang.layHang();
        }
        public List<DoanhSoTheoNgay> layBaoCao(string thang,string nam)
        {
            return dalHang.layDoanhSo(thang,nam);
        }
    }
}
