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
    public partial class frmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        XLNHANVIEN tblNhanVien;
        BindingManagerBase DSTK;

        bool capnhat = false;

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            DSTK = this.BindingContext[tblNhanVien];
            loadnhanvien();
        }

        private void loadnhanvien()
        {
            dsNhanVien.AutoGenerateColumns = false;
            dsNhanVien.DataSource = tblNhanVien;

            txtMaNV.DataBindings.Add("text", tblNhanVien, "ma_nv", true);
            txtTenNV.DataBindings.Add("text", tblNhanVien, "ten_nv", true);
            radnam.DataBindings.Add("checked", tblNhanVien, "gioitinh", true);

            txtTTK.DataBindings.Add("text", tblNhanVien, "UserName", true);
            txtMK.DataBindings.Add("text", tblNhanVien, "Password", true);
            txtLTK.DataBindings.Add("text", tblNhanVien, "MaLTK", true);

            DSTK = this.BindingContext[tblNhanVien];

            enableButton();
        }

        private void enableButton()
        {
            btnLuu.Enabled = capnhat;
            btnSua.Enabled = !capnhat;
            btnThem.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            btnthoat.Enabled = !capnhat;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSTK.AddNew();
            capnhat = false;
            enableButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSTK.RemoveAt(DSTK.Position);
                tblNhanVien.ghi();
                tblNhanVien.AcceptChanges();

            }
            catch (SqlException ex)
            {
                tblNhanVien.RejectChanges();
                MessageBox.Show("xóa thất bại !!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = false;
            enableButton();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                tblNhanVien.ghi();
                tblNhanVien.AcceptChanges();
                capnhat = false;
                enableButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radnam_CheckedChanged(object sender, EventArgs e)
        {
            radnu.Checked = !radnam.Checked;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSTK.CancelCurrentEdit();
            tblNhanVien.RejectChanges();
            capnhat = true;
            enableButton();
        }
    }
}