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
    
    public partial class frmThemNhanVien : Form
    {
        BULNhanVien bulnv = new BULNhanVien();
        public frmThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txtMaNhanVien.Text, txtTenNhanVien.Text, txtDiaChi.Text, txtSoDienThoai.Text);
            bulnv.themNhanVien(nv);
            MessageBox.Show("Thêm Nhân Viên Thành công", "Thêm Nhân Viên", MessageBoxButtons.OK);
        }

        private void frmThemNhanVien_Load(object sender, EventArgs e)
        {
            while (true)
            {
                string ma = "NV";
                Random rd = new Random();
                int n = rd.Next(0, 100);
                ma = ma + n;
                if (!kiemTraMa(ma))
                {
                    txtMaNhanVien.Text = ma;
                    break;
                }
            }
        }
        private bool kiemTraMa(string ma)
        {
            foreach(NhanVien nv in bulnv.laytatCaNhanVien())
            {
                if (nv.MaNhanVien == ma)
                {
                    return true;
                }
            }
            return false;
        }
        bool textBoxRong()
        {
            if(txtTenNhanVien.Text=="" || txtDiaChi.Text=="" || txtSoDienThoai.Text == "")
            {
                return true;
            }
            return false;
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRong())
            {
                btnThemNhanVien.Enabled = true;
            }
            else
            {
                btnThemNhanVien.Enabled = false;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRong())
            {
                btnThemNhanVien.Enabled = true;
            }
            else
            {
                btnThemNhanVien.Enabled = false;
            }
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (!textBoxRong())
            {
                btnThemNhanVien.Enabled = true;
            }
            else
            {
                btnThemNhanVien.Enabled = false;
            }
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
