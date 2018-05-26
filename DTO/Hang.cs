using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hang
    {
        private string maHang;
        private string tenHang;
        private string donViTinh;
        private float donGia;
        private string maLoai;
        private int soLuongCo;
        private string maNhaCungCap;
        
        public Hang() { }
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

        public string TenHang
        {
            get
            {
                return tenHang;
            }

            set
            {
                tenHang = value;
            }
        }

        public string DonViTinh
        {
            get
            {
                return donViTinh;
            }

            set
            {
                donViTinh = value;
            }
        }

        public float DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        public string MaLoai
        {
            get
            {
                return maLoai;
            }

            set
            {
                maLoai = value;
            }
        }

        public int SoLuongCo
        {
            get
            {
                return soLuongCo;
            }

            set
            {
                soLuongCo = value;
            }
        }

        public string MaNhaCungCap
        {
            get
            {
                return maNhaCungCap;
            }

            set
            {
                maNhaCungCap = value;
            }
        }

        public Hang(string maHang, string tenHang, string donViTinh, float donGia, string maLoai, int soLuongCo, string maNhaCungCap)
        {
            this.MaHang = maHang;
            this.TenHang = tenHang;
            this.DonViTinh = donViTinh;
            this.DonGia = donGia;
            this.MaLoai = maLoai;
            this.SoLuongCo = soLuongCo;
            this.MaNhaCungCap = maNhaCungCap;
        }
    }
}
