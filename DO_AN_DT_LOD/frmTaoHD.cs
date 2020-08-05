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
    public partial class frmTaoHD : DevExpress.XtraEditors.XtraForm
    {
        public frmTaoHD()
        {
            InitializeComponent();
        }
        XLHOADONCT tblHoaDonCT;
        XLSANPHAM tblSanPham;

        BindingManagerBase DSSP;
        bool capnhat = false;

        private void frmTaoHD_Load(object sender, EventArgs e)
        {
            tblHoaDonCT = new XLHOADONCT();
            tblSanPham = new XLSANPHAM();

            LoadHoaDon();

            //tinhtien();
            //cbMaNV();
            ////BdpDB_PositionChange(sender, e);
            //enableButton();
        }

        private void LoadHoaDon()
        {
            //DataSet ds = new DataSet();
            //ds.Tables.AddRange(new DataTable[] { tblChamCong, tblNhanVien });
            //DataRelation qh = new DataRelation("FPK_NHANVIEN_CHAMCONG", tblNhanVien.Columns["ma_nv"], tblChamCong.Columns["ma_nv"]);
            //ds.Relations.Add(qh);
            //DataColumn cot_ten = new DataColumn("ten_nv", Type.GetType("System.String"), "Parent(FPK_NHANVIEN_CHAMCONG).ten_nv");
            //tblChamCong.Columns.Add(cot_ten);

            //DSSP = this.BindingContext[tblHoaDonCT];
            //ds.AutoGenerateColumns = false;
            //ds.DataSource = tblHoaDonCT;

        }
    }
}