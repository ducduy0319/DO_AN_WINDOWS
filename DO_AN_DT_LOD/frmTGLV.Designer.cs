namespace DO_AN_DT_LOD
{
    partial class frmTGLV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTGLV));
            this.radTimTheoTen = new System.Windows.Forms.RadioButton();
            this.radMa = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lKDT_LODDataSet = new DO_AN_DT_LOD.LKDT_LODDataSet();
            this.lKDTLODDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCLV = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_TGLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbtMaNV = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMasp = new System.Windows.Forms.Label();
            this.txtca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtThu = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPCCV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIN = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCLV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radTimTheoTen
            // 
            this.radTimTheoTen.AutoSize = true;
            this.radTimTheoTen.Location = new System.Drawing.Point(468, 264);
            this.radTimTheoTen.Name = "radTimTheoTen";
            this.radTimTheoTen.Size = new System.Drawing.Size(113, 21);
            this.radTimTheoTen.TabIndex = 52;
            this.radTimTheoTen.Text = "Tìm Theo Tên";
            this.radTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // radMa
            // 
            this.radMa.AutoSize = true;
            this.radMa.Checked = true;
            this.radMa.Location = new System.Drawing.Point(345, 263);
            this.radMa.Name = "radMa";
            this.radMa.Size = new System.Drawing.Size(106, 21);
            this.radMa.TabIndex = 51;
            this.radMa.TabStop = true;
            this.radMa.Text = "Tìm theo mã";
            this.radMa.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tìm Kiếm:";
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(721, 134);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 43);
            this.btnHuy.TabIndex = 48;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(721, 191);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 43);
            this.btnThoat.TabIndex = 47;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(628, 134);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 43);
            this.btnSua.TabIndex = 46;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(628, 193);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 38);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(721, 79);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(87, 36);
            this.btnLuu.TabIndex = 44;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(626, 78);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 37);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.label6.Location = new System.Drawing.Point(289, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 28);
            this.label6.TabIndex = 40;
            this.label6.Text = "PHÂN CÔNG CÔNG VIỆC";
            // 
            // lKDT_LODDataSet
            // 
            this.lKDT_LODDataSet.DataSetName = "LKDT_LODDataSet";
            this.lKDT_LODDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lKDTLODDataSetBindingSource
            // 
            this.lKDTLODDataSetBindingSource.DataSource = this.lKDT_LODDataSet;
            this.lKDTLODDataSetBindingSource.Position = 0;
            // 
            // dsCLV
            // 
            this.dsCLV.AutoGenerateColumns = false;
            this.dsCLV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsCLV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ma_TGLV,
            this.manv,
            this.TenNV,
            this.ca,
            this.thu});
            this.dsCLV.DataSource = this.lKDTLODDataSetBindingSource;
            this.dsCLV.Location = new System.Drawing.Point(29, 294);
            this.dsCLV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dsCLV.Name = "dsCLV";
            this.dsCLV.Size = new System.Drawing.Size(653, 351);
            this.dsCLV.TabIndex = 41;
            this.dsCLV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dsCLV_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 60;
            // 
            // ma_TGLV
            // 
            this.ma_TGLV.DataPropertyName = "ma_TGLV";
            this.ma_TGLV.HeaderText = "Mã PCCV";
            this.ma_TGLV.Name = "ma_TGLV";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "ma_nv";
            this.manv.HeaderText = "Mã NV";
            this.manv.Name = "manv";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "ten_nv";
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.Name = "TenNV";
            // 
            // ca
            // 
            this.ca.DataPropertyName = "ca";
            this.ca.HeaderText = "Ca(sáng,trưa,tối)";
            this.ca.Name = "ca";
            this.ca.Width = 150;
            // 
            // thu
            // 
            this.thu.DataPropertyName = "thu";
            this.thu.HeaderText = "Thứ";
            this.thu.Name = "thu";
            // 
            // cbtMaNV
            // 
            this.cbtMaNV.FormattingEnabled = true;
            this.cbtMaNV.Location = new System.Drawing.Point(111, 88);
            this.cbtMaNV.Name = "cbtMaNV";
            this.cbtMaNV.Size = new System.Drawing.Size(197, 25);
            this.cbtMaNV.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 20;
            // 
            // lblMasp
            // 
            this.lblMasp.AutoSize = true;
            this.lblMasp.Location = new System.Drawing.Point(26, 91);
            this.lblMasp.Name = "lblMasp";
            this.lblMasp.Size = new System.Drawing.Size(51, 17);
            this.lblMasp.TabIndex = 3;
            this.lblMasp.Text = "Mã NV:";
            // 
            // txtca
            // 
            this.txtca.Location = new System.Drawing.Point(384, 49);
            this.txtca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtca.Name = "txtca";
            this.txtca.Size = new System.Drawing.Size(168, 24);
            this.txtca.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên NV:";
            // 
            // txtThu
            // 
            this.txtThu.Location = new System.Drawing.Point(384, 91);
            this.txtThu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThu.Name = "txtThu";
            this.txtThu.Size = new System.Drawing.Size(168, 24);
            this.txtThu.TabIndex = 12;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(111, 131);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(197, 24);
            this.txtTenSP.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thứ:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(29, 263);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(284, 23);
            this.txtTimKiem.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbtMaNV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMasp);
            this.groupBox1.Controls.Add(this.txtca);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtThu);
            this.groupBox1.Controls.Add(this.txtPCCV);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(29, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(580, 170);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã PCCV:";
            // 
            // txtPCCV
            // 
            this.txtPCCV.Location = new System.Drawing.Point(111, 51);
            this.txtPCCV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPCCV.Name = "txtPCCV";
            this.txtPCCV.Size = new System.Drawing.Size(197, 24);
            this.txtPCCV.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ca:";
            // 
            // btnIN
            // 
            this.btnIN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnIN.ImageOptions.Image")));
            this.btnIN.Location = new System.Drawing.Point(721, 249);
            this.btnIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(87, 37);
            this.btnIN.TabIndex = 57;
            this.btnIN.Text = "In";
            // 
            // frmTGLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 665);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.radTimTheoTen);
            this.Controls.Add(this.radMa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dsCLV);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTGLV";
            this.Text = "frmTGLV";
            this.Load += new System.EventHandler(this.frmTGLV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCLV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radTimTheoTen;
        private System.Windows.Forms.RadioButton radMa;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label6;
        private LKDT_LODDataSet lKDT_LODDataSet;
        private System.Windows.Forms.BindingSource lKDTLODDataSetBindingSource;
        private System.Windows.Forms.DataGridView dsCLV;
        private System.Windows.Forms.ComboBox cbtMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMasp;
        private System.Windows.Forms.TextBox txtca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThu;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_TGLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ca;
        private System.Windows.Forms.DataGridViewTextBoxColumn thu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPCCV;
    }
}