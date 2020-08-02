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
    public partial class frmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        XLNHANVIEN tblNhanVien;
        BindingManagerBase DSTK;

        bool capnhat = false;

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            DSTK = this.BindingContext[tblNhanVien];
            loadnhanvien();
        }

        private void loadnhanvien()
        {
            dsNhanVien.AutoGenerateColumns = false;
            dsNhanVien.DataSource = tblNhanVien;

            txtMaNV.DataBindings.Add("text", tblNhanVien, "ma_nv", true);
            txtTenNV.DataBindings.Add("text", tblNhanVien, "ten_nv", true);
            radnam.DataBindings.Add("checked", tblNhanVien, "gioitinh", true);

            txtTTK.DataBindings.Add("text", tblNhanVien, "UserName", true);
            txtMK.DataBindings.Add("text", tblNhanVien, "Password", true);
            txtLTK.DataBindings.Add("text", tblNhanVien, "MaLTK", true);

            DSTK = this.BindingContext[tblNhanVien];

            enableButton();
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
            DSTK.AddNew();
            capnhat = true;
            enableButton(); ;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa sách " + txtMaNV.Text + " không?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DSTK.RemoveAt(DSTK.Position);
                    capnhat = false;
                    tblNhanVien.ghi();
                    tblNhanVien.AcceptChanges();

                    tblNhanVien.AcceptChanges();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (SqlException ex)
            {
                //sửa lại cần thông bào trước khi xóa
                tblNhanVien.RejectChanges();
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
                DSTK.EndCurrentEdit();
                tblNhanVien.ghi();
                tblNhanVien.AcceptChanges();
                capnhat = false;
                enableButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radnam_CheckedChanged(object sender, EventArgs e)
        {
            radnu.Checked = !radnam.Checked;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSTK.CancelCurrentEdit();
            tblNhanVien.RejectChanges();
            capnhat = false;
            enableButton();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (radMa.Checked == true)
            {
                string std = string.Format("ma_nv like '%{0}%'", txtTimKiem.Text);
                tblNhanVien.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("ten_nv like '%{0}%'", txtTimKiem.Text);
                tblNhanVien.DefaultView.RowFilter = std;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void radMa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radTimTheoTen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dsNhanVien_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dsNhanVien.Rows)
                r.Cells[0].Value = r.Index + 1;
        }
    }
}