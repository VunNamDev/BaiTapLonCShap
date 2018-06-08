using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO;
using DAL;
namespace DAL
{
   public class DALHoaDonChiTiet
    {

        public List<HoaDonChiTiet> layTatCHDCT()
        {
            List<HoaDonChiTiet> list = new List<HoaDonChiTiet>();
            KetNoiCSDL.moKetNoi();
            string get = " select * from HoaDonChiTiet";
            SqlCommand sqlCommand = new SqlCommand(get,KetNoiCSDL.connect);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet(sqlDataReader["maHoaDon"].ToString(),
                    sqlDataReader["maHang"].ToString(),Convert.ToInt32(
                        sqlDataReader["soLuong"]));
                list.Add(hoaDonChiTiet);
            }
            KetNoiCSDL.dongKetNoi();
            return list;
        }
        public void themHoaDonCT(HoaDonChiTiet hoaDonChiTiet)
        {


            List<HoaDonChiTiet> arr = new List<HoaDonChiTiet>();
            KetNoiCSDL.moKetNoi();
            string add = "insert into HoaDonChiTiet values (@maHoaDon, @maHang, @soLuong)";

            SqlCommand cmd = new SqlCommand(add, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHoaDon", hoaDonChiTiet.MaHoaDon);
            cmd.Parameters.AddWithValue("maHang", hoaDonChiTiet.MaHang);
            cmd.Parameters.AddWithValue("soLuong",hoaDonChiTiet.SoLuong);
            
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
    }
}
