using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
namespace DAL
{
  public  class DALHoaDon
    {
        public List<HoaDon> layTatCHD()
        {
            List<HoaDon> list = new List<HoaDon>();
            KetNoiCSDL.moKetNoi();
            string get = " select * from HoaDon";
            SqlCommand sqlCommand = new SqlCommand(get, KetNoiCSDL.connect);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                HoaDon hoaDon = new HoaDon(sqlDataReader["maHoaDon"].ToString(),
                    sqlDataReader["maKhachHang"].ToString(),
                        sqlDataReader["ngayLap"].ToString(),sqlDataReader["maNhanVien"].ToString());
                list.Add(hoaDon);
            }
            KetNoiCSDL.dongKetNoi();
            return list;
        }
        public void themHoaDon(HoaDon hoaDon)
        {
        
            KetNoiCSDL.moKetNoi();
            string add = "insert into HoaDon values (@maHoaDon, @maKhachHang, @ngayLap, @maNhanVien)";

            SqlCommand cmd = new SqlCommand(add, KetNoiCSDL.connect);
            cmd.Parameters.AddWithValue("maHoaDon",hoaDon.MaHoaDon);
            cmd.Parameters.AddWithValue("maKhachHang", hoaDon.MaKhachHang);
            cmd.Parameters.AddWithValue("ngayLap", hoaDon.NgayLap);
            cmd.Parameters.AddWithValue("maNhanVien",hoaDon.MaNhanVien);
            cmd.ExecuteNonQuery();
            KetNoiCSDL.dongKetNoi();
        }
        public DataTable inHoaDon()
        {
            string get = "select  HoaDon.maHoaDon, HoaDon.maKhachHang, KhachHang.hoTen,HoaDon.ngayLap,HoaDon.maNhanVien,NhanVien.hoTen,HoaDonChiTiet.maHang,Hang.donGia,HoaDonChiTiet.soLuong,HoaDonChiTiet.soLuong*Hang.donGia as 'thanh tien' from HoaDon inner join HoaDonChiTiet on HoaDonChiTiet.maHoaDon=HoaDon.maHoaDon	inner join Hang on Hang.maHang=HoaDonChiTiet.maHang	 inner join KhachHang on HoaDon.maKhachHang=KhachHang.maKhachHang	 inner join NhanVien on NhanVien.maNhanVien=HoaDon.maNhanVien group by 	 HoaDon.maHoaDon, HoaDon.maKhachHang, KhachHang.hoTen,HoaDon.ngayLap,HoaDon.maNhanVien,NhanVien.hoTen,HoaDonChiTiet.maHang,Hang.donGia,HoaDonChiTiet.soLuong";
            KetNoiCSDL.moKetNoi();
            SqlCommand sqlCommand = new SqlCommand(get,KetNoiCSDL.connect);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            KetNoiCSDL.dongKetNoi();
            return dataTable;
            
        }

        public DataTable timHoaDon(HoaDon hoaDon)
        {
            string get = "select  HoaDon.maHoaDon, HoaDon.maKhachHang, KhachHang.hoTen,HoaDon.ngayLap,HoaDon.maNhanVien,NhanVien.hoTen,HoaDonChiTiet.maHang,Hang.donGia,HoaDonChiTiet.soLuong,HoaDonChiTiet.soLuong*Hang.donGia as 'thanh tien' from HoaDon inner join HoaDonChiTiet on HoaDonChiTiet.maHoaDon=HoaDon.maHoaDon	inner join Hang on Hang.maHang=HoaDonChiTiet.maHang	 inner join KhachHang on HoaDon.maKhachHang=KhachHang.maKhachHang	 inner join NhanVien on NhanVien.maNhanVien=HoaDon.maNhanVien  where HoaDon.maHoaDon=@maHoaDon group by 	 HoaDon.maHoaDon, HoaDon.maKhachHang, KhachHang.hoTen,HoaDon.ngayLap,HoaDon.maNhanVien,NhanVien.hoTen,HoaDonChiTiet.maHang,Hang.donGia,HoaDonChiTiet.soLuong";
            KetNoiCSDL.moKetNoi();
            SqlCommand sqlCommand = new SqlCommand(get,KetNoiCSDL.connect);
            sqlCommand.Parameters.AddWithValue("maHoaDon", hoaDon.MaHoaDon);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);
            KetNoiCSDL.dongKetNoi();
            return dataTable;

        }
    }
}
