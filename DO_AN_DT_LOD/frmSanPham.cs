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
    public partial class frmSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        DataTable tblSANPHAM, tblLOAI_SP;
        SqlDataAdapter daSANPHAM, daLOAI_SP;
        BindingManagerBase DSSP;
        bool capnhat = false;

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            tblSANPHAM = new DataTable();
            daSANPHAM = new SqlDataAdapter("select * from SANPHAM", XLBANG.cnnStr);
            tblLOAI_SP = new DataTable();
            daLOAI_SP = new SqlDataAdapter("select * from LOAI_SP", XLBANG.cnnStr);

            try
            {
                daSANPHAM.Fill(tblSANPHAM);
                daLOAI_SP.Fill(tblLOAI_SP);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daSANPHAM);
            var cmd = new SqlCommandBuilder(daLOAI_SP);

            LoadSANPHAM();
            LoadLOAI_SP();

            txtMaSP.DataBindings.Add("text", tblSANPHAM, "ma_sp", true);
            txtTenSP.DataBindings.Add("text", tblSANPHAM, "ten_sp", true);
            txtDonGia.DataBindings.Add("text", tblSANPHAM, "dongia", true);
            cbDVT.DataBindings.Add("text", tblSANPHAM, "donvitinh", true);
            txtMaLoai.DataBindings.Add("text", tblSANPHAM, "ma_loai", true);//selectedValue
            DSSP = this.BindingContext[tblSANPHAM];
            enableButton();

        }
        private void LoadSANPHAM()
        {
            dsSanPham.AutoGenerateColumns = false;
            dsSanPham.DataSource = tblSANPHAM;
        }
        private void LoadLOAI_SP()
        {
            txtMaLoai.DataSource = tblLOAI_SP;
            txtMaLoai.DisplayMember = "ma_loai";
            txtMaLoai.ValueMember = "ma_loai";
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSSP.AddNew();
            capnhat = true;
            enableButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa sách " + txtMaSP.Text + " không?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DSSP.RemoveAt(DSSP.Position);
                    capnhat = false;
                    daSANPHAM.Update(tblSANPHAM);

                    tblSANPHAM.AcceptChanges();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (SqlException ex)
            {
                //sửa lại cần thông bào trước khi xóa
                tblSANPHAM.RejectChanges();
                MessageBox.Show("xóa thất bại !!!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enableButton();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSSP.EndCurrentEdit();
                daSANPHAM.Update(tblSANPHAM);
                tblSANPHAM.AcceptChanges();
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
            DSSP.CancelCurrentEdit();
            tblSANPHAM.RejectChanges();
            capnhat = false;
            enableButton();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dsSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dsSanPham.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
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

        private void radMa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radTimTheoTen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}