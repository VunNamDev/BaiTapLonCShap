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
    public partial class frmXoaLoaiHang : Form
    {
        public frmXoaLoaiHang()
        {
            InitializeComponent();
        }

        public frmXoaLoaiHang(LoaiHang lh)
        {
            InitializeComponent();
            txtMaLoai.Text = lh.MaLoai;
        }

        BULLoaiHang bulLoaiHang = new BULLoaiHang();
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
        private void btnXoaLoaiHang_Click(object sender, EventArgs e)
        {
            BULLoaiHang bulLoaiHang = new BULLoaiHang();
            LoaiHang loaiHang = new LoaiHang(txtMaLoai.Text);
            DialogResult result = MessageBox.Show("Bạn có muốn xóa Loại hàng: " + txtMaLoai.Text + " ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bulLoaiHang.xoa(loaiHang);
                MessageBox.Show("Đã xóa thành công");
            }
            this.Close();

        }

        private void txtMaLoai_TextChanged(object sender, EventArgs e)
        {
            if (kiemTraTonTai(txtMaLoai.Text) != null)
            {
                LoaiHang lh = kiemTraTonTai(txtMaLoai.Text);
                txtTenLoai.Text = lh.TenLoai;
                txtGhiChu.Text = lh.GhiChu;

                txtTenLoai.Enabled = false;
                txtGhiChu.Enabled = false;
                btnXoaLoaiHang.Enabled = true;
            }
            else
            {
                txtTenLoai.Text = "";
                txtGhiChu.Text = "";
                btnXoaLoaiHang.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
