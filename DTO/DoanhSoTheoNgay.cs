using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoanhSoTheoNgay
    {
        private string stt;
        private string ngayLap;
        private float tongTien;

        public string Stt
        {
            get
            {
                return stt;
            }

            set
            {
                stt = value;
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

        public float TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }

        public DoanhSoTheoNgay()
        {

        }

        public DoanhSoTheoNgay(string stt, string ngayLap, float tongTien)
        {
            this.Stt = stt;
            this.NgayLap = ngayLap;
            this.TongTien = tongTien;
        }
    }
}
