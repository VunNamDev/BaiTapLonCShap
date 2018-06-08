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
    public partial class frmXoaNhaCungCap : Form
    {
        BULNhaCungCap bulncc = new BULNhaCungCap();
        public frmXoaNhaCungCap()
        {
            InitializeComponent();
        }
        public frmXoaNhaCungCap(NhaCungCap ncc)
        {
            InitializeComponent();
            txtMaNhaCungCap.Text = ncc.MaNhaCungCap;
        }

        private void frmXoaNhaCungCap_Load(object sender, EventArgs e)
        {

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
                    btnXoaNhaCungCap.Enabled = true;
                    break;
                }
                else
                {
                    txtTenNhaCungCap.Text = "";
                    txtDiaChi.Text = "";
                    txtSoDienThoai.Text = "";
                    btnXoaNhaCungCap.Enabled = false;

                }
            }
        }

        private void btnXoaNhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap(txtMaNhaCungCap.Text, txtTenNhaCungCap.Text, txtDiaChi.Text, txtSoDienThoai.Text);
            bulncc.xoaNhaCungCap(ncc);
            MessageBox.Show("bạn muốn xóa nhà cung cấp", "Xóa nhà cung cấp", MessageBoxButtons.OK);
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
