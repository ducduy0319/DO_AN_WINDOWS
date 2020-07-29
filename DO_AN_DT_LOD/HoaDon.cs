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
        bool capNhat = false;
        private void HoaDon_Load(object sender, EventArgs e)
        {
            tblHOADON = new DataTable();
            daHOADON = new SqlDataAdapter("select * from HOADON", XLBANG.cnnStr);
            daNHANVIEN = new SqlDataAdapter("select * from NHANVIEN", XLBANG.cnnStr);
            tblNHANVIEN = new DataTable();
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
            cbma_nv.DataBindings.Add("text", tblNHANVIEN, "ma_nv", true);
            DSHD = this.BindingContext[tblHOADON];
            EnabledButton();
        }
        private void LoadDSNHANVIEN()
        {
            dgvDSHD.AutoGenerateColumns = false;
            dgvDSHD.DataSource = tblHOADON;
        }
        private void LoadHOADON()
        {
            cbma_nv.DataSource = tblNHANVIEN;
            cbma_nv.DisplayMember = "ten_nv";
            cbma_nv.ValueMember = "ma_nv";
        }


        private void EnabledButton()
        {
            btnThem.Enabled = !capNhat;
            btnXoa.Enabled = !capNhat;
            btnSua.Enabled = !capNhat;
            btnLuu.Enabled = capNhat;
            btnHuy.Enabled = capNhat;
         

        }
    }
}