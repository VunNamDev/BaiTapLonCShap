using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonChiTiet
    {
        private string maHoaDon;
        private string maHang;
        private int soLuong;

        public HoaDonChiTiet()
        {

        }
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

        public string MaHang
        {
            get
            {
                return maHang;
            }

            set
            {
                maHang = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public HoaDonChiTiet(string maHoaDon, string maHang, int soLuong)
        {
            this.MaHoaDon = maHoaDon;
            this.MaHang = maHang;
            this.SoLuong = soLuong;
        }
    }
}
