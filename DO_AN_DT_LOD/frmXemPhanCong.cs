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
    public partial class frmXemPhanCong : DevExpress.XtraEditors.XtraForm
    {
        public frmXemPhanCong()
        {
            InitializeComponent();
        }

        XLNHANVIEN tblNhanVien;
        XLTGLV tblTGLV;

        private void frmXemPhanCong_Load(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            tblTGLV = new XLTGLV();

            LoadTGLV();
            cbMaNV();
        }

        private void LoadTGLV()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblTGLV, tblNhanVien });
            DataRelation qh = new DataRelation("FPK_NHANVIEN_TGLV", tblNhanVien.Columns["ma_nv"], tblTGLV.Columns["ma_nv"]);
            ds.Relations.Add(qh);
            DataColumn cot_ten = new DataColumn("ten_nv", Type.GetType("System.String"), "Parent(FPK_NHANVIEN_TGLV).ten_nv");
            tblTGLV.Columns.Add(cot_ten);

            cbtMaNV.DataBindings.Add("text", tblTGLV, "ma_nv", true);
            txtTenNV.DataBindings.Add("text", tblNhanVien, "ten_nv", true);


        }
        private void cbMaNV()
        {
            cbtMaNV.DataSource = tblNhanVien;
            cbtMaNV.ValueMember = "ma_nv";
            cbtMaNV.DisplayMember = "ma_nv";
            cbtMaNV.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbtMaNV.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            frmThoiGianLV f = new frmThoiGianLV();
            f.ma_nv = cbtMaNV.Text;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }
    }
}