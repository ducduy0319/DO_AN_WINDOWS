using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DO_AN_DT_LOD
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string maNV;
        public frmMain()
        {
            InitializeComponent();
        }

        public void enableControl(int maLTK)
        {
            switch (maLTK)
            {
                case 1: //admin
                    //Quản lý bán hàng
                    btnDangXuat.Enabled = true;
                    btnDoiMatKhau.Enabled = true;
                    btnXemSanPham.Enabled = true;
                    btnKhachHang.Enabled = true;
                    btnDonHang.Enabled = true;
                    btnTaoHoaDon.Enabled = true;
                    btnTimKiem.Enabled = true;
                    btnUngDung.Enabled = true;

                    //Quản lý hàng hóa
                    btnPhieuNhap.Enabled = true;
                    btnLSanPham.Enabled = true;
                    btnSanPham.Enabled = true;

                    //Quản lý doanh thu
                    btnTKTThang.Enabled = true;
                    btnTKTTuan.Enabled = true;
                    btnTKTNgay.Enabled = true;

                    //Quản lý nhân viên
                    btnNhanVien1.Enabled = true;
                    btnChamCong.Enabled = true;
                    btnPhanCong.Enabled = true;
                    btnXemPhanCong.Enabled = true;

                    break;

                default: //Nhan vien ban hang
                    //Quản lý bán hàng
                    btnDangXuat.Enabled = true;
                    btnDoiMatKhau.Enabled = true;
                    btnXemSanPham.Enabled = true;
                    btnKhachHang.Enabled = true;
                    btnDonHang.Enabled = true;
                    btnTaoHoaDon.Enabled = true;
                    btnTimKiem.Enabled = true;
                    btnUngDung.Enabled = true;

                    //Quản lý hàng hóa
                    btnPhieuNhap.Enabled = false;
                    btnLSanPham.Enabled = false;
                    btnSanPham.Enabled = false;

                    //Quản lý doanh thu
                    btnTKTThang.Enabled = false;
                    btnTKTTuan.Enabled = false;
                    btnTKTNgay.Enabled = false;

                    //Quản lý nhân viên
                    btnNhanVien1.Enabled = false;
                    btnChamCong.Enabled = false;
                    btnPhanCong.Enabled = false;
                    btnXemPhanCong.Enabled = true;

                    break;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            enableControl(-1);
            frmDangNhap f = new frmDangNhap(this);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
            frmMain_Load(sender, e);
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            int index = tabBanhang.TabPages.IndexOfKey("tabPadeDoiMatKhau");
            if (index >= 0)
            {
                tabBanhang.SelectedIndex = index;
            }
            else
            {
                frmDoiMatKhau f = new frmDoiMatKhau(maNV);
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPadeDoiMatKhau";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabBanhang.TabPages.Add(p);
                tabBanhang.SelectedTab = p;
                f.Show();
            }
            
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabBanhang.TabPages.IndexOfKey("tabPadeDS_nhanvien");
            if (index >= 0)
            {
                tabBanhang.SelectedIndex = index;
            }
            else
            {
                DS_nhanvien f = new DS_nhanvien();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPadeNhanVien";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabBanhang.TabPages.Add(p);
                tabBanhang.SelectedTab = p;
                f.Show();
            }

        }

        private void btnSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabBanhang.TabPages.IndexOfKey("tabPadeSanPham");
            if (index >= 0)
            {
                tabBanhang.SelectedIndex = index;
            }
            else
            {
                frmSanPham f = new frmSanPham();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPadeSanPham";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabBanhang.TabPages.Add(p);
                tabBanhang.SelectedTab = p;
                f.Show();
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            int index = tabBanhang.TabPages.IndexOfKey("tabPadePhieuNhap");
            if (index >= 0)
            {
                tabBanhang.SelectedIndex = index;
            }
            else
            {
                frmPhieuNhap f = new frmPhieuNhap();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPadePhieuNhap";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabBanhang.TabPages.Add(p);
                tabBanhang.SelectedTab = p;
                f.Show();
            }

        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUngDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDonHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int index = tabBanhang.TabPages.IndexOfKey("tabPadeHoaDon");
            if (index >= 0)
            {
                tabBanhang.SelectedIndex = index;
            }
            else
            {
                HoaDon f = new HoaDon();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPadeHoaDon";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabBanhang.TabPages.Add(p);
                tabBanhang.SelectedTab = p;
                f.Show();
            }
        }
    }
    
}
