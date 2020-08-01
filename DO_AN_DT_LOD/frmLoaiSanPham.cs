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
    public partial class frmLoaiSanPham : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        DataTable tblLOAI_SP;
        SqlDataAdapter daLOAI_SP;
        BindingManagerBase DSHD;
        bool capnhat = false;
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            tblLOAI_SP = new DataTable();
            daLOAI_SP = new SqlDataAdapter("select * from LOAI_SP", XLBANG.cnnStr);
            try
            {
                daLOAI_SP.Fill(tblLOAI_SP);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daLOAI_SP);
            LoadLOAI_SP();

            txtLSP.DataBindings.Add("text", tblLOAI_SP, "ma_loai", true);
            txtghichu.DataBindings.Add("text", tblLOAI_SP, "ghichu", true);
            txtTenLSP.DataBindings.Add("text", tblLOAI_SP, "ten_loai", true);
   

            DSHD = this.BindingContext[tblLOAI_SP];
            enabledButton();
        }

        private void LoadLOAI_SP()
        {
            dgvDSHD.AutoGenerateColumns = false;
            dgvDSHD.DataSource = tblLOAI_SP;
        }
        private void enabledButton()
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
            DSHD.AddNew();
            capnhat = true;
            enabledButton();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capnhat = true;
            enabledButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa sách " + txtLSP.Text + " không?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DSHD.RemoveAt(DSHD.Position);
                    capnhat = false;
                    daLOAI_SP.Update(tblLOAI_SP);

                    tblLOAI_SP.AcceptChanges();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (SqlException ex)
            {
                //sửa lại cần thông bào trước khi xóa
                tblLOAI_SP.RejectChanges();
                MessageBox.Show("xóa thất bại !!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSHD.EndCurrentEdit();
                daLOAI_SP.Update(tblLOAI_SP);
                tblLOAI_SP.AcceptChanges();
                capnhat = false;
                enabledButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSHD.CancelCurrentEdit();
            tblLOAI_SP.RejectChanges();
            capnhat = false;
            enabledButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void dgvDSHD_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSHD.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radMa.Checked == true)
            {
                string std = string.Format("ma_loai like '%{0}%'", txtTimKiem.Text);
                tblLOAI_SP.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("ten_loai like '%{0}%'", txtTimKiem.Text);
                tblLOAI_SP.DefaultView.RowFilter = std;
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
    }
}