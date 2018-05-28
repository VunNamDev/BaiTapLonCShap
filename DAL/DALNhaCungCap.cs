using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DALNhaCungCap
    {
        public List<NhaCungCap> layTatCaNhaCungCap()
        {
            List<NhaCungCap> arr = new List<NhaCungCap>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from NhaCungCap";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                NhaCungCap ncc = new NhaCungCap(dr["maNhaCungCap"] + "", dr["tenNhaCungCap"] + "", dr["diaChi"] + "", dr["soDienThoai"] + "");
                arr.Add(ncc);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }
    }
}
