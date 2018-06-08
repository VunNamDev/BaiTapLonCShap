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
        public List<NhaCungCap> layNhaCungCapTheoMa(string s)
        {
            List<NhaCungCap> arr = new List<NhaCungCap>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from NhaCungCap where maNhaCungCap=@maNhaCungCap";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maNhaCungCap", s);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhaCungCap ncc = new NhaCungCap(dr["maNhaCungCap"] + "", dr["tenNhaCungCap"] + "", dr["diaChi"] + "", dr["soDienThoai"].ToString());
                arr.Add(ncc);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }

        public List<NhaCungCap> danhSachMaNCC(string ma)
        {
            List<NhaCungCap> arr = new List<NhaCungCap>();
            KetNoiCSDL.moKetNoi();
            string get = "select NhaCungCap.maNhaCungCap, tenNhaCungCap from NhaCungCap";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NhaCungCap ncc = new NhaCungCap(dr["maNhaCungCap"] + "", dr["tenNhaCungCap"] + "");
                arr.Add(ncc);
            }
            arr.Count();
            KetNoiCSDL.dongKetNoi();
            return arr;
        }
        public void themNhaCungCap(NhaCungCap ncc)
        {
            KetNoiCSDL.moKetNoi();
            string them = "insert into NhaCungCap values (@maNhaCungCap,@tenNhaCungCap,@diaChi,@soDienThoai)";
            SqlCommand cmd = new SqlCommand(them, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maNhaCungCap", ncc.MaNhaCungCap);
            cmd.Parameters.AddWithValue("tenNhaCungCap", ncc.TenNhaCungCap);
            cmd.Parameters.AddWithValue("diaChi", ncc.DiaChi);
            cmd.Parameters.AddWithValue("soDienThoai", ncc.SoDienThoai);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void suaNhaCungCap(NhaCungCap ncc)
        {
            KetNoiCSDL.moKetNoi();
            string sua = "update NhaCungCap set tenNhaCungCap=@tenNhaCungCap,diaChi=@diaChi,soDienThoai=@soDienThoai where maNhaCungCap=@maNhaCungCap";
            SqlCommand cmd = new SqlCommand(sua, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maNhaCungCap", ncc.MaNhaCungCap);
            cmd.Parameters.AddWithValue("tenNhaCungCap", ncc.TenNhaCungCap);
            cmd.Parameters.AddWithValue("diaChi", ncc.DiaChi);
            cmd.Parameters.AddWithValue("soDienThoai", ncc.SoDienThoai);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void xoaNhaCungCap(NhaCungCap ncc)
        {
            KetNoiCSDL.moKetNoi();
            string xoa = "delete from NhaCungCap where maNhaCungCap=@maNhaCungCap";
            SqlCommand cmd = new SqlCommand(xoa, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maNhaCungCap", ncc.MaNhaCungCap);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
    }
}
