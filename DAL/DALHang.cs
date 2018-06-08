using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
namespace DAL
{
    public class DALHang
    {
        
        public List<Hang> layHang()
        {
            List<Hang> arr = new List<Hang>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from Hang";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Hang x = new Hang(dr["maHang"] + "", dr["tenHang"] + "", dr["donViTinh"] + "",
                    float.Parse(dr["donGia"] + ""), dr["maLoai"] + "",int.Parse(dr["soLuongCo"] + ""),
                    dr["maNhaCungCap"] + "");
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }
        public List<DoanhSoTheoNgay> layDoanhSo(string thang, string nam)
        {
            List<DoanhSoTheoNgay> arr = new List<DoanhSoTheoNgay>();
            KetNoiCSDL.moKetNoi();
            string get = "SELECT ngayLap,SUM(soLuong*donGia) as 'gia' FROM HoaDon inner join HoaDonChiTiet on HoaDon.maHoaDon = HoaDonChiTiet.maHoaDon inner join Hang on Hang.maHang = HoaDonChiTiet.maHang where MONTH(ngayLap) = @thang and YEAR(ngayLap) = @nam group by ngayLap";

            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("thang", int.Parse(thang));
            cmd.Parameters.AddWithValue("nam", int.Parse(nam));

            SqlDataReader dr = cmd.ExecuteReader();
            int stt = 1;
            while (dr.Read())
            {
                DoanhSoTheoNgay ds = new DoanhSoTheoNgay(stt +"", ((DateTime)dr["ngayLap"]).ToString("dd/MM/yyyy"), float.Parse(dr["gia"] + ""));
                arr.Add(ds);
                stt++;
            }
            KetNoiCSDL.dongKetNoi();

            return arr;
        }

        public string maHang()
        {
            string ma = "";
            KetNoiCSDL.moKetNoi();
            string sql = "select Hang.maHang from Hang";
            SqlCommand cmd = new SqlCommand(sql, KetNoiCSDL.connect);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ma = dr["maHang"].ToString();
            }
            KetNoiCSDL.dongKetNoi();
            return ma;
        }
        
        public void themHang(Hang h)
        {
            string sqlSelect = "insert into Hang values(@maHang, @tenHang, @donViTinh, @donGia, @maLoai, @soLuongCo, @maNhaCungCap)";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlSelect, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHang", h.MaHang);
            cmd.Parameters.AddWithValue("tenHang", h.TenHang);
            cmd.Parameters.AddWithValue("donViTinh", h.DonViTinh);
            cmd.Parameters.AddWithValue("donGia", h.DonGia);
            cmd.Parameters.AddWithValue("maLoai", h.MaLoai);
            cmd.Parameters.AddWithValue("soLuongCo", h.SoLuongCo);
            cmd.Parameters.AddWithValue("maNhaCungCap", h.MaNhaCungCap);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void suaHang(Hang h)
        {
            string sqlUpdate = "update Hang set  tenHang=@tenHang, donViTinh=@donViTinh, donGia=@donGia, maLoai=@maLoai, soLuongCo=@soLuongCo, maNhaCungCap=@maNhaCungCap where maHang=@maHang";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHang", h.MaHang);
            cmd.Parameters.AddWithValue("tenHang", h.TenHang);
            cmd.Parameters.AddWithValue("donViTinh", h.DonViTinh);
            cmd.Parameters.AddWithValue("donGia", h.DonGia);
            cmd.Parameters.AddWithValue("maLoai", h.MaLoai);
            cmd.Parameters.AddWithValue("soLuongCo", h.SoLuongCo);
            cmd.Parameters.AddWithValue("maNhaCungCap", h.MaNhaCungCap);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public void xoaHang(Hang h)
        {
            string sqlUpdate = "delete from Hang where maHang=@maHang";
            KetNoiCSDL.moKetNoi();
            SqlCommand cmd = new SqlCommand(sqlUpdate, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHang", h.MaHang);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }

        public List<Hang> timHang(Hang h)
        {
            List<Hang> arr = new List<Hang>();
            KetNoiCSDL.moKetNoi();
            string get = "select * from Hang where maHang=@maHang";
            SqlCommand cmd = new SqlCommand(get, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHang", h.MaHang);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Hang x = new Hang(dr["maHang"] + "", dr["tenHang"] + "", dr["donViTinh"] + "",
                    float.Parse(dr["donGia"] + ""), dr["maLoai"] + "", int.Parse(dr["soLuongCo"] + ""),
                    dr["maNhaCungCap"] + "");
                arr.Add(x);
            }
            KetNoiCSDL.dongKetNoi();
            return arr;
        }
    }
}
