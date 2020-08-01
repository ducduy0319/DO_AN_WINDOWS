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
    public partial class HoaDon : DevExpress.XtraEditors.XtraForm
    {
 
        public HoaDon()
        {
            InitializeComponent();
        }
        DataTable tblHOADON, tblNHANVIEN;
        SqlDataAdapter daHOADON, daNHANVIEN;
        BindingManagerBase DSHD;
        bool capnhat = false;
        private void HoaDon_Load(object sender, EventArgs e)
        {
            tblHOADON = new DataTable();
            daHOADON = new SqlDataAdapter("select * from HOADON", XLBANG.cnnStr);
            tblNHANVIEN = new DataTable();
            daNHANVIEN = new SqlDataAdapter("select * from NHANVIEN", XLBANG.cnnStr);
            
            
            try
            {
                daHOADON.Fill(tblHOADON);
                daNHANVIEN.Fill(tblNHANVIEN);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daHOADON);
            LoadHOADON();
            LoadDSNHANVIEN();
            txtNgHD.DataBindings.Add("text", tblHOADON, "ngayhoadon", true);
            txtnoidung.DataBindings.Add("text", tblHOADON, "noidung", true);
            txtSHD.DataBindings.Add("text", tblHOADON, "sohoadon", true);
            cbma_nv.DataBindings.Add("selectedValue", tblHOADON, "ma_nv", true);

            DSHD = this.BindingContext[tblHOADON];
            enabledButton();
        }
        private void LoadDSNHANVIEN()
        {
            dgvDSHD.AutoGenerateColumns = false;
            dgvDSHD.DataSource = tblHOADON;
        }

      
        private void dgvDSHD_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSHD.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
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
                if (MessageBox.Show("Bạn có muốn xóa sách " + txtSHD.Text + " không?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DSHD.RemoveAt(DSHD.Position);
                    capnhat = false;
                    daHOADON.Update(tblHOADON);

                    tblHOADON.AcceptChanges();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (SqlException ex)
            {
                //sửa lại cần thông bào trước khi xóa
                tblHOADON.RejectChanges();
                MessageBox.Show("xóa thất bại !!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSHD.EndCurrentEdit();
                daHOADON.Update(tblHOADON);
                tblHOADON.AcceptChanges();
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
            tblHOADON.RejectChanges();
            capnhat = false;
            enabledButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void cbma_nv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radMa.Checked == true)
            {
                string std = string.Format("ma_nv like '%{0}%'", txtTimKiem.Text);
                tblHOADON.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("sohoadon like '%{0}%'", txtTimKiem.Text);
                tblHOADON.DefaultView.RowFilter = std;
            }
        }

        private void radTimTheoTen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LoadHOADON()
        {
            cbma_nv.DataSource = tblNHANVIEN;
            cbma_nv.DisplayMember = "ma_nv";
            cbma_nv.ValueMember = "ma_nv";
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

    }
}