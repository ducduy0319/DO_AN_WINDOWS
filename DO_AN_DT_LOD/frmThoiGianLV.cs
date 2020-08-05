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
    public partial class frmThoiGianLV : DevExpress.XtraEditors.XtraForm
    {
        public string ma_nv;
        public frmThoiGianLV()
        {
            InitializeComponent();
        }

        private void frmThoiGianLV_Load(object sender, EventArgs e)
        {
            string query = "SELECT NHANVIEN.ten_nv, TGLV.ma_TGLV, TGLV.ma_nv, TGLV.thu, TGLV.ca FROM TGLV INNER JOIN NHANVIEN ON TGLV.ma_nv = NHANVIEN.ma_nv where NHANVIEN.ma_nv = '" + ma_nv + "'";


            SqlDataAdapter da = new SqlDataAdapter(query, XLBANG.cnnStr);
            try
            {
                DataTable tblThanhToan = new DataTable();
                da.Fill(tblThanhToan);
               rptTGLV rpt = new rptTGLV();
                rpt.SetDataSource(tblThanhToan);
               rptvTGLV.ReportSource = rpt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}