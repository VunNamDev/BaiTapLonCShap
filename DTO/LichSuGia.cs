using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichSuGia
    {
        private string maHang, ngayBatDau, ngayKetThuc;
        private float donGia;
        private string ngayCapNhat;

        public LichSuGia()
        {
            maHang = "";
            ngayBatDau = "";
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

        public string NgayBatDau
        {
            get
            {
                return ngayBatDau;
            }

            set
            {
                ngayBatDau = value;
            }
        }

        public string NgayKetThuc
        {
            get
            {
                return ngayKetThuc;
            }

            set
            {
                ngayKetThuc = value;
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

        public string NgayCapNhat
        {
            get
            {
                return ngayCapNhat;
            }

            set
            {
                ngayCapNhat = value;
            }
        }

        public LichSuGia(string maHang, string ngayBatDau, string ngayKetThuc, float donGia, string ngayCapNhat)
        {
            this.MaHang = maHang;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
            this.DonGia = donGia;
            this.NgayCapNhat = ngayCapNhat;
        }
    }
}
