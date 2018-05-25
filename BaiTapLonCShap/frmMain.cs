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
            loadThongTin();
        }
       
        public void loadThongTin()
        {
            BULKhachHang kh = new BULKhachHang();
            dgvKhachHang.DataSource = kh.layTatCaKhachHang();

            BULLichSuGia lsg = new BULLichSuGia();
            dgvLichSuGia.DataSource = lsg.layTatCaLichSuGia();
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
            themlsg.ShowDialog();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            frmXoaKhachHang frmXoa = new frmXoaKhachHang();
            frmXoa.btnXoa_click += new EventHandler(NhanSuKienClick);
            frmXoa.ShowDialog();
            
        }

        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}
