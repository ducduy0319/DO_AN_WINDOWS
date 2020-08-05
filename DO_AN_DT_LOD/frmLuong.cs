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

using DevExpress.XtraEditors.NavigatorButtons;

namespace DO_AN_DT_LOD
{
    public partial class frmLuong : DevExpress.XtraEditors.XtraForm
    {
        public frmLuong()
        {
            InitializeComponent();
        }
        XLNHANVIEN tblNhanVien;
        XLCHAMCONG tblChamCong;

        BindingManagerBase DSNV;
        bool capnhat = false;

        private void frmLuong_Load(object sender, EventArgs e)
        {

            tblNhanVien = new XLNHANVIEN();
            tblChamCong = new XLCHAMCONG();

            loadHoaDon();
            LoadHoaDon();

            tinhtien();
            cbMaNV();
            ////BdpDB_PositionChange(sender, e);
            enableButton();
        }
        private void LoadHoaDon()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblChamCong,tblNhanVien });
            DataRelation qh = new DataRelation("FPK_NHANVIEN_CHAMCONG", tblNhanVien.Columns["ma_nv"], tblChamCong.Columns["ma_nv"]);
            ds.Relations.Add(qh);
            DataColumn cot_ten = new DataColumn("ten_nv", Type.GetType("System.String"), "Parent(FPK_NHANVIEN_CHAMCONG).ten_nv");
            tblChamCong.Columns.Add(cot_ten);
     
        }
        private void loadHoaDon()
        {
            txtmacong.DataBindings.Add("text", tblChamCong, "ma_cong", true);
            cbmanv.DataBindings.Add("text", tblChamCong, "ma_nv", true);
            txtTenNV.DataBindings.Add("text", tblNhanVien, "ten_nv", true);
            txtgiolam.DataBindings.Add("text", tblChamCong, "thoigianlam", true);
            txtluongcoban.DataBindings.Add("text", tblChamCong, "luongcoban", true);
            txtThanhTien.DataBindings.Add("text", tblChamCong, "luong", true);

            //txtTenNV.DataBindings.Add("text", tblHoaDon_CT, "SoLuong", true);
            //txtgiolam.DataBindings.Add("selectedvalue", tblHoaDon_CT, "MaSP", true);
            //DSHD = this.BindingContext[tblHoaDon_CT];
            dsnhanvien.AutoGenerateColumns = false;
            dsnhanvien.DataSource = tblChamCong;

        }

        private void tinhtien()
        {

            for (int r = 0; r < dsnhanvien.Rows.Count; r++)
            {
                dsnhanvien.Rows[r].Cells[6].Value = Convert.ToInt32(dsnhanvien.Rows[r].Cells[4].Value) * Convert.ToInt32(dsnhanvien.Rows[r].Cells[5].Value);
                txtThanhTien.Text = dsnhanvien.Rows[r].Cells[6].Value.ToString();

            }

        }

        private void cbMaNV()
        {
            cbmanv.DataSource = tblNhanVien;
            cbmanv.ValueMember = "ma_nv";
            cbmanv.DisplayMember = "ma_nv";
            cbmanv.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbmanv.AutoCompleteSource = AutoCompleteSource.ListItems;
        }


        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            //chua chay duoc
            if (radMa.Checked == true)
            {
                string std = string.Format("ma_nv like '%{0}%'", txtTimKiem.Text);
                tblChamCong.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("ten_nv like '%{0}%'", txtTimKiem.Text);
                tblChamCong.DefaultView.RowFilter = std;
            }

        }

        private void enableButton()
        {
            btnThem.Enabled = !capnhat;
            btnSua.Enabled = !capnhat;
            btnXoa.Enabled = !capnhat;
            btnThoat.Enabled = !capnhat;

            btnLuu.Enabled = capnhat;
            btnHuy.Enabled = capnhat;
        }
        private void radMa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radTimTheoTen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dsnhanvien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dsnhanvien.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                DSNV.AddNew();

                //BdpDB_PositionChange(sender, e);
                capnhat = true;
                enableButton();
                MessageBox.Show("B?n có mu?n Thêm không!!!");
            }
            catch (Exception ex)
            {
                tblChamCong.RejectChanges();
                MessageBox.Show(ex.Message);
            }
        }
    }
}