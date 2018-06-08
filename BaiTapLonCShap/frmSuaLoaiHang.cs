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
    public partial class frmSuaLoaiHang : Form
    {
        public frmSuaLoaiHang()
        {
            InitializeComponent();
        }
        public frmSuaLoaiHang(LoaiHang lh)
        {
            InitializeComponent();
            txtMaLoai.Text = lh.MaLoai;
        }

        BULLoaiHang bulLoaiHang = new BULLoaiHang();

        private void btnSuaLoaiHang_Click(object sender, EventArgs e)
        {
            LoaiHang loaiHang = new LoaiHang(txtMaLoai.Text, txtTenLoai.Text, txtGhiChu.Text);
            BULLoaiHang bulLoaiHang = new BULLoaiHang();
            DialogResult result = MessageBox.Show("Bạn có muốn sửa Loại hàng " +
                txtMaLoai.Text + "? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bulLoaiHang.sua(loaiHang);
                MessageBox.Show("Sửa thành công!");
            }
            this.Close();
        }

        private LoaiHang kiemTraTonTai(string str)
        {
            foreach (LoaiHang item in bulLoaiHang.layTatCaLoaiHang())
            {
                if (item.MaLoai == str)
                {
                    return item;
                }
            }
            return null;
        }
        private bool kiemTraTextBoxRong(TextBox text)
        {
            if (text.Text == "")
            {
                return true;
            }
            return false;
        }

        private void kiemTraTrangThai()
        {
            if (kiemTraTextBoxRong(txtTenLoai) || kiemTraTextBoxRong(txtGhiChu))
            {
                btnSuaLoaiHang.Enabled = false;
            }
            if (!kiemTraTextBoxRong(txtTenLoai) && !kiemTraTextBoxRong(txtGhiChu))
            {
                btnSuaLoaiHang.Enabled = true;
            }
        }

        private void txtTenLoai_TextChanged(object sender, EventArgs e)
        {
            kiemTraTrangThai();
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            kiemTraTrangThai();
        }

        private void txtMaLoai_TextChanged(object sender, EventArgs e)
        {
            if (kiemTraTonTai(txtMaLoai.Text) != null)
            {
                LoaiHang lh = kiemTraTonTai(txtMaLoai.Text);
                txtTenLoai.Text = lh.TenLoai;
                txtGhiChu.Text = lh.GhiChu;
                btnSuaLoaiHang.Enabled = true;
            }
            else
            {

                txtTenLoai.Text = "";
                txtGhiChu.Text = "";
                btnSuaLoaiHang.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
