using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class BULNhaCungCap
    {
        DALNhaCungCap dalNCC = new DALNhaCungCap();

        public List<NhaCungCap> layTatCaNhaCungCap()
        {
            return dalNCC.layTatCaNhaCungCap();
        }

        public List<NhaCungCap> layDanhSachMaNCC(string ma)
        {
            return dalNCC.danhSachMaNCC(ma);
        }
        public List<NhaCungCap> layNhaCungCapTheoMa(string s)
        {
            return dalNCC.layNhaCungCapTheoMa(s);
        }
        public void themNhaCungCap(NhaCungCap ncc)
        {
            dalNCC.themNhaCungCap(ncc);
        }
        public void suaNhaCungCap(NhaCungCap ncc)
        {
            dalNCC.suaNhaCungCap(ncc);
        }
        public void xoaNhaCungCap(NhaCungCap ncc)
        {
            dalNCC.xoaNhaCungCap(ncc);
        }

    }
}
