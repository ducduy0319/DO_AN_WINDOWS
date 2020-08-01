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

        DataTable tblSANPHAM, tblLSP;
        SqlDataAdapter daSANPHAM, dalLSP;
        BindingManagerBase DSHD;
        private void frmXemSanPham_Load(object sender, EventArgs e)
        {
            tblSANPHAM = new DataTable();
            daSANPHAM= new SqlDataAdapter("SELECT SANPHAM.ma_sp,SANPHAM.ten_sp,SANPHAM.ma_loai ,SANPHAM.donvitinh,SANPHAM.dongia,PHIEUNHAP_CT.soluong, PHIEUNHAP_CT.soluong - HOADONCT.soluong as N'tonkho' FROM PHIEUNHAP_CT,SANPHAM, HOADONCT WHERE PHIEUNHAP_CT.ma_sp = SANPHAM.ma_sp AND SANPHAM.ma_sp = HOADONCT.ma_sp", XLBANG.cnnStr);
            tblLSP= new DataTable();
            dalLSP = new SqlDataAdapter("SELECT SANPHAM.ma_sp,SANPHAM.ten_sp,SANPHAM.ma_loai ,SANPHAM.donvitinh,SANPHAM.dongia,PHIEUNHAP_CT.soluong, PHIEUNHAP_CT.soluong - HOADONCT.soluong as N'tonkho' FROM PHIEUNHAP_CT,SANPHAM, HOADONCT WHERE PHIEUNHAP_CT.ma_sp = SANPHAM.ma_sp AND SANPHAM.ma_sp = HOADONCT.ma_sp AND SANPHAM.ma_sp like'%"+txtloc+ "%'", XLBANG.cnnStr);
            /*tblLSP = new DataTable();
            daLSP = new SqlDataAdapter("SELECT SANPHAM.ma_sp,SANPHAM.ten_sp,SANPHAM.ma_loai ,SANPHAM.donvitinh,SANPHAM.dongia,PHIEUNHAP_CT.soluong, PHIEUNHAP_CT.soluong - HOADONCT.soluong as N'tonkho' FROM PHIEUNHAP_CT,SANPHAM, HOADONCT WHERE PHIEUNHAP_CT.ma_sp = SANPHAM.ma_sp AND SANPHAM.ma_sp = HOADONCT.ma_sp AND SANPHAM.ma_sp like'%c%'", XLBANG.cnnStr);
*/

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

        public void loadloc()
        {
            tblLSP = new DataTable();
            dalLSP = new SqlDataAdapter("SELECT SANPHAM.ma_sp,SANPHAM.ten_sp,SANPHAM.ma_loai ,SANPHAM.donvitinh,SANPHAM.dongia,PHIEUNHAP_CT.soluong, PHIEUNHAP_CT.soluong - HOADONCT.soluong as N'tonkho' FROM PHIEUNHAP_CT,SANPHAM, HOADONCT WHERE PHIEUNHAP_CT.ma_sp = SANPHAM.ma_sp AND SANPHAM.ma_sp = HOADONCT.ma_sp AND SANPHAM.ma_sp like'%c%'", XLBANG.cnnStr);
        }

        private void dgvDSHD_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSSP.Rows)
                r.Cells[0].Value = r.Index + 1;
        }


        //lọc
        /*public void loadformtim()
        {
            dgvDSSP.AutoGenerateColumns = false;
            dgvDSSP.DataSource = tblPHIEUNHAP_CT;

        }*/

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow r = tblSANPHAM.Select("ma_sp ='" + txttimkiem.Text + "'")[0];
                DSHD.Position = tblSANPHAM.Rows.IndexOf(r);

            }
            catch (Exception ex)
            {
                MessageBox.Show("không có kết quả");
            }
        }

        private void txttimkiem_MouseDown(object sender, MouseEventArgs e)
        {
            txttimkiem.Text = "";
        }

        private void txttimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btntimkiem_Click(sender, e);
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void btnloc_Click(object sender, EventArgs e)
        {
        }

        private void txtloc_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void txtloc_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void LoadDSSANPHAM()
        {
            dgvDSSP.AutoGenerateColumns = false;
            dgvDSSP.DataSource = tblSANPHAM;
        }
        private void LoadLSP()
        {
            dgvDSSP.AutoGenerateColumns = false;
            dgvDSSP.DataSource = tblLSP;
        }
    }
}