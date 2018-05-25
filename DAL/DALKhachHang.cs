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
    public class DALKhachHang
    {
        public List<KhachHang> layKH()
        {
            List<KhachHang> arr = new List<KhachHang>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from KhachHang";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                KhachHang x = new KhachHang(dr["maKhachHang"]+"",dr["hoTen"]+"",dr["diaChi"] +"",dr["soDienThoai"]+"");
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }
        public void suaKhachHang(KhachHang kh)
        {
            List<KhachHang> arr = new List<KhachHang>();
            KetNoiCSDL.moKetNoi();
            string update = "update KhachHang set hoTen = @hoTen, diaChi = @diaChi, soDienThoai=@soDienThoai where maKhachHang=@maKhachHang ";

            SqlCommand cmd = new SqlCommand(update, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maKhachHang", kh.MaKhachHang);
            cmd.Parameters.AddWithValue("diaChi", kh.DiaChi);
            cmd.Parameters.AddWithValue("soDienThoai", kh.SoDienThoai);
            cmd.Parameters.AddWithValue("hoTen", kh.HoTen);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void themKhachHang(KhachHang kh)
        {
            List<KhachHang> arr = new List<KhachHang>();
            KetNoiCSDL.moKetNoi();
            string add = "insert into KhachHang values (@maKhachHang, @hoTen, @diaChi, @soDienThoai)";

            SqlCommand cmd = new SqlCommand(add, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maKhachHang", kh.MaKhachHang);
            cmd.Parameters.AddWithValue("diaChi", kh.DiaChi);
            cmd.Parameters.AddWithValue("soDienThoai", kh.SoDienThoai);
            cmd.Parameters.AddWithValue("hoTen", kh.HoTen);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void xoaKhachHang(KhachHang kh)
        {
            List<KhachHang> arr = new List<KhachHang>();
            KetNoiCSDL.moKetNoi();
            string update = "delete from KhachHang where maKhachHang=@maKhachHang ";

            SqlCommand cmd = new SqlCommand(update, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maKhachHang", kh.MaKhachHang);
            
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
    }
}
