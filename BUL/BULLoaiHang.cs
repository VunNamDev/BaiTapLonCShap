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
        public List<LoaiHang> layDanhSachMaLoaiHang(string ma)
        {
            return dalLH.danhSachMaLoaiHang(ma);
        }
        public void them(LoaiHang lh)
        {
            dalLH.themLoaiHang(lh);
        }
        public void sua(LoaiHang lh)
        {
            dalLH.suaLoaiHang(lh);
        }
        public void xoa(LoaiHang lh)
        {
            dalLH.xoaLoaiHang(lh);
        }
        public List<LoaiHang> tim(LoaiHang lh)
        {
            return dalLH.timLoaiHang(lh);
        }
    }
}
