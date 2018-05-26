using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUL
{
    public class BULLichSuGia
    {
        
        DALLichSuGia LSG = new DALLichSuGia();


        public List<LichSuGia> layTatCaLichSuGia()
        {
            return LSG.layLSG();
        }
        public List<LichSuGia> layTatCaLichSuGiaCoDieuKien(LichSuGia lsg)
        {
            return LSG.layLSGCoDieuKien(lsg.MaHang);
        }
        public LichSuGia lsgTonTai(LichSuGia lsg)
        {
            return LSG.KiemTraTonTai(lsg);
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
