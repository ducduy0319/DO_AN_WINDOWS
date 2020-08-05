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
    public partial class frmLuongNV : DevExpress.XtraEditors.XtraForm
    {
        public string ma_nv;
        public frmLuongNV()
        {
            InitializeComponent();
        }

        private void frmLuongNV_Load(object sender, EventArgs e)
        {
            string query = "SELECT CHAMCONG.ngaylamviec, CHAMCONG.thoigianlam, CHAMCONG.luongcoban, NHANVIEN.ten_nv, CHAMCONG.thoigianlam * CHAMCONG.luongcoban AS LuongThucLinh FROM CHAMCONG INNER JOIN NHANVIEN ON CHAMCONG.ma_nv = NHANVIEN.ma_nv where NHANVIEN.ma_nv = '" + ma_nv + "'";
         

            SqlDataAdapter da = new SqlDataAdapter(query, XLBANG.cnnStr);
            try
            {
                DataTable tblThanhToan = new DataTable();
                da.Fill(tblThanhToan);
                rptLuongNV rpt = new rptLuongNV();
                rpt.SetDataSource(tblThanhToan);
                rptvLuongNV.ReportSource = rpt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}