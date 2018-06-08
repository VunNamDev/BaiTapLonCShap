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

        public List<LoaiHang> danhSachMaLoaiHang(string ma)
        {
            List<LoaiHang> list = new List<LoaiHang>();
            KetNoiCSDL.moKetNoi();
            string sql = "select LoaiHang.maLoai, tenLoai from LoaiHang";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("ma", ma);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoaiHang lh = new LoaiHang(dr["maLoai"].ToString(), dr["tenLoai"].ToString());
                list.Add(lh);
            }
            KetNoiCSDL.dongKetNoi();
            list.Count();
            return list;
        }

        public void themLoaiHang(LoaiHang lh)
        {
            string sqlSelect = "insert into LoaiHang values(@maLoai, @tenLoai, @ghiChu)";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlSelect, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maLoai", lh.MaLoai);
            cmd.Parameters.AddWithValue("tenLoai", lh.TenLoai);
            cmd.Parameters.AddWithValue("ghiChu", lh.GhiChu);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void suaLoaiHang(LoaiHang lh)
        {
            string sqlUpdate = "update LoaiHang set  tenLoai=@tenLoai, ghiChu=@ghiChu where maLoai=@maLoai";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maLoai", lh.MaLoai);
            cmd.Parameters.AddWithValue("tenLoai", lh.TenLoai);
            cmd.Parameters.AddWithValue("ghiChu", lh.GhiChu);;
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void xoaLoaiHang(LoaiHang lh)
        {
            string sqlUpdate = "delete from LoaiHang where maLoai=@maLoai";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maLoai", lh.MaLoai);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }

        public List<LoaiHang> timLoaiHang(LoaiHang lh)
        {
            List<LoaiHang> arr = new List<LoaiHang>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from LoaiHang where maLoai=@maLoai";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maLoai", lh.MaLoai);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                LoaiHang loaiHang = new LoaiHang(dr["maLoai"].ToString(), dr["tenLoai"].ToString(), dr["ghiChu"].ToString());
                arr.Add(loaiHang);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }
    }
}
