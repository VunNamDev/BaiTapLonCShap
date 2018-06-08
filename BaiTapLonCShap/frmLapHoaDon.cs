using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
namespace BaiTapLonCShap
{
    public partial class frmLapHoaDon : Form
    {
        BULHoaDon BULHoaDon;
        BULHoaDonChiTiet BULHoaDonChiTiet;
        BULKhachHang BULKhachHang;
        BULNhanVien BULNhanVien;
        BULHang BULHang;
        int tongTien;
        int soHang;
        public frmLapHoaDon()
        {
            InitializeComponent();
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {

            txtNgayLap.Text = Convert.ToString( DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
            dataGridViewX1.Columns.Add("maHang","Mã Hàng");
            dataGridViewX1.Columns.Add("donGia", "Đơn Giá");
            dataGridViewX1.Columns.Add("soLuong", "Số Lượng");
            dataGridViewX1.Columns.Add("thanhTien", "Thành Tiền");


            while (true)
            {
                string ma = "HD";
                Random random = new Random();
                int n = random.Next(0, 100);
                ma = ma + n;
                if (!kiemTraMa(ma)) {
                    txtMaHoaDon.Text = ma;
                    break;
                }
               
                

            }

        }

        private bool kiemTraMa(string ma)
        {
            BULHoaDon = new BULHoaDon();
            foreach(HoaDon x in BULHoaDon.layds())
            {
                if (x.MaHoaDon == ma)
                    return true;
            }
            return false;
        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            BULKhachHang = new BULKhachHang();
            foreach(KhachHang x in BULKhachHang.layTatCaKhachHang())
            {
                if (x.MaKhachHang == txtMaKhachHang.Text)
                {
                    txtTenKhachHang.Text = x.HoTen;
                }
            }
           
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            BULNhanVien = new BULNhanVien();
            foreach(NhanVien x in BULNhanVien.laytatCaNhanVien())
            {
                if (x.MaNhanVien == txtMaNhanVien.Text)
                {
                    txtTenNhanVien.Text = x.HoTen;
                }
            }

        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            BULHang = new BULHang();
            foreach(Hang x in BULHang.layTatCaHang())
            {
                if (x.MaHang == txtMaHang.Text)
                {
                    txtDonGia.Text = Convert.ToString( x.DonGia);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (ktraHang() == false)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dataGridViewX1);
                    dataGridViewRow.Cells[0].Value = txtMaHang.Text;
                    dataGridViewRow.Cells[1].Value = Convert.ToString(txtDonGia.Text);
                    dataGridViewRow.Cells[2].Value = Convert.ToString(txtSoLuong.Text);
                    txtThanhTien.Text = Convert.ToString(Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text));
                    dataGridViewRow.Cells[3].Value = txtThanhTien.Text;
                    dataGridViewX1.Rows.Add(dataGridViewRow);
                    for (int i = 0; i < dataGridViewX1.RowCount; i++)
                    {

                        tongTien += Convert.ToInt32(dataGridViewX1.Rows[i].Cells[3].Value);

                    }

                    txtTongTien.Text = tongTien.ToString();
                    tongTien = 0;
                }
                else
                {

                    dataGridViewX1.Rows[soHang].Cells[2].Value = Convert.ToInt32(
                           txtSoLuong.Text) +
                           Convert.ToInt32(dataGridViewX1.Rows[soHang].Cells[2].Value);
                    txtThanhTien.Text = Convert.ToString(Convert.ToInt32(dataGridViewX1.Rows[soHang].Cells[2].Value) *
                      Convert.ToInt32(txtDonGia.Text));
                    dataGridViewX1.Rows[soHang].Cells[3].Value = txtThanhTien.Text;

                    for (int i = 0; i < dataGridViewX1.RowCount; i++)
                    {

                        tongTien += Convert.ToInt32(dataGridViewX1.Rows[i].Cells[3].Value);

                    }

                    txtTongTien.Text = tongTien.ToString();
                    tongTien = 0;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng kiểm tra Lại");
            }

            

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
          try
            {
                HoaDon hoaDon = new HoaDon(txtMaHoaDon.Text, txtMaKhachHang.Text, DateTime.Now.ToString("MM/dd/yyyy"),
              txtMaNhanVien.Text);
                BULHoaDon = new BULHoaDon();
                BULHoaDon.themHoaDon(hoaDon);

                themHoaDonChiTiet();
                MessageBox.Show("Thêm Hóa Đơn Thành Công");
            }
            catch (Exception)
            {
                MessageBox.Show("Vui Lòng Kiểm tra Lại");
            }
               
          
           
           
        }
        void themHoaDonChiTiet()
        {
            BULHoaDonChiTiet = new BULHoaDonChiTiet();
            for(int i = 0; i < dataGridViewX1.RowCount-1; i++)
            {
                HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet(txtMaHoaDon.Text,
                    dataGridViewX1.Rows[i].Cells[0].Value + "",
                   Convert.ToInt32( dataGridViewX1.Rows[i].Cells[2].Value + ""));
                BULHoaDonChiTiet.themHDCT(hoaDonChiTiet);
               
            }
            
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool ktraHang()
        {
            for(int i=0; i < dataGridViewX1.RowCount; i++)
            {
                if (txtMaHang.Text == dataGridViewX1.Rows[i].Cells[0].Value + "")
                {
                    soHang = i;

                    return true;
                }
            }
            return false;
        }
       
    }
}
