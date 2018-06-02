using DevComponents.DotNetBar;
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
using Microsoft.Reporting.WinForms;

namespace BaiTapLonCShap
{
   
    public delegate void ThucThi(bool click);
    public partial class frmMain : Form
    {
        bool isFormActive = true;
        
        DataTable x = new DataTable();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            tabUC1.SelectedTabIndex = 0;
            loadTab(tabNhanVien);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            loadNhaCungCap();
            tabUC1.SelectedTabIndex = 1;
            loadTab(tabNCC);
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            loadHang();
            tabUC2.SelectedTabIndex = 0;
            loadTab(tabHang);
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            loadLoaiHang();
            tabUC2.SelectedTabIndex = 1;
            loadTab(tabLoaiHang);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            loadKhachHang();
            tabUC3.SelectedTabIndex = 0;
            loadTab(tabKhachHang);
        }

        private void btnLichSuGia_Click(object sender, EventArgs e)
        {
            loadLichSuGia();
            tabUC3.SelectedTabIndex = 1;
            loadTab(tabLichSuGia);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLBHDataSet.v1' table. You can move, or remove it, as needed.
            this.v1TableAdapter.Fill(this.QLBHDataSet.v1,1,1997);
            loadManHinhBaoCaoDoanhSo();
            //loadNhanVien();
            loadBaoCaoDoanhSoBanHang();
            this.reportViewer1.RefreshReport();
            addParamBaoCaoDoanhSo();
            
        }

        public void addParamBaoCaoDoanhSo()
        {
            ReportParameter[] arrRP = new ReportParameter[5];
            arrRP[0] = new ReportParameter("thang");
            arrRP[1] = new ReportParameter("nam");
            arrRP[2] = new ReportParameter("tenNhanVien");
            arrRP[3] = new ReportParameter("maNhanVien");
            arrRP[4] = new ReportParameter("donVi");

            arrRP[0].Values.Add(cboThang.SelectedItem + "");
            arrRP[1].Values.Add(cboNam.SelectedItem + "");
            arrRP[2].Values.Add(txtTenNhanVien.Text);
            arrRP[3].Values.Add(txtMaNhanVien.Text);
            arrRP[4].Values.Add(cboDonVi.SelectedItem +"");

            this.reportViewer1.LocalReport.SetParameters(arrRP);
            this.reportViewer1.RefreshReport();
        }
        public void loadManHinhBaoCaoDoanhSo()
        {
            
            List<string> arrThang = new List<string>();
            for(int i = 1; i <= 12; i++)
            {
                string s = "" + i;
                arrThang.Add(s);
            }
            cboThang.DataSource = arrThang;
            List<string> arrNam = new List<string>();
            
            for (int i=1990;i<= DateTime.Now.Year; i++)
            {
                string s = i + "";
                arrNam.Add(s);
            }
            cboNam.DataSource = arrNam;
            txtNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");

            List<string> arrDonVi = new List<string>();
            arrDonVi.Add("Kim Bảo 1");
            arrDonVi.Add("Kim Bảo 2");
            arrDonVi.Add("Kim Bảo 3");
            cboDonVi.DataSource = arrDonVi;
        }
        public void loadBaoCaoDoanhSoBanHang() {
            
          
        }
        public void loadNhanVien()
        {

            //BULNhanVien bulNV = new BULNhanVien();
            //dgvNhanVien.DataSource = bulNV.laytatCaNhanVien();
        }
        public void loadNhaCungCap()
        {
            //BULNhaCungCap bulNCC = new BULNhaCungCap();
            //dgvNhaCungCap.DataSource = bulNCC.layTatCaNhaCungCap();
        }
        public void loadHang()
        {

            //BULHang bulH = new BULHang();
            //dgvHang.DataSource = bulH.layTatCaHang();
        }
        public void loadLoaiHang()
        {

            //BULLoaiHang bulLH = new BULLoaiHang();
            //dgvLoaiHang.DataSource = bulLH.layTatCaLoaiHang();
           
        }
        public void loadKhachHang()
        {
            BULKhachHang bulKH = new BULKhachHang();
            dgvKhachHang.DataSource = bulKH.layTatCaKhachHang();
                    }
        public void loadLichSuGia()
        {

            BULLichSuGia bulLSG = new BULLichSuGia();
            
            
            dgvLichSuGia.DataSource = bulLSG.layTatCaLichSuGiaCoTenHang();
            dgvLichSuGia.Columns[0].HeaderText = "Mã hàng";
            dgvLichSuGia.Columns[1].HeaderText = "Tên hàng";
        }

