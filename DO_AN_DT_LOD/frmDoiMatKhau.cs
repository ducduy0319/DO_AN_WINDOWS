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
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        string temp;
        public frmDoiMatKhau(string truyen)
        {
            InitializeComponent();
            this.temp = truyen;
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPassNew, " ");
            if (txtPassNew.Text.Length < 8 || !txtPassNew.Text.Any(char.IsDigit) || !txtPassNew.Text.Any(char.IsLower) || !txtPassNew.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txtPassNew, "mật khẩu mới tối thiểu 8 kí tự, gồm chữ số," + " in thường,in hoa.");
                return;
            }
            if(txtPassNew.Text!=txtConfirmPass.Text)
                {
                    errorProvider1.SetError(txtConfirmPass, "mật khẩu nhập lại không trùng!!!");
                    return;
                }
            frmMain f = (frmMain)this.MdiParent;
            MessageBox.Show(txtPassNew.Text.ToString() + temp);
            int count = XLBANG.Thuc_hien_lenh("Update NHANVIEN set Password='" + txtPassNew.Text + "' where ma_nv='" + temp + "'");
            if (count > 0)
            {
                MessageBox.Show("cập nhật thành công");

            }
            else
                MessageBox.Show("mật khẩu không hợp lệ");
        }


    }
}