using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
namespace DAL
{
    public class DALLichSuGia
    {
        public List<LichSuGia> layLSG()
        {
            List<LichSuGia> arr = new List<LichSuGia>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from LichSuGia";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                
                LichSuGia x = new LichSuGia(dr["maHang"] + "",((DateTime)dr["ngayBatDau"]).ToString("dd/MM/yyyy"), ((DateTime)dr["ngayKetThuc"]).ToString("dd/MM/yyyy"),
                    float.Parse(dr["donGia"] + ""), ((DateTime)dr["ngayCapNhat"]).ToString("dd/MM/yyyy"));
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }
    }
}
