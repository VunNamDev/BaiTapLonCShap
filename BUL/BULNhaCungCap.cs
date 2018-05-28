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
    }
}
