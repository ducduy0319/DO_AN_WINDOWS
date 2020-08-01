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
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        DataTable tblNHANVIEN, tblNHA_CC, tblPHIEUNHAP;
        SqlDataAdapter daNHANVIEN, daNHA_CC, daPHIEUNHAP;
        BindingManagerBase DSPN;
        bool capnhat = false;

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            tblNHANVIEN = new DataTable();
            daNHANVIEN = new SqlDataAdapter("select * from NHANVIEN", XLBANG.cnnStr);
            tblNHA_CC = new DataTable();
            daNHA_CC = new SqlDataAdapter("select * from NHA_CC", XLBANG.cnnStr);
            tblPHIEUNHAP = new DataTable();
            daPHIEUNHAP = new SqlDataAdapter("select * from PHIEUNHAP", XLBANG.cnnStr);

            try
            {
                daNHANVIEN.Fill(tblNHANVIEN);
                daNHA_CC.Fill(tblNHA_CC);
                daPHIEUNHAP.Fill(tblPHIEUNHAP);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daNHANVIEN);
            var cmd1 = new SqlCommandBuilder(daNHA_CC);
            var cmd2 = new SqlCommandBuilder(daPHIEUNHAP);

            LoadNHANVIEN();
            LoadNHA_CC();
            loadPHIEUNHAP();

            txtSPN.DataBindings.Add("text", tblPHIEUNHAP, "sophieuphap", true);
            dtNgayPN.DataBindings.Add("value", tblPHIEUNHAP, "ngayphieunhap", true);
            txtNCC.DataBindings.Add("text", tblPHIEUNHAP, "ma_ncc", true);
            txtMaNV.DataBindings.Add("text", tblPHIEUNHAP, "ma_nv", true);
            txtNoiDung.DataBindings.Add("text", tblPHIEUNHAP, "noidung", true);
            DSPN = this.BindingContext[tblPHIEUNHAP];
            enableButton();

        }
        private void LoadNHANVIEN()
        {
            txtMaNV.DataSource = tblNHANVIEN;
            txtMaNV.DisplayMember = "ma_nv";
            txtMaNV.ValueMember = "ma_nv";

        }
        private void LoadNHA_CC()
        {
            txtNCC.DataSource = tblNHA_CC;
            txtNCC.DisplayMember = "ma_ncc";
            txtNCC.ValueMember = "ma_ncc";

        }
        private void loadPHIEUNHAP()
        {
            dsphieunhap.AutoGenerateColumns = false;
            dsphieunhap.DataSource = tblPHIEUNHAP;
        }

        private void dsphieunhap_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dsphieunhap.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radMa.Checked == true)
            {
                string std = string.Format("sophieuphap like '%{0}%'", txtTimKiem.Text);
                tblPHIEUNHAP.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("ma_ncc like '%{0}%'", txtTimKiem.Text);
                tblPHIEUNHAP.DefaultView.RowFilter = std;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSPN.AddNew();
            capnhat = true;
            enableButton();
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
                if (MessageBox.Show("Bạn có muốn xóa sách " + txtSPN.Text + " không?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DSPN.RemoveAt(DSPN.Position);
                    capnhat = false;
                    daPHIEUNHAP.Update(tblPHIEUNHAP);

                    tblPHIEUNHAP.AcceptChanges();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (SqlException ex)
            {
                //sửa lại cần thông bào trước khi xóa
                tblPHIEUNHAP.RejectChanges();
                MessageBox.Show("xóa thất bại !!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSPN.EndCurrentEdit();
                daPHIEUNHAP.Update(tblPHIEUNHAP);
                tblPHIEUNHAP.AcceptChanges();
                capnhat = false;
                enableButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSPN.CancelCurrentEdit();
            tblPHIEUNHAP.RejectChanges();
            capnhat = false;
            enableButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
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
        private void txtMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}