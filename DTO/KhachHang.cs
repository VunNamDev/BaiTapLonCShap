using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        private string maKhachHang, hoTen, diaChi, soDienThoai;
        public KhachHang()
        {
           
        }

        public KhachHang(string maKhachHang, string hoTen, string diaChi, string soDienThoai)
        {
            this.MaKhachHang = maKhachHang;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
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

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }
    }
}
