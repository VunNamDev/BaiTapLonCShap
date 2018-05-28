using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class BULKhachHang
    {
        DALKhachHang dalKH = new DALKhachHang();

        public List<KhachHang> layTatCaKhachHang()
        {
            return dalKH.layKH();
        }
        public List<KhachHang> layTatCaKhachHang(KhachHang kh )
        {
            return dalKH.layKH(kh);
        }
        public void sua(KhachHang kh)
        {
            dalKH.suaKhachHang(kh);
        }
        public void them(KhachHang kh)
        {
            dalKH.themKhachHang(kh);

        }
        public void xoa(KhachHang kh)
        {
            dalKH.xoaKhachHang(kh);
        }
    }
}
