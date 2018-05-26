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

namespace BaiTapLonCShap
{
    public delegate void ThucThi(bool click);
    public partial class frmMain : Form
    {
        
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
            tabUC1.SelectedTabIndex = 1;
            loadTab(tabNCC);
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            tabUC2.SelectedTabIndex = 0;
            loadTab(tabHang);
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            tabUC2.SelectedTabIndex = 1;
            loadTab(tabLoaiHang);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            tabUC3.SelectedTabIndex = 0;
            loadTab(tabKhachHang);
        }

        private void btnLichSuGia_Click(object sender, EventArgs e)
        {
            tabUC3.SelectedTabIndex = 1;
            loadTab(tabLichSuGia);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            loadManHinhBaoCaoDoanhSo();
            loadThongTin();
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
        }
        public void loadThongTin()
        {
            BULKhachHang kh = new BULKhachHang();
            dgvKhachHang.DataSource = kh.layTatCaKhachHang();
            dgvKhachHang.Columns["maKhachHang"].DisplayIndex = 0;

            BULLichSuGia lsg = new BULLichSuGia();
            dgvLichSuGia.DataSource = lsg.layTatCaLichSuGia();
           
            BULHang bulHang = new BULHang();
            dgvHang.DataSource = bulHang.layTatCaHang();
            
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
            frmKH.btnThem += new EventHandler(NhanSuKienClick); 
            frmKH.ShowDialog();
        }
        
        private void btnThemLichSuGia_Click(object sender, EventArgs e)
        {
            frmThemLichSuGia themlsg = new frmThemLichSuGia();
            themlsg.btn_Click += new EventHandler(NhanSuKienClick);
            themlsg.ShowDialog();
        }
        void NhanSuKienClick(object sender, EventArgs e)
        {
            loadThongTin();
        }
        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            frmSuaKhachHang frmSua = new frmSuaKhachHang();     
            // sau mỗi lần ấn     
            frmSua.tbnSua_Click += new EventHandler(NhanSuKienClick);
            frmSua.ShowDialog();
        }
        private void btnSuaKhachHangContexMenu_Click(object sender, EventArgs e)
        {
            
            
        }
        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            frmXoaKhachHang frmXoa = new frmXoaKhachHang();
            frmXoa.btnXoa_click += new EventHandler(NhanSuKienClick);
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
                LichSuGia ls = new LichSuGia();
                ls.MaHang= txtLSG.Text;
                dgvLichSuGia.DataSource = lsg.layTatCaLichSuGiaCoDieuKien(ls);
            }
        }

        private void btnSuaLichSuGia_Click(object sender, EventArgs e)
        {
            frmSuaLichSuGia suaLSG = new frmSuaLichSuGia();
            suaLSG.btn_click += new EventHandler(NhanSuKienClick);
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
            xoaLSG.btn_click += new EventHandler(NhanSuKienClick);
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
            lblTieuDe.Text = "Báo cáo doanh số tháng "+cboThang.SelectedItem + " năm "+cboNam.SelectedItem;
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTieuDe.Text += "Báo cáo doanh số tháng " + cboThang.SelectedItem + " năm " + cboNam.SelectedItem;
        }

        private void btnBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {

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
            x.MaKhachHang = dgvKhachHang.SelectedRows[0].Cells[2].Value + "";
            frmSuaKhachHang frmSua = new frmSuaKhachHang(x);
            // sau mỗi lần ấn     
            frmSua.tbnSua_Click += new EventHandler(NhanSuKienClick);
            frmSua.ShowDialog();
        }

        private void btnXoaKhachHang2_Click(object sender, EventArgs e)
        {
            KhachHang x = new KhachHang();
            x.MaKhachHang = dgvKhachHang.SelectedRows[0].Cells[2].Value + "";
            frmXoaKhachHang frmXoa = new frmXoaKhachHang(x);
            frmXoa.btnXoa_click += new EventHandler(NhanSuKienClick);
            frmXoa.ShowDialog();
        }

        private void btnSuaLichSuGia2_Click(object sender, EventArgs e)
        {
            LichSuGia lsg = new LichSuGia();
            //MessageBox.Show(dgvLichSuGia.SelectedRows[0].Cells["maHang"].Value + "---"+dgvLichSuGia.SelectedRows[0].Cells["ngayBatDau"].Value);
            lsg.MaHang = dgvLichSuGia.SelectedRows[0].Cells["maHang"].Value + "";
            lsg.NgayBatDau = dgvLichSuGia.SelectedRows[0].Cells["ngayBatDau"].Value + "";
            frmSuaLichSuGia suaLSG = new frmSuaLichSuGia(lsg);
            suaLSG.btn_click += new EventHandler(NhanSuKienClick);
            suaLSG.ShowDialog();
        }

        private void btnXoaLichSuGia2_Click(object sender, EventArgs e)
        {
            LichSuGia lsg = new LichSuGia();
            //MessageBox.Show(dgvLichSuGia.SelectedRows[0].Cells["maHang"].Value + "---"+dgvLichSuGia.SelectedRows[0].Cells["ngayBatDau"].Value);
            lsg.MaHang = dgvLichSuGia.SelectedRows[0].Cells["maHang"].Value + "";
            lsg.NgayBatDau = dgvLichSuGia.SelectedRows[0].Cells["ngayBatDau"].Value + "";

            frmXoaLichSuGia xoaLSG = new frmXoaLichSuGia(lsg);
            xoaLSG.btn_click += new EventHandler(NhanSuKienClick);
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
                KhachHang kh = new KhachHang();
                kh.MaKhachHang = txtKhachHang.Text;
                dgvKhachHang.DataSource = bulKH.layTatCaKhachHang(kh);
            }
        }
    }
}
