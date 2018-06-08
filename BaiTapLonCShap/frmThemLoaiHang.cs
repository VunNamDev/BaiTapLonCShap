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
    public partial class frmThemLoaiHang : Form
    {
        public frmThemLoaiHang()
        {
            InitializeComponent();
        }

        BULLoaiHang bulLoaiHang = new BULLoaiHang();

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            LoaiHang loaiHang = new LoaiHang(txtMaLoai.Text, txtTenLoai.Text, txtGhiChu.Text);
            BULLoaiHang bulLoaiHang = new BULLoaiHang();
            DialogResult result = MessageBox.Show("Bạn có muốn thêm Loại hàng " + "'" + loaiHang.TenLoai + "' có mã '" + txtMaLoai.Text + "' vào dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bulLoaiHang.them(loaiHang);
                MessageBox.Show("Thêm thành công!");
            }
            this.Close();
        }

        private void frmThemLoaiHang_Load(object sender, EventArgs e)
        {
            while (true)
            {
                Random rd = new Random();
                string ma = "LH";
                int n = rd.Next(0, 1000);
                ma = ma + n;
                if (!kiemTraMaLoaiTonTai(ma))
                {
                    txtMaLoai.Text = ma;
                    break;
                }
            }
        }

        private bool kiemTraMaLoaiTonTai(string str)
        {
            foreach (LoaiHang item in bulLoaiHang.layTatCaLoaiHang())
            {
                if (item.MaLoai == str)
                {
                    return true;
                }
            }
            return false;
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
                btnThemLoaiHang.Enabled = false;
            }
            if (!kiemTraTextBoxRong(txtTenLoai) && !kiemTraTextBoxRong(txtGhiChu))
            {
                btnThemLoaiHang.Enabled = true;
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
