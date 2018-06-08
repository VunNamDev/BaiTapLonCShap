using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private string maNhaCungCap;
        private string tenNhaCungCap;
        private string diaChi;
        private string soDienThoai;

        public NhaCungCap() { }
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

        public string TenNhaCungCap
        {
            get
            {
                return tenNhaCungCap;
            }

            set
            {
                tenNhaCungCap = value;
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

        public NhaCungCap(string maNhaCungCap, string tenNhaCungCap, string diaChi, string soDienThoai)
        {
            this.MaNhaCungCap = maNhaCungCap;
            this.TenNhaCungCap = tenNhaCungCap;
            this.DiaChi = diaChi;
            this.SoDienThoai = soDienThoai;
        }

        public NhaCungCap(string maNhaCungCap, string tenNhaCungCap)
        {
            this.MaNhaCungCap = maNhaCungCap;
            this.TenNhaCungCap = tenNhaCungCap;
        }
    }
}
