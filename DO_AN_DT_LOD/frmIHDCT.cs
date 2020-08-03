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
    public partial class frmIHDCT : DevExpress.XtraEditors.XtraForm
    {
        public frmIHDCT()
        {
            InitializeComponent();
        }

        private void frmIHDCT_Load(object sender, EventArgs e)
        {
            string query = "SELECT sohoadonct, sohoadon, ma_sp, ten_sp, soluong, dongia, soluong*dongia as thanhtien FROM HOADONCT";

            SqlDataAdapter da = new SqlDataAdapter(query, XLBANG.cnnStr);
            try
            {
                DataTable tblThanhToan = new DataTable();
                da.Fill(tblThanhToan);
                rptIHD rpt = new rptIHD();
                rpt.SetDataSource(tblThanhToan);
                rptvIHDCT.ReportSource = rpt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}