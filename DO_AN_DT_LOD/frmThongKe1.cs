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
using DO_AN_DT_LOD.Modules;

namespace DO_AN_DT_LOD
{
    public partial class frmThongKe1 : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKe1()
        {
            InitializeComponent();
        }

        private void frmThongKe1_Load(object sender, EventArgs e)
        {
            cbThang.Items.Add("1");
            cbThang.Items.Add("2");
            cbThang.Items.Add("3");
            cbThang.Items.Add("4");
            cbThang.Items.Add("5");
            cbThang.Items.Add("6");
            cbThang.Items.Add("7");
            cbThang.Items.Add("8");
            cbThang.Items.Add("9");
            cbThang.Items.Add("10");
            cbThang.Items.Add("11");
            cbThang.Items.Add("12");

            cbNam.Items.Add("2018");
            cbNam.Items.Add("2019");
            cbNam.Items.Add("2020");
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            if (cbThang.Text == "")
            {
                MessageBox.Show("Mời chọn tháng muốn xem!!!!");
                cbThang.Select();
                return;
            }
            if (cbNam.Text == "")
            {
                MessageBox.Show("Mời chọn năm muốn xem!!!!");
                cbThang.Focus();
                return;
            }
           frmTKDTcs f = new frmTKDTcs();
            f.Thang = cbThang.Text;
            f.Nam = cbNam.Text;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

       
    }
}