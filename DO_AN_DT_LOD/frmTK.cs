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

namespace DO_AN_DT_LOD
{
    public partial class frmTK : DevExpress.XtraEditors.XtraForm
    {
        public frmTK()
        {
            InitializeComponent();
        }

        private void frmTK_Load(object sender, EventArgs e)
        {
            cboThang.Items.Add("1");
            cboThang.Items.Add("2");
            cboThang.Items.Add("3");
            cboThang.Items.Add("4");
            cboThang.Items.Add("5");
            cboThang.Items.Add("6");
            cboThang.Items.Add("7");
            cboThang.Items.Add("8");
            cboThang.Items.Add("9");
            cboThang.Items.Add("10");
            cboThang.Items.Add("11");
            cboThang.Items.Add("12");

            cboNam.Items.Add("2018");
            cboNam.Items.Add("2019");
            cboNam.Items.Add("2020");

        }

        private void btnXemTK_Click(object sender, EventArgs e)
        {
            if (cboThang.Text == "")
            {
                MessageBox.Show("Mời chọn tháng");
                cboThang.Select();
                return;
            }
            if (cboNam.Text == "")
            {
                MessageBox.Show("Mời chọn năm");
                cboThang.Focus();
                return;
            }
            frmTK f = new frmTK();
            f.Thang = cboThang.Text;
            f.Nam = cboNam.Text;
            f.WindowState = FormWindowState.Maximized;
            f.Show();

        }
    }
}