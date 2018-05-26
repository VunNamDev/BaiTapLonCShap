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
        DALKhachHang dallKH = new DALKhachHang();

        public List<KhachHang> layTatCaKhachHang()
        {
            return dallKH.layKH();
        }
        public List<KhachHang> layTatCaKhachHang(KhachHang kh )
        {
            return dallKH.layKH(kh);
        }
        public void sua(KhachHang kh)
        {
            dallKH.suaKhachHang(kh);
        }
        public void them(KhachHang kh)
        {
            dallKH.themKhachHang(kh);

        }
        public void xoa(KhachHang kh)
        {
            dallKH.xoaKhachHang(kh);
        }
    }
}
