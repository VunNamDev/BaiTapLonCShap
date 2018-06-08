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
    public partial class frmSuaNhanVien : Form
    {
        BULNhanVien bulnv = new BULNhanVien();
        public frmSuaNhanVien()
        {
            InitializeComponent();
        }
        public frmSuaNhanVien(NhanVien nv)
        {
            InitializeComponent();
            txtMaNhanVien.Text = nv.MaNhanVien;
        }

        private void frmSuaNhanVien_Load(object sender, EventArgs e)
        {

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
                    btnSuaNhanVien.Enabled = true;
                    break;
                }
                else
                {
                    txtTenNhanVien.Text = "";
                    txtDiaChi.Text = "";
                    txtSoDienThoai.Text = "";
                    btnSuaNhanVien.Enabled = false;
                }
            }
        }
        bool textBoxRong()
        {
            if (txtTenNhanVien.Text == "" || txtMaNhanVien.Text == "" || txtDiaChi.Text == "" || txtSoDienThoai.Text == "")
            {
                return true;
            }
            return false;
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtDiaChi.Text, txtSoDienThoai.Text);
            bulnv.suaNhanVien(nv);
            MessageBox.Show("Sửa Nhân Viên Thành Công", "Sửa Nhân Viên", MessageBoxButtons.OK);
        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRong())
            {
                btnSuaNhanVien.Enabled = true;
            }
            else
            {
                btnSuaNhanVien.Enabled = false;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRong())
            {
                btnSuaNhanVien.Enabled = true;
            }
            else
            {
                btnSuaNhanVien.Enabled = false;
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRong())
            {
                btnSuaNhanVien.Enabled = true;
            }
            else
            {
                btnSuaNhanVien.Enabled = false;
            }
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
