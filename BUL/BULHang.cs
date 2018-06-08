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

        public string layMaHang()
        {
            return dalHang.maHang();
        }

        public void them(Hang h)
        {
            dalHang.themHang(h);
        }
        public void sua(Hang h)
        {
            dalHang.suaHang(h);
        }
        public void xoa(Hang h)
        {
            dalHang.xoaHang(h);
        }
        public List<Hang> timKiem(Hang h)
        {
            return dalHang.timHang(h);
        }
    }
}
