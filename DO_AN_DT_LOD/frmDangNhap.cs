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
using DO_AN_DT_LOD.Modules;

namespace DO_AN_DT_LOD
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        frmMain fMain = null;
        XLNHANVIEN tblNhanVien;
        public frmDangNhap(frmMain pf)
        {
            fMain = pf;
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XLNHANVIEN();
            DataRow[] r = tblNhanVien.Select("Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'");
            if (r.Count() > 0)
            {
                fMain.Text = "Quản Lý Nhà Sách - Chào " + r[0]["TenNV"].ToString();
                fMain.maNV = r[0]["MaNV"].ToString();
                fMain.enableControl((int)r[0]["MaLTK"]);
                this.Close();
            }
            else
                MessageBox.Show("Sai tên tài khoản và mật khẩu !!!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void frmDangNhap_Enter(object sender, EventArgs e)
        {
            btnDangNhap_Click(sender, e);
        }
    }
}