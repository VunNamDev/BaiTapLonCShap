using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHang
    {
        private string maLoai;
        private string tenLoai;
        private string ghiChu;

        public LoaiHang() { }
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

        public string TenLoai
        {
            get
            {
                return tenLoai;
            }

            set
            {
                tenLoai = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public LoaiHang(string maLoai, string tenLoai, string ghiChu)
        {
            this.MaLoai = maLoai;
            this.TenLoai = tenLoai;
            this.GhiChu = ghiChu;
        }
    }
}
