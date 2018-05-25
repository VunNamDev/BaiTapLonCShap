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
    public partial class frmThemLichSuGia : Form
    {
        public frmThemLichSuGia()
        {
            InitializeComponent();
        }

        private void frmThemLichSuGia_Load(object sender, EventArgs e)
        {
        }

        private void dtNgayBatDau_TextChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dtNgayBatDau.Text);
            txtNgayBatDau.Text = date.ToString("dd/MM/yyyy");
        }

        private void dtNgayKetThuc_TextChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dtNgayKetThuc.Text);
            txtNgayKetThuc.Text =  date.ToString("dd/MM/yyyy");
        }

        private void dtNgayKetThuc_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayCapNhat_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void dtNgayCapNhat_TextChanged(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(dtNgayCapNhat.Text + "");
            txtNgayCapNhat.Text = date.ToString("dd/MM/yyyy");
        }
    }
}
