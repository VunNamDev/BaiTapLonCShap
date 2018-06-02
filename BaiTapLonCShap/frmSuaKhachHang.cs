using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;
namespace BaiTapLonCShap
{
   
    public partial class frmSuaKhachHang : Form
    {
        BULKhachHang bulKH = new BULKhachHang();
        KhachHang k = new KhachHang();
     
        public frmSuaKhachHang()
        {
            k.MaKhachHang = "";
            InitializeComponent();
        }
        public frmSuaKhachHang(KhachHang k)
        {
            InitializeComponent();
            this.k = k;
        }

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            
            if (tonTaiKhachHang(txtMaKhachHang.Text)!=null)
            {
                KhachHang x = tonTaiKhachHang(txtMaKhachHang.Text);
                txtDiaChi.Text = x.DiaChi;
                txtSoDienThoai.Text = x.SoDienThoai;
                txtTenKhachHang.Text = x.HoTen;
                btnSuaKhachHang.Enabled = true;
                
            }
            else
            {
                txtDiaChi.Text = "";
                txtSoDienThoai.Text = "";
                txtTenKhachHang.Text = "";
                btnSuaKhachHang.Enabled = false;
            }

        }
        private KhachHang tonTaiKhachHang(string text)
        {
            foreach (KhachHang x in bulKH.layTatCaKhachHang())
            {
                if (x.MaKhachHang == text)
                {
                    return x;
                }
            }
            return null;
        }
     
        private void frmSuaKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = k.MaKhachHang;
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang k = new KhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text, txtDiaChi.Text, txtSoDienThoai.Text);
            bulKH.sua(k);
            MessageBox.Show("Đã sửa thành công","Thông báo", MessageBoxButtons.OK);
           
            this.Close();
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            trangThaiBtnSua();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            trangThaiBtnSua();
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            trangThaiBtnSua();
        }
        private bool rong(TextBox x)
        {
            if (x.Text == "")
                return true;
            return false;
        }
        void trangThaiBtnSua()
        {
            if (rong(txtDiaChi) || rong(txtSoDienThoai) || rong(txtTenKhachHang))
            {
                btnSuaKhachHang.Enabled = false;
            }
            if (!rong(txtDiaChi) && !rong(txtSoDienThoai) && !rong(txtTenKhachHang))
            {
                btnSuaKhachHang.Enabled = true;
            }
        }
    }
}
