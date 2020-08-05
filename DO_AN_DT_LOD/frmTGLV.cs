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
    public partial class frmTGLV : DevExpress.XtraEditors.XtraForm
    {
        public frmTGLV()
        {
            InitializeComponent();
        }
        XLNHANVIEN tblNhanVien;
        XLTGLV tblTGLV;

        BindingManagerBase DSNV;
        bool capnhat = false;


        private void frmTGLV_Load(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            tblTGLV = new XLTGLV();

            LoadTGLV();

            cbMaNV();
            enableButton();
        }
        private void LoadTGLV()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblTGLV, tblNhanVien });
            DataRelation qh = new DataRelation("FPK_NHANVIEN_TGLV", tblNhanVien.Columns["ma_nv"], tblTGLV.Columns["ma_nv"]);
            ds.Relations.Add(qh);
            DataColumn cot_ten = new DataColumn("ten_nv", Type.GetType("System.String"), "Parent(FPK_NHANVIEN_TGLV).ten_nv");
            tblTGLV.Columns.Add(cot_ten);

            txtPCCV.DataBindings.Add("text", tblTGLV, "ma_TGLV", true);
            cbtMaNV.DataBindings.Add("text", tblTGLV, "ma_nv", true);
            txtTenSP.DataBindings.Add("text", tblNhanVien, "ten_nv", true);
            txtca.DataBindings.Add("text",tblTGLV, "ca", true);
            txtThu.DataBindings.Add("text", tblTGLV, "thu", true);

            DSNV = this.BindingContext[tblTGLV];
            dsCLV.AutoGenerateColumns = false;
            dsCLV.DataSource = tblTGLV;

        }
        private void cbMaNV()
        {
            cbtMaNV.DataSource = tblNhanVien;
            cbtMaNV.ValueMember = "ma_nv";
            cbtMaNV.DisplayMember = "ma_nv";
            cbtMaNV.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbtMaNV.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void enableButton()
        {
            btnThem.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            btnThoat.Enabled = !capnhat;

            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                DSNV.AddNew();
                capnhat = true;
                enableButton();
            }
            catch (Exception ex)
            {
                tblTGLV.RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enableButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSNV.RemoveAt(DSNV.Position);
                tblTGLV.ghi();

                tblTGLV.AcceptChanges();
                capnhat = true;
                enableButton();

            }
            catch (SqlException)
            {
                tblTGLV.RejectChanges();
                MessageBox.Show("Xóa Thành Công!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSNV.EndCurrentEdit();
                tblTGLV.ghi();

                tblTGLV.AcceptChanges();
                MessageBox.Show("Cập Nhật thành công!!!");
                capnhat = false;
                enableButton();
            }
            catch (Exception ex)
            {
                tblTGLV.RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSNV.CancelCurrentEdit();
            tblTGLV.RejectChanges();
            capnhat = false;
            enableButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void dsCLV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dsCLV.Rows)
                r.Cells[0].Value = r.Index + 1;
        }
    }
}