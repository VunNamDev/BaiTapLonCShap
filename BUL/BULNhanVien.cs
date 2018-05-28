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
    }
}
