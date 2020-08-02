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
    public partial class frmHoaDonBan : DevExpress.XtraEditors.XtraForm
    {
        DataTable tblSANPHAM, tblHOADON, tblHOADONCT;
        SqlDataAdapter daHD, daHDCT, daSP;
        BindingManagerBase bindHD, bindHDCT;
        bool capnhat;
        internal string ma_nv;


        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            ma_nv = txtNhanVien.Text;
            tblHOADONCT = new DataTable();
            tblHOADON = new DataTable();
            tblSANPHAM = new DataTable();
            daHDCT = new SqlDataAdapter("Select * from HOADONCT", XLBANG.cnnStr);
            daHD = new SqlDataAdapter("Select * from HOADON", XLBANG.cnnStr);
            daSP = new SqlDataAdapter("Select * from SANPHAM", XLBANG.cnnStr);
            try
            {
                daHDCT.Fill(tblHOADONCT);
                daHD.Fill(tblHOADON);
                daSP.Fill(tblSANPHAM);

                // capnhatsql
                SqlCommandBuilder cmdHD = new SqlCommandBuilder(daHD);
                SqlCommandBuilder cmdCTHD = new SqlCommandBuilder(daHDCT);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadSANPHAM();
            addcolHDCT();
            loadHD();
            loadHDCT();

            capnhat = false;
            enaButton();
        }
        private void enaButton()
        {
            btnLapHoaDon.Enabled = !capnhat;
   
           
            dgvCTHD.Enabled = !capnhat;
            gThongTinHD.Enabled = !capnhat;
  
            btnInHoaDon.Enabled = !capnhat;
            btnThem.Enabled = !capnhat;

            dateNgayLap.Enabled = !capnhat;
            txtKhachHang.Enabled = !capnhat;
            txtNhanVien.Enabled = false;
            txtsohd.Enabled = false;
            txtTongTien.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbSP.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn sp");
                return;
            }

            int count = tblHOADONCT.Select("sohoadon = '" + txtsohd.Text + "' and ma_sp='" + cbSP.SelectedValue + "'").Count();
            if (count > 0)
            {
                MessageBox.Show("thiết bị này đã có");
                return;
            }
            DataRow r = tblHOADONCT.NewRow();
            r["ten_sp"] = cbSP.SelectedValue;
            r["sohoadon"] = txtsohd.Text;
            r["soluong"] = nudSoLuong.Value;

            tblHOADONCT.Rows.Add(r);
            bdHD_PositionChanged(sender, e);

        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                try
                {
                    bindHDCT.RemoveAt(bindHDCT.Position);
                    daHDCT.Update(tblHOADONCT);
                    tblHOADONCT.AcceptChanges();
                }
                catch
                {
                    tblHOADONCT.RejectChanges();
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            //bindHD.AddNew();
            //dateNgayLap.Value = DateTime.Now;
            //txtNhanVien.Text = ma_nv;
            //txtKhachHang.Text = "Guest";
            //try
            //{
            //    SqlCommand cmm = new SqlCommand("Select dbo.fn_Createsohd()", XLBANG.cnnStr);
            //    XLBANG.cnnStr.Open();
            //    txtsohd.Text = cmm.ExecuteScalar().ToString();
            //    capnhat = true;
            //    enaButton();
            //}

            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //XLBANG.cnnStr.Clone();

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
           frmInHD f = new frmInHD();
            f.sohd = txtsohd.Text;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void loadHD()
        {
            bindHD = this.BindingContext[tblHOADON];
            txtsohd.DataBindings.Add("text", tblHOADON, "sohoadon", true);
            dateNgayLap.DataBindings.Add("value", tblHOADON, "Ngayhoadon", true);
            txtNhanVien.DataBindings.Add("text", tblHOADON, "ma_nv", true);
            //txtKhachHang.DataBindings.Add("text", tblHOADON, "TenKH", true);
            bindHD.PositionChanged += new EventHandler(bdHD_PositionChanged);
        }
        private void bdHD_PositionChanged(object sender, EventArgs e)
        {
            tblHOADONCT.DefaultView.RowFilter = "sohoadon= '" + txtsohd.Text + "'";
            int s = 0;
            foreach (DataRowView r in tblHOADONCT.DefaultView)
            {
                s += int.Parse(r["ThanhTien"].ToString());
            }
            txtTongTien.Text = s.ToString();
        }
        private void loadHDCT()
        {
            bindHDCT = this.BindingContext[tblHOADONCT];
            dgvCTHD.AutoGenerateColumns = false;
            dgvCTHD.DataSource = tblHOADONCT;
        }
        private void loadSANPHAM()
        {
            cbSP.DataSource = tblSANPHAM;
            cbSP.ValueMember = "ten_sp";
            cbSP.DisplayMember = "ten_sp";
            cbSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbSP.AutoCompleteSource = AutoCompleteSource.ListItems;
           // cbSP.SelectedIndex = -1; 
        }
        private void addcolHDCT()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblSANPHAM, tblHOADONCT });
            //tao qh
            DataRelation qh = new DataRelation("FRK_SANPHAM_HOADONCT", tblSANPHAM.Columns["ma_sp"], tblHOADONCT.Columns["ma_sp"]);
            ds.Relations.Add(qh);
            //tao cot phu

            DataColumn cot_DonGia = new DataColumn("DonGia", Type.GetType("System.String"), "Parent(FRK_SANPHAM_HOADONCT).DonGia");
            tblHOADONCT.Columns.Add(cot_DonGia);

            DataColumn cot_ThanhTien = new DataColumn("ThanhTien", Type.GetType("System.String"), "Parent(FRK_SANPHAM_HOADONCT).DonGia*SoLuong");
            tblHOADONCT.Columns.Add(cot_ThanhTien);
        }
    }
}
////fdghujikolp;