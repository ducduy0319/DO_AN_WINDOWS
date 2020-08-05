using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;
using DO_AN_DT_LOD.Modules;


namespace DO_AN_DT_LOD
{
    public partial class frmTaoHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoHoaDon()
        {
            InitializeComponent();
        }
        XLNHANVIEN tblNhanVien;
        XLHOADON tblHoaDon;
        XLHOADONCT tblHoaDonCT;
        BindingManagerBase DSHD;
        BindingManagerBase DSHDCT;
        bool capnhat = false;

        private void frmTaoHoaDon_Load(object sender, EventArgs e)
        {
            tblHoaDonCT = new XLHOADONCT();
            tblNhanVien = new XLNHANVIEN();
            tblHoaDon = new XLHOADON();

            LoadHoaDon();
            LoadHoaDonCT();
            //cbMaSP();
            //cbMaKH();
            //cbMaNV();
            //tinhtien();
            ////BdpDB_PositionChange(sender, e);
            //ennableButton();


        }

        private void LoadHoaDon()
        {

            //DataSet ds = new DataSet();
            //ds.Tables.AddRange(new DataTable[] { tblNhanVien, tblHoaDon, tblHoaDonCT });
            //DataRelation qh = new DataRelation("FPK_NHANVIEN_HOADON", tblNhanVien.Columns["ma_nv"], tblHoaDon.Columns["ma_nv"]);
            //DataRelation qx = new DataRelation("FPK_HOADON_HOADONCT", tblHoaDon.Columns["sohoadon"], tblHoaDonCT.Columns["sohoadon"]);
            //ds.Relations.Add(qx);
            //ds.Relations.Add(qh);

            //DataColumn cot_DonGia = new DataColumn("DonGia", Type.GetType("System.String"), "Parent(FPK_SANPHAM_HOADON_CT).DonGia");
            //tblHoaDon_CT.Columns.Add(cot_DonGia);
            //DataColumn cot_TenSP = new DataColumn("TenSP", Type.GetType("System.String"), "Parent(FPK_SANPHAM_HOADON_CT).TenSP");
            //tblHoaDon_CT.Columns.Add(cot_TenSP);
            //DataColumn cot_MaKH = new DataColumn("MaKH", Type.GetType("System.String"), "Parent(FPK_HOADON_HOADON_CT).MaKH");
            //tblHoaDon_CT.Columns.Add(cot_MaKH);
            //DataColumn cot_MaNV = new DataColumn("MaNV", Type.GetType("System.String"), "Parent(FPK_HOADON_HOADON_CT).MaNV");
            //tblHoaDon_CT.Columns.Add(cot_MaNV);
            //DataColumn cot_NgayHD = new DataColumn("NgayHD", Type.GetType("System.String"), "Parent(FPK_HOADON_HOADON_CT).NgayHD");
            //tblHoaDon_CT.Columns.Add(cot_NgayHD);
            //cot_NgayHD.DefaultValue = DateTime.Now;


            //txtSoHD.DataBindings.Add("text", tblHoaDon_CT, "SoHD", true);
            ////txtThanhTien.DataBindings.Add("text", tblHoaDon_CT, "ThanhTien", true);
            //txtSoLuong.DataBindings.Add("text", tblHoaDon_CT, "SoLuong", true);
            //cboMaSP.DataBindings.Add("selectedvalue", tblHoaDon_CT, "MaSP", true);
            //DSHD = this.BindingContext[tblHoaDon_CT];
            dgvDSHDCT.AutoGenerateColumns = false;
            dgvDSHDCT.DataSource = tblHoaDonCT;
            //DSHD.PositionChanged += new EventHandler(BdpDB_PositionChange);
        }
        private void LoadHoaDonCT()
        {
            //DataSet ds = new DataSet();
            //ds.Tables.AddRange(new DataTable[] { tblNhanVien, tblHoaDon, tblHoaDonCT });
            //DataRelation qh = new DataRelation("FPK_NHANVIEN_HOADON", tblNhanVien.Columns["ma_nv"], tblHoaDon.Columns["ma_nv"]);
            //DataRelation qx = new DataRelation("FPK_HOADON_HOADONCT", tblHoaDon.Columns["sohoadon"], tblHoaDonCT.Columns["sohoadon"]);
            //ds.Relations.Add(qx);
            //ds.Relations.Add(qh);

            //DataColumn cot_DonGia = new DataColumn("DonGia", Type.GetType("System.String"), "Parent(FPK_SANPHAM_HOADON_CT).DonGia");
            //tblHoaDon_CT.Columns.Add(cot_DonGia);
            //DataColumn cot_TenSP = new DataColumn("TenSP", Type.GetType("System.String"), "Parent(FPK_SANPHAM_HOADON_CT).TenSP");
            //tblHoaDon_CT.Columns.Add(cot_TenSP);
            //DataColumn cot_MaKH = new DataColumn("MaKH", Type.GetType("System.String"), "Parent(FPK_HOADON_HOADON_CT).MaKH");
            //tblHoaDon_CT.Columns.Add(cot_MaKH);
            //DataColumn cot_MaNV = new DataColumn("MaNV", Type.GetType("System.String"), "Parent(FPK_HOADON_HOADON_CT).MaNV");
            //tblHoaDon_CT.Columns.Add(cot_MaNV);
            //DataColumn cot_NgayHD = new DataColumn("NgayHD", Type.GetType("System.String"), "Parent(FPK_HOADON_HOADON_CT).NgayHD");
            //tblHoaDon_CT.Columns.Add(cot_NgayHD);
            //cot_NgayHD.DefaultValue = DateTime.Now;

            //txtSoHD.DataBindings.Add("text", tblHoaDon_CT, "SoHD", true);
            ////txtThanhTien.DataBindings.Add("text", tblHoaDon_CT, "ThanhTien", true);
            //txtSoLuong.DataBindings.Add("text", tblHoaDon_CT, "SoLuong", true);
            //cboMaSP.DataBindings.Add("selectedvalue", tblHoaDon_CT, "MaSP", true);
            //DSHD = this.BindingContext[tblHoaDon_CT];
            dgvDSHD.AutoGenerateColumns = false;
            dgvDSHD.DataSource = tblHoaDon;
            //DSHD.PositionChanged += new EventHandler(BdpDB_PositionChange);

        }
    }
}