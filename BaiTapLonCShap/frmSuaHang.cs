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
    public partial class frmSuaHang : Form
    {
        public frmSuaHang()
        {
            InitializeComponent();
        }

        public frmSuaHang(Hang h)
        {
            InitializeComponent();
            txtMaHang.Text = h.MaHang;
        }

        BULHang bulHang = new BULHang();
        BULLoaiHang bulLoaiHang = new BULLoaiHang();
        BULNhaCungCap bulNhaCungCap = new BULNhaCungCap();


        private Hang kiemTraTonTai(string ma)
        {
            foreach (Hang item in bulHang.layTatCaHang())
            {
                if (item.MaHang == ma)
                {
                    return item;
                }
            }
            return null;
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            try
            {
                BULHang bulHang = new BULHang();
                Hang hang = new Hang(txtMaHang.Text, txtTenHang.Text,
                    txtDonViTinh.Text, float.Parse(txtDonGia.Text),
                    cboLoai.SelectedValue.ToString(), int.Parse(txtSoLuongCo.Text),
                    cboNCC.SelectedValue.ToString());
                DialogResult result = MessageBox.Show("Bạn có muốn Sửa hàng: " + txtMaHang.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bulHang.sua(hang);
                    MessageBox.Show("Sửa hàng thành công!");
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sửa hàng thất bại!");
                this.Close();
            }
            
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            if (kiemTraTonTai(txtMaHang.Text) != null)
            {
                Hang h = kiemTraTonTai(txtMaHang.Text);

                txtTenHang.Text = h.TenHang;
                txtDonViTinh.Text = h.DonViTinh;
                txtDonGia.Text = h.DonGia.ToString();

                cboLoai.DataSource = bulLoaiHang.layDanhSachMaLoaiHang(txtMaHang.Text);
                cboLoai.DisplayMember = "TenLoai";
                cboLoai.ValueMember = "MaLoai";
                int vt = -1;
                for (int i = 0; i < bulLoaiHang.layDanhSachMaLoaiHang(txtMaHang.Text).Count; i++)
                {
                    if (bulLoaiHang.layDanhSachMaLoaiHang(txtMaHang.Text)[i].MaLoai.Contains(h.MaLoai))
                    {
                        vt = i;
                        break;
                    }
                }
                cboLoai.SelectedIndex = vt;
                txtSoLuongCo.Text = h.SoLuongCo.ToString();
                cboNCC.DataSource = bulNhaCungCap.layDanhSachMaNCC(txtMaHang.Text);
                cboNCC.DisplayMember = "TenNhaCungCap";
                cboNCC.ValueMember = "MaNhaCungCap";
                for (int i = 0; i < bulNhaCungCap.layDanhSachMaNCC(txtMaHang.Text).Count; i++)
                {
                    if (bulNhaCungCap.layDanhSachMaNCC(txtMaHang.Text)[i].MaNhaCungCap.Contains(h.MaNhaCungCap))
                    {
                        vt = i;
                        break;
                    }
                }
                cboNCC.SelectedIndex = vt;

                btnSuaHang.Enabled = true;
            }
            else
            {
                Hang h = kiemTraTonTai(txtMaHang.Text);

                txtTenHang.Text = "";
                txtDonViTinh.Text = "";
                txtDonGia.Text = "";
                //cboLoai.SelectedValue = "";
                txtSoLuongCo.Text = "";
                //cboNCC.SelectedValue = "";
                btnSuaHang.Enabled = false;
            }
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
                btnSuaHang.Enabled = false;
            }
            if (!kiemTraTextboxRong(txtDonGia) && !kiemTraTextboxRong(txtDonViTinh) && !kiemTraTextboxRong(txtTenHang) && !kiemTraTextboxRong(txtSoLuongCo))
            {
                btnSuaHang.Enabled = true;
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
