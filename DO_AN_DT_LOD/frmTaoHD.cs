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
        XLHOADON tblHoaDon;

        BindingManagerBase DSSP;
        bool capnhat = false;

        private void frmTaoHD_Load(object sender, EventArgs e)
        {
            tblHoaDonCT = new XLHOADONCT();
            tblSanPham = new XLSANPHAM();
            tblHoaDon = new XLHOADON();

            LoadHoaDon();

            tinhtien();
            cbMaSP();
            cbMaHD();
            ////BdpDB_PositionChange(sender, e);
            enableButton();
        }

        private void LoadHoaDon()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblSanPham ,tblHoaDonCT });
            DataRelation qh = new DataRelation("FPK_SANPHAM_HOADONCT", tblSanPham.Columns["ma_sp"], tblHoaDonCT.Columns["ma_sp"]);
            ds.Relations.Add(qh);
            //DataColumn cot_ten = new DataColumn("ten_sp", Type.GetType("System.String"), "Parent(FPK_SANPHAM_HOADONCT).ten_sp");
            //tblHoaDonCT.Columns.Add(cot_ten);

            txtHDCT.DataBindings.Add("text", tblHoaDonCT, "sohoadonct", true);
            txtSP.DataBindings.Add("text",tblHoaDonCT, "ma_sp", true);
            txtTenSP.DataBindings.Add("text", tblSanPham, "ten_sp", true);
            txtTenSP1.DataBindings.Add("text", tblHoaDonCT, "ten_sp", true);
            cbmahd.DataBindings.Add("text", tblHoaDonCT, "sohoadon", true);
            txtdongia.DataBindings.Add("text", tblHoaDonCT, "dongia", true);
            txtsoluong.DataBindings.Add("text", tblHoaDonCT, "soluong", true);

            DSSP = this.BindingContext[tblHoaDonCT];
            dsspct.AutoGenerateColumns = false;
            dsspct.DataSource = tblHoaDonCT;

        }
        private void tinhtien()
        {

            for (int r = 0; r < dsspct.Rows.Count; r++)
            {
                dsspct.Rows[r].Cells[7].Value = Convert.ToInt32(dsspct.Rows[r].Cells[5].Value) * Convert.ToInt32(dsspct.Rows[r].Cells[6].Value);
                //txtThanhTien.Text = dsnhanvien.Rows[r].Cells[6].Value.ToString();

            }

        }

        private void cbMaSP()
        {
            txtSP.DataSource = tblSanPham;
            txtSP.ValueMember = "ma_sp";
            txtSP.DisplayMember = "ma_sp";
            txtSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtSP.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cbMaHD()
        {
            cbmahd.DataSource = tblHoaDon;
            cbmahd.ValueMember = "sohoadon";
            cbmahd.DisplayMember = "sohoadon";
            cbmahd.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbmahd.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void enableButton()
        {
            btnThem.Enabled = !capnhat;
         
            btnThoat.Enabled = !capnhat;

            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DSSP.AddNew();
                capnhat = true;
                enableButton();
            }
            catch (Exception ex)
            {
                tblHoaDonCT.RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enableButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSSP.RemoveAt(DSSP.Position);
                tblHoaDonCT.ghi();

                tblHoaDonCT.AcceptChanges();
                capnhat = true;
                enableButton();

            }
            catch (SqlException)
            {
                tblHoaDonCT.RejectChanges();
                MessageBox.Show("Xóa Thành Công!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSSP.EndCurrentEdit();
                tblHoaDonCT.ghi();

                tblHoaDonCT.AcceptChanges();
                MessageBox.Show("Cập Nhật thành công!!!");
                capnhat = false;
                enableButton();
            }
            catch (Exception ex)
            {
                tblHoaDonCT.RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSSP.CancelCurrentEdit();
            tblHoaDonCT.RejectChanges();
            capnhat = false;
            enableButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radMa.Checked == true)
            {
                string std = string.Format("sohoadonct like '%{0}%'", txtTimKiem.Text);
                tblHoaDonCT.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("sohoadon like '%{0}%'", txtTimKiem.Text);
                tblHoaDonCT.DefaultView.RowFilter = std;
            }
        }

        private void dsspct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dsspct.Rows)
                r.Cells[0].Value = r.Index + 1;
        }
    }
}