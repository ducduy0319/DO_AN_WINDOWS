namespace DO_AN_DT_LOD
{
    partial class frmTaoHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoHD));
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.radTimTheoTen = new System.Windows.Forms.RadioButton();
            this.radMa = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dsspct = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lKDTLODDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lKDT_LODDataSet = new DO_AN_DT_LOD.LKDT_LODDataSet();
            this.lblMasp = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHDCT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmahd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnIN = new DevExpress.XtraEditors.SimpleButton();
            this.lKDTLODDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsspct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Tìm Kiếm:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(99, 102);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(193, 21);
            this.txtTenSP.TabIndex = 12;
            // 
            // radTimTheoTen
            // 
            this.radTimTheoTen.AutoSize = true;
            this.radTimTheoTen.Location = new System.Drawing.Point(386, 228);
            this.radTimTheoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTimTheoTen.Name = "radTimTheoTen";
            this.radTimTheoTen.Size = new System.Drawing.Size(89, 17);
            this.radTimTheoTen.TabIndex = 79;
            this.radTimTheoTen.Text = "Tìm Theo Tên";
            this.radTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // radMa
            // 
            this.radMa.AutoSize = true;
            this.radMa.Checked = true;
            this.radMa.Location = new System.Drawing.Point(280, 227);
            this.radMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMa.Name = "radMa";
            this.radMa.Size = new System.Drawing.Size(83, 17);
            this.radMa.TabIndex = 78;
            this.radMa.TabStop = true;
            this.radMa.Text = "Tìm theo mã";
            this.radMa.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(9, 227);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(244, 21);
            this.txtTimKiem.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.label6.Location = new System.Drawing.Point(381, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 21);
            this.label6.TabIndex = 66;
            this.label6.Text = "TẠO HÓA ĐƠN";
            // 
            // dsspct
            // 
            this.dsspct.AllowUserToOrderColumns = true;
            this.dsspct.AutoGenerateColumns = false;
            this.dsspct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsspct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHDCT,
            this.MaHoaDon,
            this.Masp,
            this.TenSP,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dsspct.DataSource = this.lKDTLODDataSetBindingSource;
            this.dsspct.Location = new System.Drawing.Point(13, 252);
            this.dsspct.Name = "dsspct";
            this.dsspct.Size = new System.Drawing.Size(837, 285);
            this.dsspct.TabIndex = 67;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 60;
            // 
            // MaHDCT
            // 
            this.MaHDCT.DataPropertyName = "sohoadonct";
            this.MaHDCT.HeaderText = "Mã Hóa Đơn CT";
            this.MaHDCT.Name = "MaHDCT";
            this.MaHDCT.Width = 150;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "sohoadon";
            this.MaHoaDon.HeaderText = "Mã Hóa Đơn";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Width = 150;
            // 
            // Masp
            // 
            this.Masp.DataPropertyName = "ma_sp";
            this.Masp.HeaderText = "Mã SP";
            this.Masp.Name = "Masp";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "ten_sp";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.Name = "TenSP";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "dongia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "soluong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "thanhtien";
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 150;
            // 
            // lKDTLODDataSetBindingSource
            // 
            this.lKDTLODDataSetBindingSource.DataSource = this.lKDT_LODDataSet;
            this.lKDTLODDataSetBindingSource.Position = 0;
            // 
            // lKDT_LODDataSet
            // 
            this.lKDT_LODDataSet.DataSetName = "LKDT_LODDataSet";
            this.lKDT_LODDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMasp
            // 
            this.lblMasp.AutoSize = true;
            this.lblMasp.Location = new System.Drawing.Point(333, 30);
            this.lblMasp.Name = "lblMasp";
            this.lblMasp.Size = new System.Drawing.Size(42, 13);
            this.lblMasp.TabIndex = 3;
            this.lblMasp.Text = "Mã HD:";
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(412, 102);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(193, 21);
            this.txtsoluong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên SP:";
            // 
            // txtHDCT
            // 
            this.txtHDCT.Location = new System.Drawing.Point(99, 28);
            this.txtHDCT.Name = "txtHDCT";
            this.txtHDCT.Size = new System.Drawing.Size(193, 21);
            this.txtHDCT.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã HDCT:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbmahd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMasp);
            this.groupBox1.Controls.Add(this.txtdongia);
            this.groupBox1.Controls.Add(this.txtsoluong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtHDCT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSP);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(10, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 138);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // cbmahd
            // 
            this.cbmahd.FormattingEnabled = true;
            this.cbmahd.Location = new System.Drawing.Point(412, 28);
            this.cbmahd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbmahd.Name = "cbmahd";
            this.cbmahd.Size = new System.Drawing.Size(193, 21);
            this.cbmahd.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Đơn Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số Lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Mã Sp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 20;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(412, 63);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(193, 21);
            this.txtdongia.TabIndex = 1;
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(99, 67);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(193, 21);
            this.txtSP.TabIndex = 12;
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(775, 122);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 35);
            this.btnHuy.TabIndex = 75;
            this.btnHuy.Text = "Hủy";
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(775, 168);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 35);
            this.btnThoat.TabIndex = 74;
            this.btnThoat.Text = "Thoát";
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(695, 122);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 73;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(695, 170);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 72;
            this.btnXoa.Text = "Xóa";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(775, 77);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 29);
            this.btnLuu.TabIndex = 71;
            this.btnLuu.Text = "Lưu";
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(693, 76);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 69;
            this.btnThem.Text = "Thêm";
            // 
            // btnIN
            // 
            this.btnIN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIN.ImageOptions.Image")));
            this.btnIN.Location = new System.Drawing.Point(772, 210);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(75, 30);
            this.btnIN.TabIndex = 70;
            this.btnIN.Text = "In";
            // 
            // frmTaoHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.radTimTheoTen);
            this.Controls.Add(this.radMa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dsspct);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTaoHD";
            this.Text = "Tạo Hóa Đơn";
            this.Load += new System.EventHandler(this.frmTaoHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsspct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.RadioButton radTimTheoTen;
        private System.Windows.Forms.RadioButton radMa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnIN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dsspct;
        private System.Windows.Forms.Label lblMasp;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHDCT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbmahd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource lKDTLODDataSetBindingSource2;
        private System.Windows.Forms.BindingSource lKDTLODDataSetBindingSource;
        private LKDT_LODDataSet lKDT_LODDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}