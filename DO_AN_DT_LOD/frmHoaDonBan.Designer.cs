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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsohoadon = new System.Windows.Forms.TextBox();
            this.txtsohoadonct = new System.Windows.Forms.TextBox();
            this.ténp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.lKDTLODDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lKDT_LODDataSet = new DO_AN_DT_LOD.LKDT_LODDataSet();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sohoadonct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sohoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lKDTLODDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.radTimTheoTen = new System.Windows.Forms.RadioButton();
            this.radMa = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gThongTinHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gThongTinHD
            // 
            this.gThongTinHD.Controls.Add(this.label2);
            this.gThongTinHD.Controls.Add(this.label1);
            this.gThongTinHD.Controls.Add(this.txtsohoadon);
            this.gThongTinHD.Controls.Add(this.txtsohoadonct);
            this.gThongTinHD.Controls.Add(this.ténp);
            this.gThongTinHD.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.gThongTinHD.Location = new System.Drawing.Point(24, 58);
            this.gThongTinHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gThongTinHD.Name = "gThongTinHD";
            this.gThongTinHD.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gThongTinHD.Size = new System.Drawing.Size(679, 143);
            this.gThongTinHD.TabIndex = 53;
            this.gThongTinHD.TabStop = false;
            this.gThongTinHD.Text = "Thông tin hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Hóa Đơn ct:";
            // 
            // txtsohoadon
            // 
            this.txtsohoadon.Location = new System.Drawing.Point(115, 49);
            this.txtsohoadon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsohoadon.Name = "txtsohoadon";
            this.txtsohoadon.Size = new System.Drawing.Size(209, 24);
            this.txtsohoadon.TabIndex = 74;
            // 
            // txtsohoadonct
            // 
            this.txtsohoadonct.Location = new System.Drawing.Point(448, 49);
            this.txtsohoadonct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsohoadonct.Name = "txtsohoadonct";
            this.txtsohoadonct.Size = new System.Drawing.Size(209, 24);
            this.txtsohoadonct.TabIndex = 74;
            // 
            // ténp
            // 
            this.ténp.AutoSize = true;
            this.ténp.Location = new System.Drawing.Point(22, 49);
            this.ténp.Name = "ténp";
            this.ténp.Size = new System.Drawing.Size(87, 17);
            this.ténp.TabIndex = 3;
            this.ténp.Text = "Số Hóa Đơn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.label6.Location = new System.Drawing.Point(293, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 28);
            this.label6.TabIndex = 51;
            this.label6.Text = "IN HÓA ĐƠN";
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.ImageOptions.Image")));
            this.btnInHoaDon.Location = new System.Drawing.Point(709, 81);
            this.btnInHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(87, 43);
            this.btnInHoaDon.TabIndex = 59;
            this.btnInHoaDon.Text = "IN HĐ";
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(709, 161);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 43);
            this.btnThoat.TabIndex = 58;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.sohoadon,
            this.TenSP,
            this.dongia,
            this.soluong,
            this.ThanhTien});
            this.dgvCTHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvCTHD.DataSource = this.lKDTLODDataSetBindingSource1;
            this.dgvCTHD.Location = new System.Drawing.Point(24, 271);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.Size = new System.Drawing.Size(772, 302);
            this.dgvCTHD.TabIndex = 72;
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellContentClick);
            this.dgvCTHD.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCTHD_DataBindingComplete);
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
            this.sohoadonct.HeaderText = "Số Hóa Đơn ct";
            this.sohoadonct.Name = "sohoadonct";
            // 
            // sohoadon
            // 
            this.sohoadon.DataPropertyName = "sohoadon";
            this.sohoadon.HeaderText = "Số Hóa Đơn";
            this.sohoadon.Name = "sohoadon";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "ten_sp";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // lKDTLODDataSetBindingSource1
            // 
            this.lKDTLODDataSetBindingSource1.DataSource = this.lKDT_LODDataSet;
            this.lKDTLODDataSetBindingSource1.Position = 0;
            // 
            // radTimTheoTen
            // 
            this.radTimTheoTen.AutoSize = true;
            this.radTimTheoTen.Location = new System.Drawing.Point(595, 225);
            this.radTimTheoTen.Name = "radTimTheoTen";
            this.radTimTheoTen.Size = new System.Drawing.Size(145, 21);
            this.radTimTheoTen.TabIndex = 76;
            this.radTimTheoTen.Text = "Tìm Số Hóa Đơn ct";
            this.radTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // radMa
            // 
            this.radMa.AutoSize = true;
            this.radMa.Checked = true;
            this.radMa.Location = new System.Drawing.Point(437, 223);
            this.radMa.Name = "radMa";
            this.radMa.Size = new System.Drawing.Size(129, 21);
            this.radMa.TabIndex = 75;
            this.radMa.TabStop = true;
            this.radMa.Text = "Tìm Số Hóa Đơn";
            this.radMa.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(121, 223);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(284, 23);
            this.txtTimKiem.TabIndex = 74;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 73;
            this.label7.Text = "Tìm Kiếm:";
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 636);
            this.Controls.Add(this.radTimTheoTen);
            this.Controls.Add(this.radMa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gThongTinHD);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHoaDonBan";
            this.Text = "frmHoaDonBan";
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.gThongTinHD.ResumeLayout(false);
            this.gThongTinHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnInHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.GroupBox gThongTinHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ténp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource lKDTLODDataSetBindingSource;
        private LKDT_LODDataSet lKDT_LODDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.RadioButton radTimTheoTen;
        private System.Windows.Forms.RadioButton radMa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource lKDTLODDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohoadonct;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.TextBox txtsohoadon;
        private System.Windows.Forms.TextBox txtsohoadonct;
    }
}