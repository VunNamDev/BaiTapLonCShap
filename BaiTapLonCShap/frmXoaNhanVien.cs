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
    public partial class frmXoaNhanVien : Form
    {
        BULNhanVien bulnv = new BULNhanVien();
        public frmXoaNhanVien()
        {
            InitializeComponent();
        }
        public frmXoaNhanVien(NhanVien nv)
        {
            InitializeComponent();
            txtMaNhanVien.Text = nv.MaNhanVien;
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            foreach (NhanVien x in bulnv.laytatCaNhanVien())
            {
                if (txtMaNhanVien.Text == x.MaNhanVien)
                {
                    txtTenNhanVien.Text = x.HoTen;
                    txtDiaChi.Text = x.DiaChi;
                    txtSoDienThoai.Text = x.SoDienThoai;
                    btnXoaNhanVien.Enabled = true;
                    break;
                }
                else
                {
                    txtTenNhanVien.Text = "";
                    txtDiaChi.Text = "";
                    txtSoDienThoai.Text = "";
                    btnXoaNhanVien.Enabled = false;
                }
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtDiaChi.Text, txtSoDienThoai.Text);

            DialogResult rs = MessageBox.Show("Ban Có Muốn Xóa Không ???", "Xóa Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                bulnv.xoaNhanVien(nv);
                MessageBox.Show("Xóa thành công");
                this.Close();
            }
        }
    }
}
