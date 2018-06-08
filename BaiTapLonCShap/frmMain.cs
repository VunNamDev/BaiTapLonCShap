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

        private void loadDuLieu()
        {
            BULLoaiHang bulLoaiHang = new BULLoaiHang();
            dgvLoaiHang.DataSource = bulLoaiHang.layTatCaLoaiHang();
            dgvLoaiHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiHang.Columns[0].HeaderText = "Mã loại";
            dgvLoaiHang.Columns[1].HeaderText = "Tên loại";
            dgvLoaiHang.Columns[2].HeaderText = "Ghi chú";


            BULHang bulHang = new BULHang();
            dgvHang.DataSource = bulHang.layTatCaHang();
            dgvHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHang.Columns[0].HeaderText = "Mã hàng";
            dgvHang.Columns[1].HeaderText = "Tên hàng";
            dgvHang.Columns[2].HeaderText = "Đơn vị tính";
            dgvHang.Columns[3].HeaderText = "Đơn giá";
            dgvHang.Columns[4].HeaderText = "Mã loại";
            dgvHang.Columns[5].HeaderText = "Số lượng có";
            dgvHang.Columns[6].HeaderText = "Mã nhà cung cấp";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            tabUC1.SelectedTabIndex = 0;
            loadTab(tabNhanVien);
            BULNhanVien bulnv = new BULNhanVien();
            dgvNhanVien.DataSource = bulnv.laytatCaNhanVien();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            loadNhaCungCap();
            tabUC1.SelectedTabIndex = 1;
            loadTab(tabNCC);
            BULNhaCungCap bulncc = new BULNhaCungCap();
            dgvNhaCungCap.DataSource = bulncc.layTatCaNhaCungCap();
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            //loadHang();
            tabUC2.SelectedTabIndex = 0;
            loadTab(tabHang);
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            //loadLoaiHang();
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
            // TODO: This line of code loads data into the 'QLBHDataSetUC1.uc1' table. You can move, or remove it, as needed.
            this.uc1TableAdapter.Fill(this.QLBHDataSetUC1.uc1,12,3,2017);
            // TODO: This line of code loads data into the 'QLBHDataSet1.uc2' table. You can move, or remove it, as needed.
            this.uc2TableAdapter.Fill(this.QLBHDataSet1.uc2,2017,3);
            // TODO: This line of code loads data into the 'QLBHDataSet.v1' table. You can move, or remove it, as needed.
            //this.v1TableAdapter.Fill(this.QLBHDataSet.v1);
            // TODO: This line of code loads data into the 'QLBHDataSet.v1' table. You can move, or remove it, as needed.
            // this.v1TableAdapter.Fill(this.QLBHDataSet.v1,1,1997);
            loadManHinhBaoCaoDoanhSo();
            loadNhanVien();
            loadBaoCaoDoanhSoBanHang();
            loadBaoCaoHangBanTheoNgay();
            loadDuLieu();       //Hien thi DL bang Hang + LoaiHang
           /// this.reportViewer1.RefreshReport();
            addParamBaoCaoDoanhSo();

            this.reportView1.RefreshReport();
            this.reportHangTon.RefreshReport();
            this.reportHangTon.RefreshReport();
            this.reportBaoCaoHangBanTheoNgay.RefreshReport();
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

            this.reportView1.LocalReport.SetParameters(arrRP);
            this.reportView1.RefreshReport();
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

            BULNhanVien bulNV = new BULNhanVien();
            dgvNhanVien.DataSource = bulNV.laytatCaNhanVien();
            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
            dgvNhanVien.Columns[1].HeaderText = "Tên Nhân Viên";
            dgvNhanVien.Columns[2].HeaderText = "Địa Chỉ";
            dgvNhanVien.Columns[3].HeaderText = "Số Điện Thoại";
        }
        public void loadNhaCungCap()
        {
            BULNhaCungCap bulNCC = new BULNhaCungCap();
            dgvNhaCungCap.DataSource = bulNCC.layTatCaNhaCungCap();
            dgvNhaCungCap.Columns[0].HeaderText = "Mã Nhà Cung Cấp";
            dgvNhaCungCap.Columns[1].HeaderText = "Tên Nhà Cung Cấp";
            dgvNhaCungCap.Columns[2].HeaderText = "Địa Chỉ";
            dgvNhaCungCap.Columns[3].HeaderText = "Số Điện Thoại";
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
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Số điện thoại";
        }
        public void loadLichSuGia()
        {

            BULLichSuGia bulLSG = new BULLichSuGia();
            
            
            dgvLichSuGia.DataSource = bulLSG.layTatCaLichSuGiaCoTenHang();
            dgvLichSuGia.Columns[0].HeaderText = "Mã hàng";
            dgvLichSuGia.Columns[1].HeaderText = "Tên hàng";

            dgvLichSuGia.Columns[2].HeaderText = "Ngày bắt đầu";
            dgvLichSuGia.Columns[3].HeaderText = "Ngày kết thúc";
            dgvLichSuGia.Columns[4].HeaderText = "Đơn giá";
            dgvLichSuGia.Columns[5].HeaderText = "Ngày cập nhật";

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
            frmLapHoaDon frmLapHoaDon = new frmLapHoaDon();
            frmLapHoaDon.ShowDialog();
            
        }

       
        private void btnXemHoaDon_Click(object sender, EventArgs e)
        {
            BULHoaDon bULHoaDon = new BULHoaDon();
            loadTab(tabHoaDon);
            dtHoaDon.DataSource = bULHoaDon.hienHoaDon();
            dtHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dtHoaDon.Columns[1].HeaderText = "Mã Khách Hàng";
            dtHoaDon.Columns[2].HeaderText = "Tên Khách Hàng";
            dtHoaDon.Columns[3].HeaderText = "Ngày Lập";
            dtHoaDon.Columns[4].HeaderText = "Mã Nhân Viên";
            dtHoaDon.Columns[5].HeaderText = "Tên Nhân Viên";
            dtHoaDon.Columns[6].HeaderText = "Mã Hàng";
            dtHoaDon.Columns[7].HeaderText = "Đơn Giá";
            dtHoaDon.Columns[8].HeaderText = "Số Lượng";
            dtHoaDon.Columns[9].HeaderText = "Thành Tiền";


        }

        private void btnHangBanTheoNgay_Click(object sender, EventArgs e)
        {
            loadTab(tabHangBanTheoNgay);
        }

        private void btnHangTon_Click(object sender, EventArgs e)
        {
            loadTab(tabHangTon);
            loadBaoHangTon();
            
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

        private void dataGridViewX1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
           


        }

        private void tabControl_Click(object sender, EventArgs e)
        {
        }

        private void btnTimHoaDon_Click(object sender, EventArgs e)
        {
        
                BULHoaDon bULHoaDon = new BULHoaDon();
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHoaDon = txtTimMaHoaDon.Text;
            if(hoaDon.MaHoaDon=="")
            {
                dtHoaDon.DataSource = bULHoaDon.hienHoaDon();
            }
            else
            {
                dtHoaDon.DataSource = bULHoaDon.timHoaDon(hoaDon);
            }   
            dtHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dtHoaDon.Columns[1].HeaderText = "Mã Khách Hàng";
            dtHoaDon.Columns[2].HeaderText = "Tên Khách Hàng";
            dtHoaDon.Columns[3].HeaderText = "Ngày Lập";
            dtHoaDon.Columns[4].HeaderText = "Mã Nhân Viên";
            dtHoaDon.Columns[5].HeaderText = "Tên Nhân Viên";
            dtHoaDon.Columns[6].HeaderText = "Mã Hàng";
            dtHoaDon.Columns[7].HeaderText = "Đơn Giá";
            dtHoaDon.Columns[8].HeaderText = "Số Lượng";
            dtHoaDon.Columns[9].HeaderText = "Thành Tiền";

        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            BULNhanVien bulnv = new BULNhanVien();
            dgvNhanVien.DataSource = bulnv.layTatCaNhanVienTheoMa(txtNhanVien.Text);
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThemNV = new frmThemNhanVien();
            frmThemNV.ShowDialog();
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            frmSuaNhanVien frmSuaNV = new frmSuaNhanVien();
            frmSuaNV.ShowDialog();
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            frmXoaNhanVien frmXoaNV = new frmXoaNhanVien();
            frmXoaNV.ShowDialog();
        }

        private void btnTimNCC_Click(object sender, EventArgs e)
        {
            BULNhaCungCap bulncc = new BULNhaCungCap();
            dgvNhaCungCap.DataSource = bulncc.layNhaCungCapTheoMa(txtNCC.Text);
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap frmThemNCC = new frmThemNhaCungCap();
            frmThemNCC.ShowDialog();
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            frmSuaNhaCungCap frmSuaNCC = new frmSuaNhaCungCap();
            frmSuaNCC.ShowDialog();
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            frmXoaNhaCungCap frmXoaNCC = new frmXoaNhaCungCap();
            frmXoaNCC.ShowDialog();
        }

        private void btnThemNhanVien2_Click(object sender, EventArgs e)
        {
            frmThemNhanVien frmThem = new frmThemNhanVien();
            frmThem.ShowDialog();
        }

        private void btnSuaNhanVien2_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = dgvNhanVien.SelectedRows[0].Cells[0].Value + "";
            frmSuaNhanVien frm = new frmSuaNhanVien(nv);
            frm.ShowDialog();
        }

        private void btnXoaNhanVien2_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = dgvNhanVien.SelectedRows[0].Cells[0].Value + "";
            frmXoaNhanVien frm = new frmXoaNhanVien(nv);
            frm.ShowDialog();
        }

        private void btnThemNhaCungCap2_Click(object sender, EventArgs e)
        {
            frmThemNhaCungCap frmNCC = new frmThemNhaCungCap();
            frmNCC.ShowDialog();
        }

        private void btnSuaNhaCungCap2_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNhaCungCap = dgvNhaCungCap.SelectedRows[0].Cells[0].Value + "";
            frmSuaNhaCungCap frmSua = new frmSuaNhaCungCap(ncc);
            frmSua.ShowDialog();
        }

        private void btnXoaNhaCungCap2_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNhaCungCap = dgvNhaCungCap.SelectedRows[0].Cells[0].Value + "";
            frmXoaNhaCungCap frm = new frmXoaNhaCungCap(ncc);
            frm.ShowDialog();   
        }

        private void txtThangHangTon_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaNhanVienHangTon_TextChanged(object sender, EventArgs e)
        {
            BULNhanVien bulNV = new BULNhanVien();
            foreach (NhanVien nv in bulNV.laytatCaNhanVien())
            {
                if (nv.MaNhanVien == txtMaNhanVienHangTon.Text)
                {
                    txtTenNhanVienHangTon.Text = nv.HoTen;
                    btnBaoCaoDoanhSoHangTon.Enabled = true;
                    break;
                }
                else
                {
                    txtTenNhanVienHangTon.Text = "";
                    btnBaoCaoDoanhSoHangTon.Enabled = false;
                }
            }
        }
        void loadBaoHangTon()
        {
            txtThangHangTon.Text = DateTime.Now.Month +"";
            txtNamHangTon.Text = DateTime.Now.Year + "";
            txtNgayLapHangTon.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            List<string> arrDonVi = new List<string>();
            arrDonVi.Add("Kim bảo 1");
            arrDonVi.Add("Kim bảo 2");
            arrDonVi.Add("Kim bảo 3");
            cboDonViHangTon.DataSource = arrDonVi;

        }

        private NhanVien kiemTraNVTonTai(string ma)
        {
            BULNhanVien bulNhanVien = new BULNhanVien();
            foreach (NhanVien item in bulNhanVien.laytatCaNhanVien())
            {
                if (item.MaNhanVien == ma)
                {
                    return item;
                }
            }
            return null;
        }
        void loadBaoCaoHangBanTheoNgay()
        {
            //txtThangHangTon.Text = DateTime.Now.Month + "";
            //txtNamHangTon.Text = DateTime.Now.Year + "";
            txtNgayLapBaoCaoTheoNgay.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
            
            List<string> arrDonVi = new List<string>();
            arrDonVi.Add("Kim bảo 1");
            arrDonVi.Add("Kim bảo 2");
            arrDonVi.Add("Kim bảo 3");
            cboTenDVBaoCaoTheoNgay.DataSource = arrDonVi;

        }
        public void addParamHangTon()
        {
            ReportParameter[] rpHT = new ReportParameter[6];
            rpHT[0] = new ReportParameter("Thang");
            rpHT[1] = new ReportParameter("Nam");
            rpHT[2] = new ReportParameter("maNhanVien");
            rpHT[3] = new ReportParameter("tenNhanVien");
            rpHT[4] = new ReportParameter("ngayLap");
            rpHT[5] = new ReportParameter("donVi");

            rpHT[0].Values.Add(txtThangHangTon.Text);
            rpHT[1].Values.Add(txtNamHangTon.Text);
            rpHT[2].Values.Add(txtMaNhanVienHangTon.Text);
            rpHT[3].Values.Add(txtTenNhanVienHangTon.Text);
            rpHT[4].Values.Add(txtNgayLapHangTon.Text);
            rpHT[5].Values.Add(cboDonViHangTon.SelectedItem + "");

            this.reportHangTon.LocalReport.SetParameters(rpHT);
            this.reportHangTon.RefreshReport();

        }

        public void addParameterBaoCaoHangBanTheoNgay()
        {
            ReportParameter[] rpBCHBTN = new ReportParameter[7];
            rpBCHBTN[0] = new ReportParameter("ngay");
            rpBCHBTN[1] = new ReportParameter("thang");
            rpBCHBTN[2] = new ReportParameter("nam");
            rpBCHBTN[3] = new ReportParameter("maNV");
            rpBCHBTN[4] = new ReportParameter("tenNV");
            rpBCHBTN[5] = new ReportParameter("ngayLap");
            rpBCHBTN[6] = new ReportParameter("donVi");

            rpBCHBTN[0].Values.Add(txtNgayBaoCaoTheoNgay.Text);
            rpBCHBTN[1].Values.Add(txtThangBaoCaoTheoNgay.Text);
            rpBCHBTN[2].Values.Add(txtNamBaoCaoTheoNgay.Text);
            rpBCHBTN[3].Values.Add(txtMaNVBaoCaoTheoNgay.Text);
            rpBCHBTN[4].Values.Add(txtTenNVBaoCaoTheoNgay.Text);
            rpBCHBTN[5].Values.Add(txtNgayLapBaoCaoTheoNgay.Text);
            rpBCHBTN[6].Values.Add(cboTenDVBaoCaoTheoNgay.SelectedItem + "");

            this.reportBaoCaoHangBanTheoNgay.LocalReport.SetParameters(rpBCHBTN);
            this.reportBaoCaoHangBanTheoNgay.RefreshReport();

        }

        private void txtNgayLap_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cboDonVi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNhanVienHangTon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBaoCaoDoanhSoHangTon_Click(object sender, EventArgs e)
        {
            this.uc2TableAdapter.Fill(this.QLBHDataSet1.uc2,int.Parse(txtNamHangTon.Text),int.Parse(txtThangHangTon.Text));
            addParamHangTon();
        }

        private void btnBaoCaoTheoNgay_Click(object sender, EventArgs e)
        {
            this.uc1TableAdapter.Fill(this.QLBHDataSetUC1.uc1, int.Parse(txtNgayBaoCaoTheoNgay.Text), int.Parse(txtThangBaoCaoTheoNgay.Text), int.Parse(txtNamBaoCaoTheoNgay.Text));

            addParameterBaoCaoHangBanTheoNgay();
        }

        private void txtMaNVBaoCaoTheoNgay_TextChanged(object sender, EventArgs e)
        {
            NhanVien nv = kiemTraNVTonTai(txtMaNVBaoCaoTheoNgay.Text);
            if (kiemTraNVTonTai(txtMaNVBaoCaoTheoNgay.Text) != null)
            {
                txtTenNVBaoCaoTheoNgay.Text = nv.HoTen;
            }
            else
            {
                txtTenNVBaoCaoTheoNgay.Text = "";
            }
        }

        private void txtNgayLapBaoCaoTheoNgay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemHang_Click(object sender, EventArgs e)
        {
            frmThemHang frmTH = new frmThemHang();
            frmTH.ShowDialog();
            loadDuLieu();
        }

        private void btnSuaHang_Click(object sender, EventArgs e)
        {
            frmSuaHang frmSH = new frmSuaHang();
            frmSH.ShowDialog();
            loadDuLieu();
        }

        private void btnXoaHang_Click(object sender, EventArgs e)
        {
            frmXoaHang frmXH = new frmXoaHang();
            frmXH.ShowDialog();
            loadDuLieu();
        }

        private void btnThemLoaiHang_Click(object sender, EventArgs e)
        {
            frmThemLoaiHang frmTLH = new frmThemLoaiHang();
            frmTLH.ShowDialog();
            loadDuLieu();
        }

        private void btnSuaLoaiHang_Click(object sender, EventArgs e)
        {
            frmSuaLoaiHang frmSLH = new frmSuaLoaiHang();
            frmSLH.ShowDialog();
            loadDuLieu();
        }

        private void btnXoaLoaiHang_Click(object sender, EventArgs e)
        {
            frmXoaLoaiHang frmXLH = new frmXoaLoaiHang();
            frmXLH.ShowDialog();
            loadDuLieu();
        }

        private void btnTimHang_Click(object sender, EventArgs e)
        {
            Hang hang = new Hang();
            hang.MaHang = txtHang.Text;
            BULHang bulHang = new BULHang();
            if (txtHang.Text == "")
            {
                dgvHang.DataSource = bulHang.layTatCaHang();
            }
            else
            {
                dgvHang.DataSource = bulHang.timKiem(hang);
            }
        }

        private void btnTimLoaiHang_Click(object sender, EventArgs e)
        {
            LoaiHang loaiHang = new LoaiHang();
            loaiHang.MaLoai = txtLoaiHang.Text;
            BULLoaiHang bulLoaiHang = new BULLoaiHang();
            if (txtLoaiHang.Text == "")
            {
                dgvLoaiHang.DataSource = bulLoaiHang.layTatCaLoaiHang();
            }
            else
            {
                dgvLoaiHang.DataSource = bulLoaiHang.tim(loaiHang);
            }
        }

        private void btnThemHang2_Click(object sender, EventArgs e)
        {
            frmThemHang formThemHang = new frmThemHang();
            formThemHang.ShowDialog();
            loadDuLieu();
        }

        private void btnSuaHang2_Click(object sender, EventArgs e)
        {
            Hang h = new Hang();
            h.MaHang = dgvHang.SelectedRows[0].Cells[0].Value.ToString();
            frmSuaHang formSuaHang = new frmSuaHang(h);
            formSuaHang.ShowDialog();
            loadDuLieu();
        }

        private void btnXoaHang2_Click(object sender, EventArgs e)
        {
            Hang h = new Hang();
            h.MaHang = dgvHang.SelectedRows[0].Cells[0].Value.ToString();
            frmXoaHang formXoaHang = new frmXoaHang(h);
            formXoaHang.ShowDialog();
            loadDuLieu();
        }

        private void btnThemLoaiHang2_Click(object sender, EventArgs e)
        {
            frmThemLoaiHang formThemLoaiHang = new frmThemLoaiHang();
            formThemLoaiHang.ShowDialog();
            loadDuLieu();
        }

        private void btnSuaLoaiHang2_Click(object sender, EventArgs e)
        {
            LoaiHang lh = new LoaiHang();
            lh.MaLoai = dgvLoaiHang.SelectedRows[0].Cells[0].Value.ToString();
            frmSuaLoaiHang formSuaLoaiHang = new frmSuaLoaiHang(lh);
            formSuaLoaiHang.ShowDialog();
            loadDuLieu();
        }

        private void btnXoaLoaiHang2_Click(object sender, EventArgs e)
        {
            LoaiHang lh = new LoaiHang();
            lh.MaLoai = dgvLoaiHang.SelectedRows[0].Cells[0].Value.ToString();
            frmXoaLoaiHang formXoaLoaiHang = new frmXoaLoaiHang(lh);
            formXoaLoaiHang.ShowDialog();
            loadDuLieu();
        }

        private void txtTenNVBaoCaoTheoNgay_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNVBaoCaoTheoNgay.Text != "")
            {
                btnBaoCaoTheoNgay.Enabled = true;
            }
            else
            {
                btnBaoCaoTheoNgay.Enabled = false;
            }
        }

        private void superTabControl1_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {

        }

        private void superTabControlPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
