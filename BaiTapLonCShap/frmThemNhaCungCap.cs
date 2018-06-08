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
    public partial class frmThemNhaCungCap : Form
    {
        BULNhaCungCap bulncc = new BULNhaCungCap();
        public frmThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmThemNhaCungCap_Load(object sender, EventArgs e)
        {
            while (true)
            {
                string ma = "NCC";
                Random rd = new Random();
                int n = rd.Next(0, 100);
                ma = ma + n;
                if (!kiemTraMa(ma))
                {
                    txtMaNhaCungCap.Text = ma;
                    break;
                }
            }
        }
        private bool kiemTraMa(string ma)
        {
            foreach (NhaCungCap ncc in bulncc.layTatCaNhaCungCap())
            {
                if (ncc.MaNhaCungCap == ma)
                {
                    return true;
                }

            }
            return false;
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap(txtMaNhaCungCap.Text, txtTenNhaCungCap.Text, txtDiaChi.Text, txtSoDienThoai.Text);
            bulncc.themNhaCungCap(ncc);
            MessageBox.Show("Thêm Nhà Cung Cấp Thành Công", "Thêm Nhà Cung Cấp", MessageBoxButtons.OK);
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool textBoxRong()
        {
            if (txtMaNhaCungCap.Text == "" || txtTenNhaCungCap.Text == "" || txtDiaChi.Text == "" || txtSoDienThoai.Text == "")
            {
                return true;
            }
            return false;
        }

        private void txtTenNhaCungCap_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRong())
            {
                btnThemNhaCungCap.Enabled = true;
            }
            else
            {
                btnThemNhaCungCap.Enabled = false;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRong())
            {
                btnThemNhaCungCap.Enabled = true;
            }
            else
            {
                btnThemNhaCungCap.Enabled = false;
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRong())
            {
                btnThemNhaCungCap.Enabled = true;
            }
            else
            {
                btnThemNhaCungCap.Enabled = false;
            }
        }
    }
}
