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
        public List<LichSuGia> layLSGCoDieuKien(string  s)
        {
            List<LichSuGia> arr = new List<LichSuGia>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from LichSuGia where maHang=@maHang ";

            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHang", s);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                LichSuGia x = new LichSuGia(dr["maHang"] + "", ((DateTime)dr["ngayBatDau"]).ToString("dd/MM/yyyy"), ((DateTime)dr["ngayKetThuc"]).ToString("dd/MM/yyyy"),
                    float.Parse(dr["donGia"] + ""), ((DateTime)dr["ngayCapNhat"]).ToString("dd/MM/yyyy"));
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }

        public LichSuGia KiemTraTonTai(LichSuGia ls)
        {
            LichSuGia x = new LichSuGia();
            KetNoiCSDL.moKetNoi();
            string get = "select * from LichSuGia where maHang=@maHang and ngayBatDau=@ngayBatDau ";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHang", ls.MaHang);
            cmd.Parameters.AddWithValue("ngayBatDau", ls.NgayBatDau);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                x = new LichSuGia(dr["maHang"] + "", ((DateTime)dr["ngayBatDau"]).ToString("dd/MM/yyyy"), ((DateTime)dr["ngayKetThuc"]).ToString("dd/MM/yyyy"),
                    float.Parse(dr["donGia"] + ""), ((DateTime)dr["ngayCapNhat"]).ToString("dd/MM/yyyy"));
                
            }
            KetNoiCSDL.dongKetNoi();
            return x;
        }
        public void themLichSuGia(LichSuGia ls)
        {
            
            KetNoiCSDL.moKetNoi();
            string add = "insert into LichSuGia values (@maHang, @ngayBatDau, @ngayKetThuc, @donGia, @ngayCapNhat)";

            SqlCommand cmd = new SqlCommand(add, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHang", ls.MaHang);
            cmd.Parameters.AddWithValue("ngayBatDau", (ls.NgayBatDau));
            cmd.Parameters.AddWithValue("ngayKetThuc", ls.NgayKetThuc);
            cmd.Parameters.AddWithValue("donGia", ls.DonGia);
            cmd.Parameters.AddWithValue("ngayCapNhat", ls.NgayCapNhat);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }

        public void suaLichSuGia(LichSuGia lsg)
        {
            KetNoiCSDL.moKetNoi();
            string update = "update LichSuGia set ngayKetThuc = @ngayKetThuc, donGia = @donGia, ngayCapNhat=@ngayCapNhat where maHang=@maHang and ngayBatDau=@ngayBatDau ";

            SqlCommand cmd = new SqlCommand(update, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("ngayKetThuc", lsg.NgayKetThuc);
            cmd.Parameters.AddWithValue("donGia", lsg.DonGia);
            cmd.Parameters.AddWithValue("ngayCapNhat", lsg.NgayCapNhat);
            cmd.Parameters.AddWithValue("maHang", lsg.MaHang);
            cmd.Parameters.AddWithValue("ngayBatDau", lsg.NgayBatDau);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void xoaLichSuGia(LichSuGia lsg)
        {
            KetNoiCSDL.moKetNoi();
            string del = "delete from LichSuGia where  maHang=@maHang and ngayBatDau=@ngayBatDau ";
            SqlCommand cmd = new SqlCommand(del, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHang", lsg.MaHang);
            cmd.Parameters.AddWithValue("ngayBatDau", lsg.NgayBatDau);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
    }
}
