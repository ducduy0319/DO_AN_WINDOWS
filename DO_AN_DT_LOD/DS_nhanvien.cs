﻿using System;
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
        bool capnhat = false;

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
            txtMaNV.DataBindings.Add("text", tblNhanVien, "ma_nv", true);
            txtTenNV.DataBindings.Add("text", tblNhanVien, "ten_nv", true);
            txtDiaChi.DataBindings.Add("text", tblNhanVien, "diachi", true);
            txtSDT.DataBindings.Add("text", tblNhanVien, "sdt", true);
            radnam.DataBindings.Add("checked", tblNhanVien, "gioitinh", true);
            dtNgaySinh.DataBindings.Add("value", tblNhanVien, "ngaysinh", true);

            DSNV = this.BindingContext[tblNhanVien];
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
            DSNV.AddNew();
            capnhat = true;
            enableButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                DSNV.RemoveAt(DSNV.Position);
                tblNhanVien.ghi();
                tblNhanVien.AcceptChanges();

            }
            catch(SqlException ex)
            {
                tblNhanVien.RejectChanges();
                MessageBox.Show("xóa thất bại !!!");
            }
            */
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa sách " + txtMaNV.Text + " không?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DSNV.RemoveAt(DSNV.Position);
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
            /*
            try
            {
                tblNhanVien.ghi();
                tblNhanVien.AcceptChanges();
                capnhat = false;
                enableButton();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
            try
            {
                DSNV.EndCurrentEdit();
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

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnTimKiem_Click(sender, e);      
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow r = tblNhanVien.Select("ma_nv='" + txtTimKiem.Text + "'")[0];
                DSNV.Position = tblNhanVien.Rows.IndexOf(r);

            }
            catch (Exception ex)
            {
                MessageBox.Show("không có kết quả");
            }
        }

        private void txtTimKiem_MouseDown(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSNV.CancelCurrentEdit();
            tblNhanVien.RejectChanges();
            capnhat = false;
            enableButton();
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            TabPage T = (TabPage)this.Parent;
            T.Dispose();
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
    }
}