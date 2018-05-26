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
    public partial class frmSuaLichSuGia : Form
    {
        BULLichSuGia bulLSG = new BULLichSuGia();
        BULHang bulHang = new BULHang();
        List<LichSuGia> arrLSG = new List<LichSuGia>();
        LichSuGia lichSu = new LichSuGia();

        public event EventHandler btn_click;
        public frmSuaLichSuGia()
        {
            InitializeComponent();
            lichSu.MaHang = "";
            lichSu.NgayBatDau = "";
        }
        public frmSuaLichSuGia(LichSuGia ls)
        {
            InitializeComponent();
            this.lichSu =  ls;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            float f = -1;
            float.TryParse(txtDonGia.Text,out f);
            if(f<0||f.ToString().Length!= txtDonGia.Text.Length)
            {
                MessageBox.Show("đơn giá chỉ nhập số và số dương");
                txtDonGia.Text = "";
            }
            else
            {
                LichSuGia ls = new LichSuGia(cboMaHang.SelectedValue + "", dtNgayBatDau.Value.ToString("MM/dd/yyyy"),
                dtNgayKetThuc.Value.ToString("MM/dd/yyyy"), float.Parse(txtDonGia.Text),
                DateTime.Now.ToString("MM/dd/yyyy"));

                
                bulLSG.update(ls);
                if (btn_click != null)
                    btn_click(sender, e);
                MessageBox.Show("Sửa lịch sử giá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void frmSuaLichSuGia_Load(object sender, EventArgs e)
        {
            txtNgayCapNhat.Text = DateTime.Now.ToString("dd/MM/yyyy") + "";
            cboMaHang.DataSource = bulHang.layTatCaHang();
            cboMaHang.DisplayMember = "tenHang";
            cboMaHang.ValueMember = "maHang";
            if (lichSu.MaHang != "")
            {
                txtNgayBatDau.Text = lichSu.NgayBatDau;
                cboMaHang.SelectedValue = lichSu.MaHang;
                txtNgayBatDau.Text = lichSu.NgayBatDau;
                dtNgayBatDau.Value = DateTime.ParseExact(txtNgayBatDau.Text,
                                   "dd/MM/yyyy",
                                   CultureInfo.InvariantCulture);
                dtNgayKetThuc.Value = DateTime.ParseExact(txtNgayKetThuc.Text,
                                   "dd/MM/yyyy",
                                   CultureInfo.InvariantCulture);
                
            }

            arrLSG = bulLSG.layTatCaLichSuGia();

            
        }

        private void txtNgayBatDau_TextChanged(object sender, EventArgs e)
        {
            nhanThayDoi();
            if(textBoxRong())
            {
                btnSua.Enabled = false;
            }
        }
        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void dtNgayBatDau_TextChanged(object sender, EventArgs e)
        {
            
            txtNgayBatDau.Text = dtNgayBatDau.Text;
        }

        private void dtNgayKetThuc_TextChanged(object sender, EventArgs e)
        {
            txtNgayKetThuc.Text = dtNgayKetThuc.Text;
        }

        

        private void cboMaHang_SelectedValueChanged(object sender, EventArgs e)
        {
            nhanThayDoi();
        }
        private void nhanThayDoi()
        {
            
            foreach (LichSuGia ls in bulLSG.layTatCaLichSuGia())
            {

                if (ls.MaHang == cboMaHang.SelectedValue.ToString() && ls.NgayBatDau == txtNgayBatDau.Text)
                {
                   
                    txtNgayKetThuc.Text = ls.NgayKetThuc;
                    txtDonGia.Text = ls.DonGia + "";
                    txtNgayCapNhat.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    btnSua.Enabled = true;
                    break;
                }

                else
                {
                    btnSua.Enabled = false;
                    txtNgayKetThuc.Text = "";
                    txtDonGia.Text = "";
                    txtNgayCapNhat.Text = "";
                }
            }
        }
        private bool textBoxRong()
        {
            if (txtDonGia.Text == "" || txtNgayBatDau.Text == "" || txtNgayCapNhat.Text == "" || txtNgayKetThuc.Text =="")
                return true;
            return false;
        }

        private void txtNgayKetThuc_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRong())
            {
                btnSua.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRong())
            {
                btnSua.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
            }
        }

        private void txtNgayCapNhat_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRong())
            {
                btnSua.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
            }
        }

        private void dtNgayBatDau_Click(object sender, EventArgs e)
        {

        }
    }
}
