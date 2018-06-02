using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUL
{
    public class BULLichSuGia
    {
        
        DALLichSuGia LSG = new DALLichSuGia();

        public DataTable layTatCaLichSuGiaCoTenHang()
        {
            return LSG.layTatCaLichSuGiaCoTenHang();
        }
        public List<LichSuGia> layTatCaLichSuGia()
        {
            return LSG.layTatCaLichSuGia();
        }
        public DataTable layTatCaLichSuGiaCoTenHang(string s)
        {
            return LSG.layTatCaLichSuGiaCoTenHang(s);
        }
       
        public void add(LichSuGia lsg)
        {   
            LSG.themLichSuGia(lsg);
        }
        public void update(LichSuGia lsg)
        {
            LSG.suaLichSuGia(lsg);
        }
        public void Xoa(LichSuGia lsg)
        {
            LSG.xoaLichSuGia(lsg);
        }
    }
}
