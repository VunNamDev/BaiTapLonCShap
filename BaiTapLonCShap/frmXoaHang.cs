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
    public partial class frmXoaHang : Form
    {
        BULHang bulHang = new BULHang();
        BULLoaiHang bulLoaiHang = new BULLoaiHang();
        BULNhaCungCap bulNhaCungCap = new BULNhaCungCap();

        public frmXoaHang()
        {
            InitializeComponent();
        }
        public frmXoaHang(Hang h)
        {
            InitializeComponent();
            txtMaHang.Text = h.MaHang;
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            BULHang bulHang = new BULHang();
            Hang hang = new Hang(txtMaHang.Text);
            DialogResult result = MessageBox.Show("Bạn có muốn xóa hàng " + txtMaHang.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bulHang.xoa(hang);
                MessageBox.Show("Đã xóa thàng công!");
            }
            this.Close();
        }

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

                txtTenHang.Enabled = false;
                txtDonViTinh.Enabled = false;
                txtDonGia.Enabled = false;
                cboLoai.Enabled = false;
                txtSoLuongCo.Enabled = false;
                cboNCC.Enabled = false;
                btnXoaHang.Enabled = true;
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
                btnXoaHang.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
