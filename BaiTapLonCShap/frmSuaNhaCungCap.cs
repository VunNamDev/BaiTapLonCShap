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
    public partial class frmSuaNhaCungCap : Form
    {
        BULNhaCungCap bulncc = new BULNhaCungCap();
        public frmSuaNhaCungCap()
        {
            InitializeComponent();
        }
        public frmSuaNhaCungCap(NhaCungCap ncc)
        {
            InitializeComponent();
            txtMaNhaCungCap.Text = ncc.MaNhaCungCap;
        }
        bool textBoxRong()
        {
            if (txtMaNhaCungCap.Text == "" || txtTenNhaCungCap.Text == "" || txtDiaChi.Text == "" || txtSoDienThoai.Text == "")
            {
                return true;
            }
            return false;
        }
        private void frmSuaNhaCungCap_Load(object sender, EventArgs e)
        {

        }

        private void btnSuaNhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap(txtMaNhaCungCap.Text, txtTenNhaCungCap.Text, txtDiaChi.Text, txtSoDienThoai.Text);
            bulncc.suaNhaCungCap(ncc);
            MessageBox.Show("Bạn muốn sửa nhà cung cấp", "Sửa Nhà Cung Cấp", MessageBoxButtons.OK);
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNhaCungCap_TextChanged(object sender, EventArgs e)
        {
            foreach (NhaCungCap ncc in bulncc.layTatCaNhaCungCap())
            {
                if (txtMaNhaCungCap.Text == ncc.MaNhaCungCap)
                {
                    txtTenNhaCungCap.Text = ncc.TenNhaCungCap;
                    txtDiaChi.Text = ncc.DiaChi;
                    txtSoDienThoai.Text = ncc.SoDienThoai;
                    btnSuaNhaCungCap.Enabled = true;
                    break;
                }
                else
                {
                    txtTenNhaCungCap.Text = "";
                    txtDiaChi.Text = "";
                    txtSoDienThoai.Text = "";
                    btnSuaNhaCungCap.Enabled = false;
                }
            }
        }

        private void txtTenNhaCungCap_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRong())
            {
                btnSuaNhaCungCap.Enabled = true;
            }
            else
            {
                btnSuaNhaCungCap.Enabled = false;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRong())
            {
                btnSuaNhaCungCap.Enabled = true;
            }
            else
            {
                btnSuaNhaCungCap.Enabled = false;
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRong())
            {
                btnSuaNhaCungCap.Enabled = true;
            }
            else
            {
                btnSuaNhaCungCap.Enabled = false;
            }
        }
    }
}
