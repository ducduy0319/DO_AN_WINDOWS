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
    public partial class frmXemSanPham : DevExpress.XtraEditors.XtraForm
    {

        // chú ý cột số lượng đang bị lỗi logic
        public frmXemSanPham()
        {
            InitializeComponent();
        }

        //XLSANPHAM tblSanPham;

        DataTable tblSANPHAM;
        SqlDataAdapter daSANPHAM;
        BindingManagerBase DSHD;
        private void frmXemSanPham_Load(object sender, EventArgs e)
        {
            tblSANPHAM = new DataTable();
            daSANPHAM= new SqlDataAdapter("SELECT SANPHAM.ma_sp,SANPHAM.ten_sp,SANPHAM.ma_loai ,SANPHAM.donvitinh,SANPHAM.dongia,PHIEUNHAP_CT.soluong, PHIEUNHAP_CT.soluong - HOADONCT.soluong as N'tonkho' FROM PHIEUNHAP_CT,SANPHAM, HOADONCT WHERE PHIEUNHAP_CT.ma_sp = SANPHAM.ma_sp AND SANPHAM.ma_sp = HOADONCT.ma_sp", XLBANG.cnnStr);
          

            try
            {
                daSANPHAM.Fill(tblSANPHAM);
        

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daSANPHAM);

           // tblSANPHAM = new XLSANPHAM();
            DSHD = this.BindingContext[tblSANPHAM];
            LoadDSSANPHAM();
            //LoadPHIEUNHAP_CT();
            
        }

        private void dgvDSHD_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSSP.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

       

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radMa.Checked == true)
            {
                string std = string.Format("ma_sp like '%{0}%'", txtTimKiem.Text);
                tblSANPHAM.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("ten_sp like '%{0}%'", txtTimKiem.Text);
                tblSANPHAM.DefaultView.RowFilter = std;
            }
        }

        private void LoadDSSANPHAM()
        {
            dgvDSSP.AutoGenerateColumns = false;
            dgvDSSP.DataSource = tblSANPHAM;
        }
    }
}