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
    public partial class frmIHD : DevExpress.XtraEditors.XtraForm
    {
        DataTable tblHOADONCT;
        SqlDataAdapter daHOADONCT;
        BindingManagerBase bindHDCT;
        bool capnhat;
       
        public frmIHD()
        {
            InitializeComponent();
        }

        private void btninhoadon_Click(object sender, EventArgs e)
        {

            frmIHDCT f = new frmIHDCT();
            
            f.sohoadon = txtsohoadon.Text;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void frmIHD_Load(object sender, EventArgs e)
        {
            tblHOADONCT = new DataTable();
            daHOADONCT = new SqlDataAdapter("SELECT sohoadonct, sohoadon, ma_sp, ten_sp, soluong, dongia, soluong*dongia as thanhtien FROM HOADONCT", XLBANG.cnnStr);

            try
            {
                daHOADONCT.Fill(tblHOADONCT);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            var cmb = new SqlCommandBuilder(daHOADONCT);

            txtsohoadon.DataBindings.Add("text", tblHOADONCT, "sohoadon", true);
            txtsohoadonct.DataBindings.Add("text", tblHOADONCT, "sohoadonct", true);

            enableButton();

            loadHOADONCT();

            capnhat = false;
        }
        private void loadHOADONCT()
        {
            dgvhdct.AutoGenerateColumns = false;
            dgvhdct.DataSource = tblHOADONCT;
        }
        private void enableButton()
        {
           btninhoadon.Enabled = !capnhat;
            btnthoat.Enabled = !capnhat;
        }

        private void dgvhdct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (ratheoma.Checked == true)
            {
                string std = string.Format("sohoadonct like '%{0}%'", textBox3.Text);
                tblHOADONCT.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("sohoadon like '%{0}%'", textBox3.Text);
                tblHOADONCT.DefaultView.RowFilter = std;
            }
        }

        private void dgvhdct_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvhdct.Rows)
                r.Cells[0].Value = r.Index + 1;
        }
    }
}