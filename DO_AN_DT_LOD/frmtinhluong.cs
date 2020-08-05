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
    public partial class frmtinhluong : DevExpress.XtraEditors.XtraForm
    {
        public frmtinhluong()
        {
            InitializeComponent();
        }
        DataTable tblNHANVIEN, tblCHAMCONG, tblLUONG;
        SqlDataAdapter daNHANVIEN, daCHAMCONG, daLUONG;
        BindingManagerBase DSNV;
        bool capnhat = false;

        private void frmtinhluong_Load(object sender, EventArgs e)
        {
            tblNHANVIEN = new DataTable();
            daNHANVIEN = new SqlDataAdapter("select * from NHANVIEN", XLBANG.cnnStr);
            tblCHAMCONG = new DataTable();
            daCHAMCONG = new SqlDataAdapter("select * from CHAMCONG", XLBANG.cnnStr);

            tblLUONG = new DataTable();
            daLUONG = new SqlDataAdapter("SELECT CHAMCONG.ma_cong,CHAMCONG.ma_nv,NHANVIEN.ten_nv,CHAMCONG.thoigianlam,CHAMCONG.luongcoban, CHAMCONG.thoigianlam*CHAMCONG.luongcoban as luong FROM CHAMCONG,NHANVIEN WHERE CHAMCONG.ma_nv = NHANVIEN.ma_nv", XLBANG.cnnStr);

            try
            {
                daNHANVIEN.Fill(tblNHANVIEN);
                daCHAMCONG.Fill(tblCHAMCONG);
   
                daLUONG.Fill(tblLUONG);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daNHANVIEN);
            var cmd = new SqlCommandBuilder(daCHAMCONG);
            var cmd1 = new SqlCommandBuilder(daLUONG);


            LoadNHANVIEN();
            LoadCHAMCONG();

            LoadLUONG();

            txtmacong.DataBindings.Add("text", tblCHAMCONG, "ma_cong", true);
            cbmanv.DataBindings.Add("text", tblCHAMCONG, "ma_nv", true);
            txtgiolam.DataBindings.Add("text", tblCHAMCONG, "thoigianlam", true);
            txtluongcoban.DataBindings.Add("text", tblCHAMCONG, "luongcoban", true);

            DSNV = this.BindingContext[tblCHAMCONG];
            enableButton();

        }
        private void LoadCHAMCONG()
        {
            dsnhanvien.AutoGenerateColumns = false;
            dsnhanvien.DataSource = tblCHAMCONG;
        }

        private void LoadLUONG()
        {
            dsluong.AutoGenerateColumns = false;
            dsluong.DataSource = tblLUONG;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSNV.AddNew();
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
                if (MessageBox.Show("Bạn có muốn xóa sách " + txtmacong.Text + " không?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DSNV.RemoveAt(DSNV.Position);
                    capnhat = false;
                    daCHAMCONG.Update(tblCHAMCONG);

                    tblCHAMCONG.AcceptChanges();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (SqlException ex)
            {
                //sửa lại cần thông bào trước khi xóa
                tblCHAMCONG.RejectChanges();
                MessageBox.Show("xóa thất bại !!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSNV.EndCurrentEdit();
                daCHAMCONG.Update(tblCHAMCONG);
                tblCHAMCONG.AcceptChanges();
                capnhat = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSNV.CancelCurrentEdit();
            tblCHAMCONG.RejectChanges();
            capnhat = false;
            enableButton();
        }

        private void dsnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radMa.Checked == true)
            {
                string std = string.Format("ma_nv like '%{0}%'", txtTimKiem.Text);
                tblCHAMCONG.DefaultView.RowFilter = std;
            }
  

            if (radMa.Checked == true)
            {
                string std = string.Format("ma_nv like '%{0}%'", txtTimKiem.Text);
                tblLUONG.DefaultView.RowFilter = std;
            }

        }

        private void dsluong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void dsSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dsnhanvien.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void LoadNHANVIEN()
        {
            cbmanv.DataSource = tblNHANVIEN;
            cbmanv.DisplayMember = "ma_nv";
            cbmanv.ValueMember = "ma_nv";
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

    }
}