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
    public partial class frmXoaKhachHang : Form
    {
        KhachHang x = new KhachHang();
       
        BULKhachHang bulKH = new BULKhachHang();
        public frmXoaKhachHang()
        {
            InitializeComponent();
            x.MaKhachHang = "";
        }
        public frmXoaKhachHang(KhachHang x)
        {
            InitializeComponent();
            this.x = x;
        }

        private void frmXoaKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = x.MaKhachHang;
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

        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            if (tonTaiKhachHang(txtMaKhachHang.Text) != null)
            {
                KhachHang x = tonTaiKhachHang(txtMaKhachHang.Text);
                txtDiaChi.Text = x.DiaChi;
                txtSoDienThoai.Text = x.SoDienThoai;
                txtTenKhachHang.Text = x.HoTen;
                btnXoaKhachHang.Enabled = true;

            }
            else
            {
                txtDiaChi.Text = "";
                txtSoDienThoai.Text = "";
                txtTenKhachHang.Text = "";
                btnXoaKhachHang.Enabled = false;
            }
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang kh1  = new KhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text, txtDiaChi.Text, txtSoDienThoai.Text);

            DialogResult dl = MessageBox.Show("Xoá khách hàng: " + txtMaKhachHang.Text + " - " + txtTenKhachHang.Text,
                "Xoá",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dl==DialogResult.Yes)
            {
                bulKH.xoa(kh1);
                
                this.Close();
            }

            
        }
    }
}
