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
    public partial class frmNCC : DevExpress.XtraEditors.XtraForm
    {
        public frmNCC()
        {
            InitializeComponent();
        }
        DataTable tblNCC;
        SqlDataAdapter daNCC;
        BindingManagerBase DSNCCC;
        bool capnhat = false;

        private void frmNCC_Load(object sender, EventArgs e)
        {
            tblNCC = new DataTable();
            daNCC = new SqlDataAdapter("select * from NHA_CC", XLBANG.cnnStr);


            try
            {
                daNCC.Fill(tblNCC);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daNCC);


            LoadNCC();


            txtNCC.DataBindings.Add("text", tblNCC, "ma_ncc", true);
            txtTenNCC.DataBindings.Add("text", tblNCC, "ten_ncc", true);
            txtsdt.DataBindings.Add("text", tblNCC, "sdt", true);
            txtdiachi.DataBindings.Add("text", tblNCC, "diachi", true);
            DSNCCC = this.BindingContext[tblNCC];
            enableButton();

        }
        private void LoadNCC()
        {
            DSCC.AutoGenerateColumns = false;
            DSCC.DataSource = tblNCC;
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
            DSNCCC.AddNew();
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
                if (MessageBox.Show("Bạn có muốn xóa sách " + txtNCC.Text + "không?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DSNCCC.RemoveAt(DSNCCC.Position);
                    capnhat = false;
                    daNCC.Update(tblNCC);

                    tblNCC.AcceptChanges();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (SqlException ex)
            {
                //sửa lại cần thông bào trước khi xóa
                tblNCC.RejectChanges();
                MessageBox.Show("xóa thất bại !!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSNCCC.EndCurrentEdit();
                daNCC.Update(tblNCC);
                tblNCC.AcceptChanges();
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
            DSNCCC.CancelCurrentEdit();
            tblNCC.RejectChanges();
            capnhat = false;
            enableButton();
        }

        private void DSCC_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in DSCC.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radMa.Checked == true)
            {
                string std = string.Format("ma_ncc like '%{0}%'", txtTimKiem.Text);
                tblNCC.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("ten_ncc like '%{0}%'", txtTimKiem.Text);
                tblNCC.DefaultView.RowFilter = std;
            }
        }
    }
}