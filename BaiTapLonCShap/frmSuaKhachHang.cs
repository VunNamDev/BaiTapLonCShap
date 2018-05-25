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
        public event EventHandler tbnSua_Click;
        BULKhachHang kh = new BULKhachHang();

        public frmSuaKhachHang()
        {
            InitializeComponent();
        }
       
        private void txtMaKhachHang_TextChanged(object sender, EventArgs e)
        {
            
            if (kiemTraTonTai(txtMaKhachHang.Text)!=null)
            {
                KhachHang x = kiemTraTonTai(txtMaKhachHang.Text);
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
        private KhachHang kiemTraTonTai(string text)
        {
            foreach (KhachHang x in kh.layTatCaKhachHang())
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

        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang k = new KhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text, txtDiaChi.Text, txtSoDienThoai.Text);

            kh.X = k;
            kh.update();
            MessageBox.Show("Đã sửa thành công","Thông báo", MessageBoxButtons.OK);
            if (tbnSua_Click!=null)
                tbnSua_Click(sender, e);
            this.Close();
        }
    }
}
