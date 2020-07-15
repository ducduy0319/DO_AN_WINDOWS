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
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        XLPHIEUNHAP tblPhieuNhap;
        XLNHANVIEN  tblNhanVien;
        XLNCC tblNCC;
        BindingManagerBase DSPN;
        bool capnhat = false;
        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            tblPhieuNhap = new XLPHIEUNHAP();
            tblNCC = new XLNCC();
            loadnhanvien();
            cbNhanVien();
            cbNCC();
            DSPN = this.BindingContext[tblPhieuNhap];
            enableButton();
        }
        private void cbNCC()
        {
            cbMaNCC.DataSource = tblNCC;
            cbMaNCC.DisplayMember = "ma_ncc";
            cbMaNCC.ValueMember = "ma_ncc";
        }
        private void loadnhanvien()
        {

            txtPhieuNhap.DataBindings.Add("text", tblPhieuNhap, "sophieuphap", true);
            txtNgayNhap.DataBindings.Add("text", tblPhieuNhap, "ngayphieunhap", true);
            cbMaNCC.DataBindings.Add("selectedvalue", tblPhieuNhap, "ma_ncc", true);
            txtNoiDung.DataBindings.Add("text", tblPhieuNhap, "noidung", true);
            cboNV.DataBindings.Add("selectedvalue", tblPhieuNhap, "ma_nv", true);
            dsphieunhap.AutoGenerateColumns = false;
            dsphieunhap.DataSource = tblPhieuNhap;
        }
        private void cbNhanVien()
        {
            cboNV.DataSource = tblNhanVien;
            cboNV.DisplayMember = "ma_nv";
            cboNV.ValueMember = "ma_nv";
        }
        private void enableButton()
        {
            btnSua.Enabled = !capnhat;
            btnThem.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            btnThoat.Enabled = !capnhat;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSPN.AddNew();
            capnhat = true;
            enableButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSPN.RemoveAt(DSPN.Position);
                tblPhieuNhap.ghi();
                tblPhieuNhap.AcceptChanges();

            }
            catch (SqlException ex)
            {
                tblPhieuNhap.RejectChanges();
                MessageBox.Show("xóa thất bại !!!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enableButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }
    }
}