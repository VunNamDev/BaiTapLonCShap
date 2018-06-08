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
        public List<NhanVien> layNhanVienTheoMa(string s)
        {
            List<NhanVien> arr = new List<NhanVien>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from NhanVien where maNhanVien=@maNhanVien";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maNhanVien", s);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhanVien x = new NhanVien(dr["maNhanVien"] + "", dr["hoTen"] + "", dr["diaChi"] + "", dr["soDienThoai"].ToString());
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }
        public void themNhanVien(NhanVien nv)
        {
            KetNoiCSDL.moKetNoi();
            string them = "insert into NhanVien values (@maNhanVien,@hoTen,@diaChi,@soDienThoai)";
            SqlCommand cmd = new SqlCommand(them, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maNhanVien", nv.MaNhanVien);
            cmd.Parameters.AddWithValue("hoTen", nv.HoTen);
            cmd.Parameters.AddWithValue("diaChi", nv.DiaChi);
            cmd.Parameters.AddWithValue("soDienThoai", nv.SoDienThoai);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void suaNhanVien(NhanVien nv)
        {
            KetNoiCSDL.moKetNoi();
            string sua = "update NhanVien set hoTen=@hoTen,diaChi=@diaChi,soDienThoai=@soDienThoai where maNhanVien=@maNhanVien";
            SqlCommand cmd = new SqlCommand(sua, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maNhanVien", nv.MaNhanVien);
            cmd.Parameters.AddWithValue("hoTen", nv.HoTen);
            cmd.Parameters.AddWithValue("diaChi", nv.DiaChi);
            cmd.Parameters.AddWithValue("soDienThoai", nv.SoDienThoai);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void xoaNhanVien(NhanVien nv)
        {
            KetNoiCSDL.moKetNoi();
            string xoa = "delete from NhanVien where maNhanVien=@maNhanVien";
            SqlCommand cmd = new SqlCommand(xoa, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maNhanVien", nv.MaNhanVien);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
    }
}
