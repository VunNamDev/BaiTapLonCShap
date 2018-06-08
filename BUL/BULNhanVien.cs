using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class BULNhanVien
    {
        DALNhanVien dalNV = new DALNhanVien();
        public List<NhanVien> laytatCaNhanVien()
        {
            return dalNV.layTatCaNhanVien();
        }
        public List<NhanVien> layTatCaNhanVienTheoMa(string s)
        {
            return dalNV.layNhanVienTheoMa(s);
        }
        public void themNhanVien(NhanVien nv)
        {
            dalNV.themNhanVien(nv);
        }
        public void suaNhanVien(NhanVien nv)
        {
            dalNV.suaNhanVien(nv);
        }
        public void xoaNhanVien(NhanVien nv)
        {
            dalNV.xoaNhanVien(nv);
        }
    }
}
