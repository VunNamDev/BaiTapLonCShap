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
       
        BULHang bulHang = new BULHang();
        BULLichSuGia bulLSG = new BULLichSuGia();
        public frmThemLichSuGia()
        {
            InitializeComponent();
        }

        private void frmThemLichSuGia_Load(object sender, EventArgs e)
        {
          
            txtNgayCapNhat.Text = DateTime.Now.ToString("dd/MM/yyyy") + "";
            cboMaHang.DataSource = bulHang.layTatCaHang();
            cboMaHang.DisplayMember = "tenHang";
            cboMaHang.ValueMember = "maHang";
        }

        private void dtNgayBatDau_TextChanged(object sender, EventArgs e)
        {
            txtNgayBatDau.Text = dtNgayBatDau.Text ;
        }
        private bool textBoxRong()
        {
            if (txtDonGia.Text == "" || txtNgayBatDau.Text == "" || txtNgayCapNhat.Text == "" || txtNgayKetThuc.Text == "")
                return true;
            return false;
        }
        private void dtNgayKetThuc_TextChanged(object sender, EventArgs e)
        {
         
            txtNgayKetThuc.Text = dtNgayKetThuc.Text ;
        }



        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                LichSuGia lsg = new LichSuGia(cboMaHang.SelectedValue + "", dtNgayBatDau.Value.ToString("MM/dd/yyyy"),
                dtNgayKetThuc.Value.ToString("MM/dd/yyyy"), float.Parse(txtDonGia.Text),
                DateTime.Now.ToString("MM/dd/yyyy"));



                bulLSG.add(lsg);
               
                MessageBox.Show("Thêm lịch sử giá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            catch(Exception )
            {
                MessageBox.Show("Thêm lịch sử giá thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.Close();
            }

            //MessageBox.Show(dtNgayBatDau.Value.ToString("MM/dd/yyyy"));
            
        }

        private void dtNgayBatDau_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayBatDau_TextChanged(object sender, EventArgs e)
        {
            if(textBoxRong())
            {
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
            }
        }

        private void txtNgayKetThuc_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRong())
            {
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
            }
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRong())
            {
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn muốn hủy thao tác thêm lịch sử giá?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