        void reloadDGV()
        {
            loadNhanVien();
            loadNhaCungCap();
            loadHang();
            loadLoaiHang();
            loadKhachHang();
            loadLichSuGia();
        }
        private void loadTab(TabItem tabName)
        {

            TabItem[] arrTabsName = { tabNhanVien, tabNCC, tabHang, tabLoaiHang,
                                     tabKhachHang, tabLichSuGia, tabHoaDon, tabHangBanTheoNgay,
                                     tabHangTon, tabDoanhSo };
            List<TabItem> tabsName = new List<TabItem>();
            tabsName.AddRange(arrTabsName);
            foreach (TabItem t in tabsName)
            {
                if (tabName == t)
                {
                    t.Visible = true;
                }
                else
                {
                    t.Visible = false;
                }
            }
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            loadTab(tabHoaDon);
        }

        private void btnHangBanTheoNgay_Click(object sender, EventArgs e)
        {
            loadTab(tabHangBanTheoNgay);
        }

        private void btnHangTon_Click(object sender, EventArgs e)
        {
            loadTab(tabHangTon);
        }

        private void btnDoanhSo_Click(object sender, EventArgs e)
        {
            loadTab(tabDoanhSo);
        }

        private void time_Tick(object sender, EventArgs e)
        {
            string d = "Hôm nay " + DateTime.Now.ToString("dd/MM/yyyy     HH:mm:ss");
            lblNgayGio.Text = d;
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            frmThemKhachHang frmKH = new frmThemKhachHang();
            frmKH.ShowDialog();
        }
        
        private void btnThemLichSuGia_Click(object sender, EventArgs e)
        {
            frmThemLichSuGia themlsg = new frmThemLichSuGia();
          
            themlsg.ShowDialog();
        }
        void NhanSuKienClick(object sender, EventArgs e)
        {
            loadNhanVien();
            loadNhaCungCap();
            loadHang();
            loadLoaiHang();
            loadKhachHang();
            loadLichSuGia();
        }
        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            frmSuaKhachHang frmSua = new frmSuaKhachHang();     
           
