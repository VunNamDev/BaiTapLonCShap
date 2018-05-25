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
        public event EventHandler btnXoa_click;
        BULKhachHang bulKH = new BULKhachHang();
        public frmXoaKhachHang()
        {
            InitializeComponent();
        }

        private void frmXoaKhachHang_Load(object sender, EventArgs e)
        {

        }
        private KhachHang kiemTraTonTai(string text)
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
            if (kiemTraTonTai(txtMaKhachHang.Text) != null)
            {
                KhachHang x = kiemTraTonTai(txtMaKhachHang.Text);
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
            bulKH.X = new KhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text, txtDiaChi.Text, txtSoDienThoai.Text);

            DialogResult dl = MessageBox.Show("Xoá khách hàng: " + txtMaKhachHang.Text + " - " + txtTenKhachHang.Text,
                "Xoá",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dl==DialogResult.Yes)
            {
                bulKH.delete();
                if (btnXoa_click != null)
                {
                    btnXoa_click(sender, e);
                }
                this.Close();
            }

            
        }
    }
}
