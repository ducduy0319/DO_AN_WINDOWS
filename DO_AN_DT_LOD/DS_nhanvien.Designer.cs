namespace DO_AN_DT_LOD
{
    partial class DS_nhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DS_nhanvien));
            this.txtGioiTinh = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateNgaySinh = new System.Windows.Forms.Label();
            this.txtSĐT = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dsNhanVien = new System.Windows.Forms.DataGridView();
            this.ma_nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lKDTLODDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lKDT_LODDataSet = new DO_AN_DT_LOD.LKDT_LODDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.AutoSize = true;
            this.txtGioiTinh.Location = new System.Drawing.Point(259, 28);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(51, 13);
            this.txtGioiTinh.TabIndex = 0;
            this.txtGioiTinh.Text = "Giới Tính:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 21);
            this.textBox1.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.AutoSize = true;
            this.txtMaNV.Location = new System.Drawing.Point(24, 31);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(41, 13);
            this.txtMaNV.TabIndex = 3;
            this.txtMaNV.Text = "Mã NV:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoSize = true;
            this.txtTenNV.Location = new System.Drawing.Point(24, 72);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(45, 13);
            this.txtTenNV.TabIndex = 4;
            this.txtTenNV.Text = "Tên NV:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.Location = new System.Drawing.Point(24, 106);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(45, 13);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.Text = "Địa Chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 12F);
            this.label6.Location = new System.Drawing.Point(279, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.AutoSize = true;
            this.dateNgaySinh.Location = new System.Drawing.Point(259, 64);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(59, 13);
            this.dateNgaySinh.TabIndex = 9;
            this.dateNgaySinh.Text = "Ngày Sinh:";
            // 
            // txtSĐT
            // 
            this.txtSĐT.AutoSize = true;
            this.txtSĐT.Location = new System.Drawing.Point(259, 103);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(31, 13);
            this.txtSĐT.TabIndex = 10;
            this.txtSĐT.Text = "SĐT:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 21);
            this.textBox3.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(77, 28);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(130, 21);
            this.textBox6.TabIndex = 15;
            // 
            // dsNhanVien
            // 
            this.dsNhanVien.AutoGenerateColumns = false;
            this.dsNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_nv,
            this.ten_nv,
            this.gioitinh,
            this.ngaysinh,
            this.diachi,
            this.sdt});
            this.dsNhanVien.DataSource = this.lKDTLODDataSetBindingSource;
            this.dsNhanVien.Location = new System.Drawing.Point(56, 250);
            this.dsNhanVien.Name = "dsNhanVien";
            this.dsNhanVien.Size = new System.Drawing.Size(651, 150);
            this.dsNhanVien.TabIndex = 17;
            // 
            // ma_nv
            // 
            this.ma_nv.DataPropertyName = "ma_nv";
            this.ma_nv.HeaderText = "Mã NV";
            this.ma_nv.Name = "ma_nv";
            // 
            // ten_nv
            // 
            this.ten_nv.DataPropertyName = "ten_nv";
            this.ten_nv.HeaderText = "Tên NV";
            this.ten_nv.Name = "ten_nv";
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.Name = "diachi";
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "SĐT";
            this.sdt.Name = "sdt";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtSĐT);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.dateNgaySinh);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(56, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 185);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "thông tin nhân viên";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 21);
            this.textBox2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(324, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 21);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(387, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(324, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(568, 145);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 29);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(568, 101);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(568, 189);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 29);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(568, 58);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // DS_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 486);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dsNhanVien);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DS_nhanvien";
            this.Text = "DS_nhanvien";
            this.Load += new System.EventHandler(this.DS_nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtGioiTinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtMaNV;
        private System.Windows.Forms.Label txtTenNV;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dateNgaySinh;
        private System.Windows.Forms.Label txtSĐT;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dsNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.BindingSource lKDTLODDataSetBindingSource;
        private LKDT_LODDataSet lKDT_LODDataSet;
    }
}