            frmSua.ShowDialog();
        }
        private void btnSuaKhachHangContexMenu_Click(object sender, EventArgs e)
        {
            
            
        }
        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            frmXoaKhachHang frmXoa = new frmXoaKhachHang();
           
            frmXoa.ShowDialog();
            
        }
        private void btnXoaKhachHangContextMenu_Click(object sender, EventArgs e)
        {
           

        }

        private void btnTimLSG_Click(object sender, EventArgs e)
        {
            if(txtLSG.Text=="")
            {
                BULLichSuGia lsg = new BULLichSuGia();
                dgvLichSuGia.DataSource = lsg.layTatCaLichSuGia();
            }
            else
            {
                BULLichSuGia lsg = new BULLichSuGia();
                dgvLichSuGia.DataSource = lsg.layTatCaLichSuGiaCoTenHang(txtLSG.Text);
            }
        }

        private void btnSuaLichSuGia_Click(object sender, EventArgs e)
        {
            frmSuaLichSuGia suaLSG = new frmSuaLichSuGia();
            
            suaLSG.ShowDialog();
        }

        private void btnSuaLichSuGiaContextMenu_Click(object sender, EventArgs e)
        {
            
        }
        private void txtNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoaLichSuGia_Click(object sender, EventArgs e)
        {
            frmXoaLichSuGia xoaLSG = new frmXoaLichSuGia();
            
            xoaLSG.ShowDialog();
        }
        private void btnXoaLichSuGiaContextMenu_Click(object sender, EventArgs e)
        {
           
        }
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            this.v1TableAdapter.Fill(this.QLBHDataSet.v1,
                System.Int32.Parse(cboThang.SelectedItem.ToString()),
                System.Int32.Parse(cboNam.SelectedItem.ToString()));
            addParamBaoCaoDoanhSo();
            loadBaoCaoDoanhSoBanHang();
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemKhachHang2_Click(object sender, EventArgs e)
        {
            btnThemKhachHang_Click(sender, e);
        }

        private void btnSuaKhachHang2_Click(object sender, EventArgs e)
        {
            KhachHang x = new KhachHang();
            x.MaKhachHang = dgvKhachHang.SelectedRows[0].Cells[0].Value + "";
            frmSuaKhachHang frmSua = new frmSuaKhachHang(x);
            // sau mỗi lần ấn     
           
            frmSua.ShowDialog();
        }

        private void btnXoaKhachHang2_Click(object sender, EventArgs e)
        {
            KhachHang x = new KhachHang();
            x.MaKhachHang = dgvKhachHang.SelectedRows[0].Cells[0].Value + "";
            frmXoaKhachHang frmXoa = new frmXoaKhachHang(x);
           
            frmXoa.ShowDialog();
        }

        private void btnSuaLichSuGia2_Click(object sender, EventArgs e)
        {
            LichSuGia lsg = new LichSuGia();
            //MessageBox.Show(dgvLichSuGia.SelectedRows[0].Cells["maHang"].Value + "---"+dgvLichSuGia.SelectedRows[0].Cells["ngayBatDau"].Value);
            lsg.MaHang = dgvLichSuGia.SelectedRows[0].Cells["maHang"].Value + "";
            lsg.NgayBatDau = dgvLichSuGia.SelectedRows[0].Cells["ngayBatDau"].Value + "";
            frmSuaLichSuGia suaLSG = new frmSuaLichSuGia(lsg);
          
            suaLSG.ShowDialog();
        }

        private void btnXoaLichSuGia2_Click(object sender, EventArgs e)
        {
            LichSuGia lsg = new LichSuGia();
            //MessageBox.Show(dgvLichSuGia.SelectedRows[0].Cells["maHang"].Value + "---"+dgvLichSuGia.SelectedRows[0].Cells["ngayBatDau"].Value);
            lsg.MaHang = dgvLichSuGia.SelectedRows[0].Cells["maHang"].Value + "";
            lsg.NgayBatDau = dgvLichSuGia.SelectedRows[0].Cells["ngayBatDau"].Value + "";

            frmXoaLichSuGia xoaLSG = new frmXoaLichSuGia(lsg);
          
            xoaLSG.ShowDialog();
        }

        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            BULKhachHang bulKH = new BULKhachHang();
            if (txtKhachHang.Text == "")
            {
                
                dgvKhachHang.DataSource = bulKH.layTatCaKhachHang();
            }
            else
            {        
                dgvKhachHang.DataSource = bulKH.layTatCaKhachHang(txtKhachHang.Text);
            }
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            BULNhanVien bulNV = new BULNhanVien();
            foreach(NhanVien nv in bulNV.laytatCaNhanVien())
            {
                if (nv.MaNhanVien == txtMaNhanVien.Text)
                {
                    txtTenNhanVien.Text = nv.HoTen;
                    btnBaoCaoDoanhSo.Enabled = true;
                    break;
                }
                else
                {
                    txtTenNhanVien.Text = "";
                    btnBaoCaoDoanhSo.Enabled = false;
                }
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (!isFormActive)
            {
                reloadDGV();
                isFormActive = false;
            }
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            
        }

        private void frmMain_AutoValidateChanged(object sender, EventArgs e)
        {
           
            
        }

        private void frmMain_Validated(object sender, EventArgs e)
        {
           
        }

        private void frmMain_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void frmMain_Deactivate(object sender, EventArgs e)
        {
            isFormActive=false;
        }
    }
}
