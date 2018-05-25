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
        KhachHang x;

        DALKhachHang kh = new DALKhachHang();

        public KhachHang X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public List<KhachHang> layTatCaKhachHang()
        {
            return kh.layKH();
        }
        public void update()
        {
            kh.suaKhachHang(x);
        }
        public void insert()
        {
            kh.themKhachHang(x);

        }
        public void delete()
        {
            kh.xoaKhachHang(x);
        }
    }
}
