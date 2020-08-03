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
        public string sohoadon;
        public frmIHDCT()
        {
            InitializeComponent();
        }

        private void frmIHDCT_Load(object sender, EventArgs e)
        {
            string query = "SELECT HOADON.sohoadon, HOADON.ma_nv, HOADON.ngayhoadon, HOADONCT.sohoadonct, HOADONCT.ten_sp, HOADONCT.ma_sp, HOADONCT.soluong, HOADONCT.dongia, SANPHAM.ten_sp AS Expr1, SANPHAM.ma_sp AS Expr2, HOADONCT.soluong* HOADONCT.dongia AS thanhtien"+" FROM HOADON INNER JOIN HOADONCT ON HOADON.sohoadon = HOADONCT.sohoadon INNER JOIN" +
                        " SANPHAM ON HOADONCT.ma_sp = SANPHAM.ma_sp where HOADON.sohoadon = '" + sohoadon + "'";

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