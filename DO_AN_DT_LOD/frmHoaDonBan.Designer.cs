namespace DO_AN_DT_LOD
{
    partial class frmHoaDonBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonBan));
            this.gThongTinHD = new System.Windows.Forms.GroupBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ténp = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnLapHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.dateNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsohd = new System.Windows.Forms.TextBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.lKDTLODDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lKDT_LODDataSet = new DO_AN_DT_LOD.LKDT_LODDataSet();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sohoadonct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gThongTinHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gThongTinHD
            // 
            this.gThongTinHD.Controls.Add(this.nudSoLuong);
            this.gThongTinHD.Controls.Add(this.label5);
            this.gThongTinHD.Controls.Add(this.cbSP);
            this.gThongTinHD.Controls.Add(this.label2);
            this.gThongTinHD.Controls.Add(this.ténp);
            this.gThongTinHD.Controls.Add(this.txtTongTien);
            this.gThongTinHD.Controls.Add(this.label3);
            this.gThongTinHD.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gThongTinHD.Location = new System.Drawing.Point(56, 49);
            this.gThongTinHD.Name = "gThongTinHD";
            this.gThongTinHD.Size = new System.Drawing.Size(244, 150);
            this.gThongTinHD.TabIndex = 53;
            this.gThongTinHD.TabStop = false;
            this.gThongTinHD.Text = "thông tin hóa đơn";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(82, 70);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(113, 21);
            this.nudSoLuong.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tổng :";
            // 
            // cbSP
            // 
            this.cbSP.FormattingEnabled = true;
            this.cbSP.Location = new System.Drawing.Point(88, 40);
            this.cbSP.Name = "cbSP";
            this.cbSP.Size = new System.Drawing.Size(107, 21);
            this.cbSP.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 20;
            // 
            // ténp
            // 
            this.ténp.AutoSize = true;
            this.ténp.Location = new System.Drawing.Point(19, 40);
            this.ténp.Name = "ténp";
            this.ténp.Size = new System.Drawing.Size(44, 13);
            this.ténp.TabIndex = 3;
            this.ténp.Text = "Tên SP:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(82, 104);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(113, 21);
            this.txtTongTien.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.label6.Location = new System.Drawing.Point(286, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "HÓA ĐƠN BÁN";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.ImageOptions.Image")));
            this.btnInHoaDon.Location = new System.Drawing.Point(711, 63);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(75, 35);
            this.btnInHoaDon.TabIndex = 59;
            this.btnInHoaDon.Text = "IN HĐ";
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(711, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 35);
            this.btnThoat.TabIndex = 58;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapHoaDon.ImageOptions.Image")));
            this.btnLapHoaDon.Location = new System.Drawing.Point(599, 63);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(84, 35);
            this.btnLapHoaDon.TabIndex = 57;
            this.btnLapHoaDon.Text = "Lập HD";
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(599, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 35);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateNgayLap
            // 
            this.dateNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateNgayLap.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dateNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNgayLap.Location = new System.Drawing.Point(392, 59);
            this.dateNgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.dateNgayLap.Name = "dateNgayLap";
            this.dateNgayLap.Size = new System.Drawing.Size(106, 21);
            this.dateNgayLap.TabIndex = 71;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtKhachHang.Location = new System.Drawing.Point(392, 136);
            this.txtKhachHang.Multiline = true;
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(100, 23);
            this.txtKhachHang.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(305, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Khách hàng:";
            // 
            // txtsohd
            // 
            this.txtsohd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtsohd.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtsohd.Location = new System.Drawing.Point(392, 87);
            this.txtsohd.Multiline = true;
            this.txtsohd.Name = "txtsohd";
            this.txtsohd.Size = new System.Drawing.Size(100, 20);
            this.txtsohd.TabIndex = 67;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtNhanVien.Location = new System.Drawing.Point(392, 111);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(100, 21);
            this.txtNhanVien.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Location = new System.Drawing.Point(307, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Số Hóa Đơn:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Location = new System.Drawing.Point(307, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Nhân viên:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Location = new System.Drawing.Point(307, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Ngày lập:";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToOrderColumns = true;
            this.dgvCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTHD.AutoGenerateColumns = false;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.sohoadonct,
            this.TenSP,
            this.soluong,
            this.ThanhTien,
            this.Xoa});
            this.dgvCTHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvCTHD.DataSource = this.lKDTLODDataSetBindingSource;
            this.dgvCTHD.Location = new System.Drawing.Point(77, 214);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.Size = new System.Drawing.Size(606, 102);
            this.dgvCTHD.TabIndex = 72;
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellContentClick);
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
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // sohoadonct
            // 
            this.sohoadonct.DataPropertyName = "sohoadonct";
            this.sohoadonct.HeaderText = "Số Hóa Đơn";
            this.sohoadonct.Name = "sohoadonct";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "ten_sp";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SoLuong";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "xoa";
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 374);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.dateNgayLap);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsohd);
            this.Controls.Add(this.txtNhanVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gThongTinHD);
            this.Controls.Add(this.label6);
            this.Name = "frmHoaDonBan";
            this.Text = "frmHoaDonBan";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.gThongTinHD.ResumeLayout(false);
            this.gThongTinHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnInHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnLapHoaDon;
        private System.Windows.Forms.GroupBox gThongTinHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ténp;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.DateTimePicker dateNgayLap;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsohd;
        private System.Windows.Forms.TextBox txtNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.BindingSource lKDTLODDataSetBindingSource;
        private LKDT_LODDataSet lKDT_LODDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohoadonct;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}