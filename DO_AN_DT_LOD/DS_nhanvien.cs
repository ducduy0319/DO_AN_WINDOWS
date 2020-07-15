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
    public partial class DS_nhanvien : DevExpress.XtraEditors.XtraForm
    {
        public DS_nhanvien()
        {
            InitializeComponent();
        }
        XLNHANVIEN tblNhanVien;
        BindingManagerBase DSNV;
        
        private void DS_nhanvien_Load(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            DSNV = this.BindingContext[tblNhanVien];
            loadnhanvien();

            
        }
        private void loadnhanvien()
        {
            dsNhanVien.AutoGenerateColumns = false;
            dsNhanVien.DataSource = tblNhanVien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSNV.AddNew();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DSNV.RemoveAt(DSNV.Position);
            tblNhanVien.ghi();
            tblNhanVien.AcceptChanges();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tblNhanVien.ghi();
            tblNhanVien.AcceptChanges();
        }
    }
}