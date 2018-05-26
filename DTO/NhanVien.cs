using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string maNhanVien;
        private string hoTen;
        private string diaChi;
        private string soDienThoai;

        public NhanVien() { }
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

        public NhanVien(string maNhanVien, string hoTen, string diaChi, string soDienThoai)
        {
            this.MaNhanVien = maNhanVien;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
        }
    }
}
