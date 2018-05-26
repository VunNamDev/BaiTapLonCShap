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
        
        public event EventHandler btn_Click;
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

        private void dtNgayKetThuc_TextChanged(object sender, EventArgs e)
        {
         
            txtNgayKetThuc.Text = dtNgayKetThuc.Text ;
        }

        private void dtNgayKetThuc_Click(object sender, EventArgs e)
        {

        }

        private void txtNgayCapNhat_TextChanged(object sender, EventArgs e)
        {
         
        }

    

        private void btnThem_Click(object sender, EventArgs e)
        {


            //MessageBox.Show(dtNgayBatDau.Value.ToString("MM/dd/yyyy"));
            LichSuGia lsg = new LichSuGia(cboMaHang.SelectedValue+"", dtNgayBatDau.Value.ToString("MM/dd/yyyy"),
                dtNgayKetThuc.Value.ToString("MM/dd/yyyy"),float.Parse(txtDonGia.Text),
                DateTime.Now.ToString("MM/dd/yyyy"));
              
           
            
            bulLSG.add(lsg);
            if (btn_Click != null)
                btn_Click(sender, e);
            MessageBox.Show("Thêm lịch sử giá thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            this.Close();
        }
    }
}
