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
    public partial class frmTKDTcs : DevExpress.XtraEditors.XtraForm
    {
        public string Thang;
        public string Nam;
        public frmTKDTcs()
        {
            InitializeComponent();
        }

        private void frmTKDTcs_Load(object sender, EventArgs e)
        {
            var query = "SELECT HOADON.sohoadon, HOADON.ngayhoadon, SUM(HOADONCT.soluong) AS SL, SUM(HOADONCT.soluong * SANPHAM.dongia) AS ThanhTien" +
                " FROM HOADON INNER JOIN HOADONCT ON HOADON.sohoadon = HOADONCT.sohoadon AND HOADON.sohoadon = HOADONCT.sohoadon INNER JOIN"+
                " SANPHAM ON HOADONCT.ma_sp = SANPHAM.ma_sp AND HOADONCT.ma_sp = SANPHAM.ma_sp"+
                 " where MONTH(HOADON.ngayhoadon)= " + Thang + "AND YEAR(HOADON.ngayhoadon)= " + Nam +
                    " GROUP BY HOADON.sohoadon , HOADON.ngayhoadon";
           
            SqlDataAdapter da = new SqlDataAdapter(query, XLBANG.cnnStr);
            try
            {
                DataTable tblData = new DataTable();
               
                da.Fill(tblData);
         
                rptThongKe1 rpt = new rptThongKe1();
                rpt.SetDataSource(tblData);
                rptvTK.ReportSource = rpt;
               
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}