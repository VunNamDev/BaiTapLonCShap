using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon
    {
        private string maHoaDon;
        private string maKhachHang;
        private string ngayLap;
        private string maNhanVien;

        public HoaDon() { }
        public string MaHoaDon
        {
            get
            {
                return maHoaDon;
            }

            set
            {
                maHoaDon = value;
            }
        }

        public string MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        public string NgayLap
        {
            get
            {
                return ngayLap;
            }

            set
            {
                ngayLap = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }

        public HoaDon(string maHoaDon, string maKhachHang, string ngayLap, string maNhanVien)
        {
            this.MaHoaDon = maHoaDon;
            this.MaKhachHang = maKhachHang;
            this.NgayLap = ngayLap;
            this.MaNhanVien = maNhanVien;
        }
    }
}
