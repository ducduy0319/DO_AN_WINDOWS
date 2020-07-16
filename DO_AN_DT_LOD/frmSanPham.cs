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
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        XLSANPHAM tblSanPham;
        BindingManagerBase DSSP;
        bool capnhat = false;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {

            tblSanPham = new XLSANPHAM();
            DSSP = this.BindingContext[tblSanPham];
            loadsanpham();
        }
        private void loadsanpham()
        {
           dsSanPham.AutoGenerateColumns = false;
            dsSanPham.DataSource = tblSanPham;
            txtMaSP.DataBindings.Add("text", tblSanPham, "ma_sp", true);
            txtTenSP.DataBindings.Add("text", tblSanPham, "ten_sp", true);
            txtDonGia.DataBindings.Add("text", tblSanPham, "dongia", true);
            cbDVT.DataBindings.Add("text", tblSanPham, "donvitinh", true);
            txtMaLoai.DataBindings.Add("text", tblSanPham, "ma_loai", true);
            DSSP = this.BindingContext[tblSanPham];
            enableButton();

        }
        private void enableButton()
        {
            btnLuu.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            btnThem.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            btnThoat.Enabled = !capnhat;
            btnHuy.Enabled = !capnhat;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSSP.AddNew();
            capnhat = true;
            enableButton();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSSP.RemoveAt(DSSP.Position);
        
                tblSanPham.ghi();
                tblSanPham.AcceptChanges();
            }
            catch (SqlException ex)
            {
                tblSanPham.RejectChanges();
                MessageBox.Show("xóa thất bại !!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enableButton();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                tblSanPham.ghi();
                tblSanPham.AcceptChanges();
                capnhat = false;
                enableButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow r = tblSanPham.Select("ma_sp='" + txttimkiem.Text + "'")[0];
                DSSP.Position = tblSanPham.Rows.IndexOf(r);

            }
            catch (Exception ex)
            {
                MessageBox.Show("không có kết quả");
            }
        }

        private void txttimkiem_MouseDown(object sender, MouseEventArgs e)
        {
            txttimkiem.Text = "";
        }

        private void txttimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btntimkiem_Click(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSSP.CancelCurrentEdit();
            tblSanPham.RejectChanges();
            capnhat = true;
            enableButton();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dsSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dsSanPham.Rows)
                r.Cells[0].Value = r.Index + 1;
        }
    }
}