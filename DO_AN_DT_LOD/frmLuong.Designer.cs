namespace DO_AN_DT_LOD
{
    partial class frmLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLuong));
            this.lKDTLODDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lKDT_LODDataSet = new DO_AN_DT_LOD.LKDT_LODDataSet();
            this.cbmanv = new System.Windows.Forms.ComboBox();
            this.txtluongcoban = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMasp = new System.Windows.Forms.Label();
            this.txtgiolam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmacong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dsnhanvien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoigianlam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongcoban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lKDTLODDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.dtIHD = new DO_AN_DT_LOD.dtIHD();
            this.dtIHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radTimTheoTen = new System.Windows.Forms.RadioButton();
            this.radMa = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnIN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtIHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIHDBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // cbmanv
            // 
            this.cbmanv.FormattingEnabled = true;
            this.cbmanv.Location = new System.Drawing.Point(99, 65);
            this.cbmanv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.Size = new System.Drawing.Size(193, 21);
            this.cbmanv.TabIndex = 25;
            // 
            // txtluongcoban
            // 
            this.txtluongcoban.Location = new System.Drawing.Point(478, 65);
            this.txtluongcoban.Name = "txtluongcoban";
            this.txtluongcoban.Size = new System.Drawing.Size(166, 21);
            this.txtluongcoban.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Lương Cơ Bản(giờ):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Thời Gian Làm Việc(giờ):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 20;
            // 
            // lblMasp
            // 
            this.lblMasp.AutoSize = true;
            this.lblMasp.Location = new System.Drawing.Point(33, 65);
            this.lblMasp.Name = "lblMasp";
            this.lblMasp.Size = new System.Drawing.Size(41, 13);
            this.lblMasp.TabIndex = 3;
            this.lblMasp.Text = "Mã NV:";
            // 
            // txtgiolam
            // 
            this.txtgiolam.Location = new System.Drawing.Point(478, 33);
            this.txtgiolam.Name = "txtgiolam";
            this.txtgiolam.Size = new System.Drawing.Size(166, 21);
            this.txtgiolam.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên NV:";
            // 
            // txtmacong
            // 
            this.txtmacong.Location = new System.Drawing.Point(99, 28);
            this.txtmacong.Name = "txtmacong";
            this.txtmacong.Size = new System.Drawing.Size(193, 21);
            this.txtmacong.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Công:";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(478, 98);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(166, 21);
            this.txtThanhTien.TabIndex = 12;
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(776, 113);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 35);
            this.btnHuy.TabIndex = 61;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(776, 159);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 35);
            this.btnThoat.TabIndex = 60;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(696, 113);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 35);
            this.btnSua.TabIndex = 59;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(696, 161);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 58;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(776, 68);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 29);
            this.btnLuu.TabIndex = 57;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(694, 67);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 56;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.label6.Location = new System.Drawing.Point(382, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 21);
            this.label6.TabIndex = 52;
            this.label6.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dsnhanvien
            // 
            this.dsnhanvien.AllowUserToOrderColumns = true;
            this.dsnhanvien.AutoGenerateColumns = false;
            this.dsnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaCong,
            this.manv,
            this.ten_nv,
            this.thoigianlam,
            this.luongcoban,
            this.luong});
            this.dsnhanvien.DataSource = this.lKDTLODDataSetBindingSource1;
            this.dsnhanvien.Location = new System.Drawing.Point(11, 243);
            this.dsnhanvien.Name = "dsnhanvien";
            this.dsnhanvien.Size = new System.Drawing.Size(953, 285);
            this.dsnhanvien.TabIndex = 54;
            this.dsnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsnhanvien_CellClick);
            this.dsnhanvien.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dsnhanvien_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 60;
            // 
            // MaCong
            // 
            this.MaCong.DataPropertyName = "ma_cong";
            this.MaCong.HeaderText = "Mã Công";
            this.MaCong.Name = "MaCong";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "ma_nv";
            this.manv.HeaderText = "Mã NV";
            this.manv.Name = "manv";
            // 
            // ten_nv
            // 
            this.ten_nv.DataPropertyName = "ten_nv";
            this.ten_nv.HeaderText = "Tên NV";
            this.ten_nv.Name = "ten_nv";
            this.ten_nv.Width = 120;
            // 
            // thoigianlam
            // 
            this.thoigianlam.DataPropertyName = "thoigianlam";
            this.thoigianlam.HeaderText = "Thời Gian Làm Việc(giờ)";
            this.thoigianlam.Name = "thoigianlam";
            this.thoigianlam.Width = 200;
            // 
            // luongcoban
            // 
            this.luongcoban.DataPropertyName = "luongcoban";
            this.luongcoban.HeaderText = "Lương Cơ Bản(giờ)";
            this.luongcoban.Name = "luongcoban";
            this.luongcoban.Width = 200;
            // 
            // luong
            // 
            this.luong.DataPropertyName = "luong";
            this.luong.HeaderText = "Lương Thực Lĩnh";
            this.luong.Name = "luong";
            this.luong.Width = 150;
            // 
            // lKDTLODDataSetBindingSource1
            // 
            this.lKDTLODDataSetBindingSource1.DataSource = this.lKDT_LODDataSet;
            this.lKDTLODDataSetBindingSource1.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbmanv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMasp);
            this.groupBox1.Controls.Add(this.txtgiolam);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtmacong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtluongcoban);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(11, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(678, 138);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Nhân Viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Lương Thực Lĩnh:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(99, 98);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(193, 21);
            this.txtTenNV.TabIndex = 12;
            // 
            // dtIHD
            // 
            this.dtIHD.DataSetName = "dtIHD";
            this.dtIHD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtIHDBindingSource
            // 
            this.dtIHDBindingSource.DataSource = this.dtIHD;
            this.dtIHDBindingSource.Position = 0;
            // 
            // radTimTheoTen
            // 
            this.radTimTheoTen.AutoSize = true;
            this.radTimTheoTen.Location = new System.Drawing.Point(387, 219);
            this.radTimTheoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTimTheoTen.Name = "radTimTheoTen";
            this.radTimTheoTen.Size = new System.Drawing.Size(89, 17);
            this.radTimTheoTen.TabIndex = 65;
            this.radTimTheoTen.Text = "Tìm Theo Tên";
            this.radTimTheoTen.UseVisualStyleBackColor = true;
            this.radTimTheoTen.CheckedChanged += new System.EventHandler(this.radTimTheoTen_CheckedChanged);
            // 
            // radMa
            // 
            this.radMa.AutoSize = true;
            this.radMa.Checked = true;
            this.radMa.Location = new System.Drawing.Point(281, 218);
            this.radMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMa.Name = "radMa";
            this.radMa.Size = new System.Drawing.Size(83, 17);
            this.radMa.TabIndex = 64;
            this.radMa.TabStop = true;
            this.radMa.Text = "Tìm theo mã";
            this.radMa.UseVisualStyleBackColor = true;
            this.radMa.CheckedChanged += new System.EventHandler(this.radMa_CheckedChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(10, 218);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(244, 21);
            this.txtTimKiem.TabIndex = 63;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Tìm Kiếm:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnIN
            // 
            this.btnIN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIN.ImageOptions.Image")));
            this.btnIN.Location = new System.Drawing.Point(773, 201);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(75, 30);
            this.btnIN.TabIndex = 56;
            this.btnIN.Text = "In";
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // frmLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 579);
            this.Controls.Add(this.radTimTheoTen);
            this.Controls.Add(this.radMa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dsnhanvien);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLuong";
            this.Text = "frmLuong";
            this.Load += new System.EventHandler(this.frmLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtIHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtIHDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource lKDTLODDataSetBindingSource;
        private LKDT_LODDataSet lKDT_LODDataSet;
        private System.Windows.Forms.ComboBox cbmanv;
        private System.Windows.Forms.TextBox txtluongcoban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMasp;
        private System.Windows.Forms.TextBox txtgiolam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmacong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThanhTien;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dsnhanvien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource lKDTLODDataSetBindingSource1;
        private dtIHD dtIHD;
        private System.Windows.Forms.BindingSource dtIHDBindingSource;
        private System.Windows.Forms.RadioButton radTimTheoTen;
        private System.Windows.Forms.RadioButton radMa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoigianlam;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcoban;
        private System.Windows.Forms.DataGridViewTextBoxColumn luong;
        private DevExpress.XtraEditors.SimpleButton btnIN;
    }
}