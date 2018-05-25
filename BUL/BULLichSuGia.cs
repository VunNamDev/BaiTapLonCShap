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
    }
}
