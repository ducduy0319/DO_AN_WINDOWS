namespace DO_AN_DT_LOD
{
    partial class frmXemSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemSanPham));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lKDT_LODDataSet = new DO_AN_DT_LOD.LKDT_LODDataSet();
            this.lKDTLODDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma_loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonkho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.radTimTheoTen = new System.Windows.Forms.RadioButton();
            this.radMa = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nhập từ khóa để tìm kiếm :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.label6.Location = new System.Drawing.Point(305, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "THÔNG TIN SẢN PHẨM";
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
            // dgvDSSP
            // 
            this.dgvDSSP.AutoGenerateColumns = false;
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ma_sp,
            this.ma_loai,
            this.ten_sp,
            this.donvitinh,
            this.dongia,
            this.SoLuong,
            this.tonkho});
            this.dgvDSSP.DataSource = this.lKDTLODDataSetBindingSource;
            this.dgvDSSP.Location = new System.Drawing.Point(10, 181);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.Size = new System.Drawing.Size(819, 322);
            this.dgvDSSP.TabIndex = 36;
            this.dgvDSSP.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSHD_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // ma_sp
            // 
            this.ma_sp.DataPropertyName = "ma_sp";
            this.ma_sp.HeaderText = "Mã SP";
            this.ma_sp.Name = "ma_sp";
            this.ma_sp.Width = 125;
            // 
            // ma_loai
            // 
            this.ma_loai.DataPropertyName = "ma_loai";
            this.ma_loai.HeaderText = "Mã Loại";
            this.ma_loai.Name = "ma_loai";
            this.ma_loai.Width = 125;
            // 
            // ten_sp
            // 
            this.ten_sp.DataPropertyName = "ten_sp";
            this.ten_sp.HeaderText = "Tên SP";
            this.ten_sp.Name = "ten_sp";
            this.ten_sp.Width = 125;
            // 
            // donvitinh
            // 
            this.donvitinh.DataPropertyName = "donvitinh";
            this.donvitinh.HeaderText = "ĐVT";
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.Width = 125;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.Name = "dongia";
            this.dongia.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "soluong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // tonkho
            // 
            this.tonkho.DataPropertyName = "tonkho";
            this.tonkho.HeaderText = "Tồn Kho";
            this.tonkho.Name = "tonkho";
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(744, 509);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 36);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // radTimTheoTen
            // 
            this.radTimTheoTen.AutoSize = true;
            this.radTimTheoTen.Location = new System.Drawing.Point(385, 116);
            this.radTimTheoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radTimTheoTen.Name = "radTimTheoTen";
            this.radTimTheoTen.Size = new System.Drawing.Size(89, 17);
            this.radTimTheoTen.TabIndex = 50;
            this.radTimTheoTen.Text = "Tìm Theo Tên";
            this.radTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // radMa
            // 
            this.radMa.AutoSize = true;
            this.radMa.Checked = true;
            this.radMa.Location = new System.Drawing.Point(238, 116);
            this.radMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radMa.Name = "radMa";
            this.radMa.Size = new System.Drawing.Size(83, 17);
            this.radMa.TabIndex = 49;
            this.radMa.TabStop = true;
            this.radMa.Text = "Tìm theo mã";
            this.radMa.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(238, 71);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(244, 21);
            this.txtTimKiem.TabIndex = 48;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Chọn Loại:";
            // 
            // frmXemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 556);
            this.Controls.Add(this.radTimTheoTen);
            this.Controls.Add(this.radMa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDSSP);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmXemSanPham";
            this.Text = "Xem Sản Phẩm";
            this.Load += new System.EventHandler(this.frmXemSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private LKDT_LODDataSet lKDT_LODDataSet;
        private System.Windows.Forms.BindingSource lKDTLODDataSetBindingSource;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonkho;
        private System.Windows.Forms.RadioButton radTimTheoTen;
        private System.Windows.Forms.RadioButton radMa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
    }
}