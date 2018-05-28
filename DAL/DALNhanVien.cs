using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAL
{
    public class DALNhanVien
    {
        public List<NhanVien> layTatCaNhanVien()
        {
            List<NhanVien> arr = new List<NhanVien>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                NhanVien nv = new NhanVien(dr["maNhanVien"] + "", dr["hoTen"] + "", dr["diaChi"] + "", dr["soDienThoai"] + "");
                arr.Add(nv);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }
    }
}
