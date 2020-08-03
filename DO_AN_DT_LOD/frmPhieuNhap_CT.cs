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
    public partial class frmPhieuNhap_CT : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuNhap_CT()
        {
            InitializeComponent();
        }
        DataTable tblSANPHAM, tblPHIEUNHAP, tblPHIEUNHAP_CT;
        SqlDataAdapter daSANPHAM, daPHIEUNHAP, daPHIEUNHAP_CT;
        BindingManagerBase DSPN;
        bool capnhat = false;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmPhieuNhap_CT_Load(object sender, EventArgs e)
        {
            tblSANPHAM = new DataTable();
            daSANPHAM = new SqlDataAdapter("select * from SANPHAM", XLBANG.cnnStr);
            tblPHIEUNHAP_CT = new DataTable();
            daPHIEUNHAP_CT = new SqlDataAdapter("select * from PHIEUNHAP_CT", XLBANG.cnnStr);
            tblPHIEUNHAP = new DataTable();
            daPHIEUNHAP = new SqlDataAdapter("select * from PHIEUNHAP", XLBANG.cnnStr);

            try
            {
                daSANPHAM.Fill(tblSANPHAM);
                daPHIEUNHAP_CT.Fill(tblPHIEUNHAP_CT);
                daPHIEUNHAP.Fill(tblPHIEUNHAP);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daSANPHAM);
            var cmd1 = new SqlCommandBuilder(daPHIEUNHAP_CT);
            var cmd2 = new SqlCommandBuilder(daPHIEUNHAP);

            LoadSANPHAM();
            LoadPHIEUNHAP_CT();
            loadPHIEUNHAP();

            txtSPNCT.DataBindings.Add("text", tblPHIEUNHAP_CT, "sophieunhapct", true);
            txtSPN.DataBindings.Add("text", tblPHIEUNHAP_CT, "sophieunhap", true);
            txtMaSp.DataBindings.Add("text", tblPHIEUNHAP_CT, "ma_sp", true);
            txtSoLuong.DataBindings.Add("text", tblPHIEUNHAP_CT, "soluong", true);
            txtDonGia.DataBindings.Add("text", tblPHIEUNHAP_CT, "dongia", true);
            txtThanhTien.DataBindings.Add("text", tblPHIEUNHAP_CT, "thanhtien", true);
            DSPN = this.BindingContext[tblPHIEUNHAP];
            enableButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
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
                if (MessageBox.Show("Bạn có muốn xóa sách " + txtSPNCT.Text + "không?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DSPN.RemoveAt(DSPN.Position);
                    capnhat = false;
                    daPHIEUNHAP_CT.Update(tblPHIEUNHAP_CT);

                    tblPHIEUNHAP_CT.AcceptChanges();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            catch (SqlException ex)
            {
                //sửa lại cần thông bào trước khi xóa
                tblPHIEUNHAP_CT.RejectChanges();
                MessageBox.Show("xóa thất bại !!!");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSPN.EndCurrentEdit();
                daPHIEUNHAP_CT.Update(tblPHIEUNHAP_CT);
                tblPHIEUNHAP_CT.AcceptChanges();
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
            tblPHIEUNHAP_CT.RejectChanges();
            capnhat = false;
            enableButton();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void LoadSANPHAM()
        {
            txtMaSp.DataSource = tblSANPHAM;
            txtMaSp.DisplayMember = "ma_sp";
            txtMaSp.ValueMember = "ma_sp";

        }
        private void loadPHIEUNHAP()
        {
            txtSPN.DataSource = tblPHIEUNHAP;
            txtSPN.DisplayMember = "sophieuphap";
            txtSPN.ValueMember = "sophieuphap";
        }
        private void LoadPHIEUNHAP_CT()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = tblPHIEUNHAP_CT;
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