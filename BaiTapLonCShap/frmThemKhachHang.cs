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
    public partial class frmThemKhachHang : Form
    {
       
        BULKhachHang bulKH = new BULKhachHang();

        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void frmThemKhachHang_Load(object sender, EventArgs e)
        {

            while(true)
            {
                Random rd = new Random();
                string ma = "KH";
                int n = rd.Next(0, 1000);
                ma = ma + n;
                if (!tonTaiMa(ma))
                {
                    txtMaKhachHang.Text = ma;
                    break;
                }
            }
        }

        private bool rong(TextBox x)
        {
            if(x.Text=="")
                return true;
            return false;
        }
        private bool tonTaiMa(string text)
        {
            foreach (KhachHang x in bulKH.layTatCaKhachHang())
            {
                if (x.MaKhachHang == text)
                {
                    return true;
                }
            }
            return false;
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            trangThaiBtnThem();
        }
        void trangThaiBtnThem()
        {
            if (rong(txtDiaChi) || rong(txtSoDienThoai) || rong(txtTenKhachHang))
            {
                btnThemKhachHang.Enabled = false;
            }
            if (!rong(txtDiaChi) && !rong(txtSoDienThoai) && !rong(txtTenKhachHang))
            {
                btnThemKhachHang.Enabled = true;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            trangThaiBtnThem();
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            trangThaiBtnThem();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang k = new KhachHang(txtMaKhachHang.Text, txtTenKhachHang.Text, txtDiaChi.Text, txtSoDienThoai.Text);


            bulKH.them(k);
            MessageBox.Show("Thêm khách hàng thành công","Thông báo",MessageBoxButtons.OK);
           
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn hủy thao tác thêm khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
