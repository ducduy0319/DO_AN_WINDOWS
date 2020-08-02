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
using DO_AN_DT_LOD.Modules;

namespace DO_AN_DT_LOD
{
    public partial class frmInHD : DevExpress.XtraEditors.XtraForm
    {
        public string sohd;
        public frmInHD()
        {
            InitializeComponent();
        }

        private void frmInHD_Load(object sender, EventArgs e)
        {
            var query= "SELECT HOADON.sohoadon, HOADON.ma_nv, HOADON.ngayhoadon, SANPHAM.ten_sp, HOADONCT.soluong, SANPHAM.dongia, SANPHAM.dongia * HOADONCT.soluong AS ThanhTien"+
" FROM HOADON INNER JOIN HOADONCT ON HOADON.sohoadon = HOADONCT.sohoadon INNER JOIN"+
                        " SANPHAM ON HOADONCT.ma_sp = SANPHAM.ma_sp where HOADON.sohoadon = '" +sohd+ "'";
            
            SqlDataAdapter da = new SqlDataAdapter(query, XLBANG.cnnStr);
            try
            {
                DataTable tblData = new DataTable();
                da.Fill(tblData);
                rptHD rpt = new rptHD();
                rpt.SetDataSource(tblData);
                rplvHD.ReportSource = rpt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}