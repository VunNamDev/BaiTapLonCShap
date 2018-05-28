using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
namespace DAL
{
    public class DALLoaiHang
    {
        public List<LoaiHang> layTatCaLoaiHang()
        {
            List<LoaiHang> arr = new List<LoaiHang>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from LoaiHang";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                LoaiHang lh = new LoaiHang(dr["maLoai"] + "", dr["tenLoai"] + "", dr["ghiChu"] + "");
                arr.Add(lh);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }
    }
}
