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
using System.Globalization;

namespace BaiTapLonCShap
{
    public partial class frmXoaLichSuGia : Form
    {
        BULLichSuGia bulLSG = new BULLichSuGia();
        BULHang bulHang = new BULHang();

        List<LichSuGia> arrLSG = new List<LichSuGia>();
        LichSuGia lichSu = new LichSuGia();

        public frmXoaLichSuGia()
        {
            InitializeComponent();
            lichSu.MaHang = "";
            lichSu.NgayBatDau = "";
        }

        public frmXoaLichSuGia(LichSuGia lichSu)
        {
            InitializeComponent();
            this.lichSu = lichSu;            
        }
        private void frmXoaLichSuGia_Load(object sender, EventArgs e)
        {

            txtNgayCapNhat.Text = DateTime.Now.ToString("dd/MM/yyyy") + "";
            cboMaHang.DataSource = bulHang.layTatCaHang();
            cboMaHang.DisplayMember = "tenHang";
            cboMaHang.ValueMember = "maHang";
            if (lichSu.MaHang != "")
            {
                cboMaHang.SelectedValue = lichSu.MaHang;
                txtNgayBatDau.Text = lichSu.NgayBatDau;
                dtNgayBatDau.Text = txtNgayBatDau.Text;

            }
            
            arrLSG = bulLSG.layTatCaLichSuGia();
            
            
        }
        private void nhanThayDoi()
        {

            foreach (LichSuGia ls in bulLSG.layTatCaLichSuGia())
            {

                if (ls.MaHang == cboMaHang.SelectedValue.ToString() && ls.NgayBatDau == txtNgayBatDau.Text)
                {

                    txtNgayKetThuc.Text = ls.NgayKetThuc;
                    txtDonGia.Text = ls.DonGia + "";
                    txtNgayCapNhat.Text = ls.NgayCapNhat;
                    btnXoa.Enabled = true;
                    break;
                }

                else
                {
                    btnXoa.Enabled = false;
                    txtNgayKetThuc.Text = "";
                    txtDonGia.Text = "";
                    txtNgayCapNhat.Text = "";
                }
            }
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            nhanThayDoi();
        }

        private void txtNgayBatDau_TextChanged(object sender, EventArgs e)
        {
            nhanThayDoi();
           
        }


        private void dtNgayBatDau_TextChanged(object sender, EventArgs e)
        {
            txtNgayBatDau.Text = dtNgayBatDau.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            LichSuGia ls = new LichSuGia(cboMaHang.SelectedValue + "", dtNgayBatDau.Value.ToString("MM/dd/yyyy"),
           dtNgayKetThuc.Value.ToString("MM/dd/yyyy"), float.Parse(txtDonGia.Text),
           DateTime.Now.ToString("MM/dd/yyyy"));


            DialogResult dl = MessageBox.Show("Xoá lịch sử giá", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                bulLSG.Xoa(ls);

                this.Close();
            }
        }
    }
}
