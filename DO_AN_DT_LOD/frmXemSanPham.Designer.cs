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
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btntimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtloc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnloc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lKDT_LODDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lKDTLODDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 24);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nhập từ khóa để tìm kiếm :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.label6.Location = new System.Drawing.Point(356, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 28);
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
            this.dgvDSSP.Location = new System.Drawing.Point(12, 223);
            this.dgvDSSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.Size = new System.Drawing.Size(956, 396);
            this.dgvDSSP.TabIndex = 36;
            this.dgvDSSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellContentClick);
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
            this.btnThoat.Location = new System.Drawing.Point(868, 627);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 44);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(291, 80);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttimkiem.Multiline = true;
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(267, 37);
            this.txttimkiem.TabIndex = 43;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            this.txttimkiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttimkiem_KeyPress);
            this.txttimkiem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txttimkiem_MouseDown);
            // 
            // btntimkiem
            // 
            this.btntimkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.ImageOptions.Image")));
            this.btntimkiem.Location = new System.Drawing.Point(581, 80);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(43, 37);
            this.btntimkiem.TabIndex = 46;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtloc
            // 
            this.txtloc.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtloc.Location = new System.Drawing.Point(291, 137);
            this.txtloc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtloc.Multiline = true;
            this.txtloc.Name = "txtloc";
            this.txtloc.Size = new System.Drawing.Size(267, 37);
            this.txtloc.TabIndex = 43;
            this.txtloc.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            this.txtloc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtloc_KeyPress);
            this.txtloc.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtloc_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nhập từ khóa để lọc :";
            // 
            // btnloc
            // 
            this.btnloc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnloc.ImageOptions.Image")));
            this.btnloc.Location = new System.Drawing.Point(581, 137);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(43, 37);
            this.btnloc.TabIndex = 46;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // frmXemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 684);
            this.Controls.Add(this.btnloc);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtloc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDSSP);
            this.Name = "frmXemSanPham";
            this.Text = "frmXemSanPham";
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
        private System.Windows.Forms.TextBox txttimkiem;
        private DevExpress.XtraEditors.SimpleButton btntimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonkho;
        private System.Windows.Forms.TextBox txtloc;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnloc;
    }
}