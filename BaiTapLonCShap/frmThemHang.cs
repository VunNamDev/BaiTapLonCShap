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
    public partial class frmThemHang : Form
    {
        BULHang bulHang = new BULHang();
        BULLoaiHang bulLoaiHang = new BULLoaiHang();
        BULNhaCungCap bulNhaCungCap = new BULNhaCungCap();

        public frmThemHang()
        {
            InitializeComponent();
        }

        public frmThemHang(Hang h)
        {
            InitializeComponent();
            txtMaHang.Text = h.MaHang;
        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            try
            {
                BULHang bulHang = new BULHang();
                Hang hang = new Hang(txtMaHang.Text, txtTenHang.Text,
                    txtDonViTinh.Text, float.Parse(txtDonGia.Text),
                    cboLoai.SelectedValue.ToString(), int.Parse(txtSoLuongCo.Text),
                    cboNCC.SelectedValue.ToString());
                DialogResult result = MessageBox.Show("Bạn có muốn Thêm hàng: " + txtMaHang.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bulHang.them(hang);
                    MessageBox.Show("Thêm hàng thành công!");
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thêm hàng không thành công!");
                this.Close();
            }
            
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmThemHang_Load(object sender, EventArgs e)
        {
            cboLoai.DataSource = bulLoaiHang.layDanhSachMaLoaiHang(txtMaHang.Text);
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";
            cboNCC.DataSource = bulNhaCungCap.layDanhSachMaNCC(txtMaHang.Text);
            cboNCC.DisplayMember = "TenNhaCungCap";
            cboNCC.ValueMember = "MaNhaCungCap";
            while (true)
            {
                Random rd = new Random();
                string ma = "MH";
                int n = rd.Next(0, 1000);
                ma = ma + n;
                if (!kiemTraTonTai(ma))
                {
                    txtMaHang.Text = ma;
                    break;
                }
            }
        }

        private bool kiemTraTonTai(string ma)
        {
            foreach (Hang item in bulHang.layTatCaHang())
            {
                if (item.MaHang == ma)
                {
                    return true;
                }
            }
            return false;
        }

        private bool kiemTraTextboxRong(TextBox text)
        {
            if (text.Text == "")
            {
                return true;
            }
            return false;
        }

        private void kiemTraTrangThai()
        {
            if (kiemTraTextboxRong(txtDonGia) || kiemTraTextboxRong(txtDonViTinh) || kiemTraTextboxRong(txtTenHang) || kiemTraTextboxRong(txtSoLuongCo))
            {
                btnThemHang.Enabled = false;
            }
            if (!kiemTraTextboxRong(txtDonGia) && !kiemTraTextboxRong(txtDonViTinh) && !kiemTraTextboxRong(txtTenHang) && !kiemTraTextboxRong(txtSoLuongCo))
            {
                btnThemHang.Enabled = true;
            }


        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
            kiemTraTrangThai();
        }

        private void txtDonViTinh_TextChanged(object sender, EventArgs e)
        {
            kiemTraTrangThai();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            kiemTraTrangThai();
        }

        private void txtSoLuongCo_TextChanged(object sender, EventArgs e)
        {
            kiemTraTrangThai();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
