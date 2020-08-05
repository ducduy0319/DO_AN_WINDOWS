namespace DO_AN_DT_LOD
{
    partial class frmIHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIHD));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsohoadon = new System.Windows.Forms.TextBox();
            this.txtsohoadonct = new System.Windows.Forms.TextBox();
            this.btninhoadon = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.dgvhdct = new System.Windows.Forms.DataGridView();
            this.radTimTheoTen = new System.Windows.Forms.RadioButton();
            this.radMa = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sohoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sohoadonct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhdct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Hóa Đơn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Hóa Đơn CT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "IN HÓA ĐƠN";
            // 
            // txtsohoadon
            // 
            this.txtsohoadon.Location = new System.Drawing.Point(239, 111);
            this.txtsohoadon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsohoadon.Name = "txtsohoadon";
            this.txtsohoadon.Size = new System.Drawing.Size(116, 23);
            this.txtsohoadon.TabIndex = 4;
            // 
            // txtsohoadonct
            // 
            this.txtsohoadonct.Location = new System.Drawing.Point(490, 111);
            this.txtsohoadonct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsohoadonct.Name = "txtsohoadonct";
            this.txtsohoadonct.Size = new System.Drawing.Size(116, 23);
            this.txtsohoadonct.TabIndex = 5;
            // 
            // btninhoadon
            // 
            this.btninhoadon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btninhoadon.ImageOptions.Image")));
            this.btninhoadon.Location = new System.Drawing.Point(622, 81);
            this.btninhoadon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btninhoadon.Name = "btninhoadon";
            this.btninhoadon.Size = new System.Drawing.Size(87, 47);
            this.btninhoadon.TabIndex = 9;
            this.btninhoadon.Text = "In HD";
            this.btninhoadon.Click += new System.EventHandler(this.btninhoadon_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(622, 135);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(87, 48);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dgvhdct
            // 
            this.dgvhdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhdct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.sohoadon,
            this.sohoadonct,
            this.ten_sp,
            this.soluong,
            this.dongia,
            this.thanhtien});
            this.dgvhdct.Location = new System.Drawing.Point(1, 266);
            this.dgvhdct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvhdct.Name = "dgvhdct";
            this.dgvhdct.Size = new System.Drawing.Size(873, 185);
            this.dgvhdct.TabIndex = 11;
            this.dgvhdct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhdct_CellContentClick);
            this.dgvhdct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvhdct_DataBindingComplete);
            // 
            // radTimTheoTen
            // 
            this.radTimTheoTen.AutoSize = true;
            this.radTimTheoTen.Location = new System.Drawing.Point(607, 210);
            this.radTimTheoTen.Name = "radTimTheoTen";
            this.radTimTheoTen.Size = new System.Drawing.Size(200, 21);
            this.radTimTheoTen.TabIndex = 43;
            this.radTimTheoTen.Text = "Tìm theo số hóa đơn chi tiết";
            this.radTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // radMa
            // 
            this.radMa.AutoSize = true;
            this.radMa.Checked = true;
            this.radMa.Location = new System.Drawing.Point(417, 209);
            this.radMa.Name = "radMa";
            this.radMa.Size = new System.Drawing.Size(156, 21);
            this.radMa.TabIndex = 42;
            this.radMa.TabStop = true;
            this.radMa.Text = "Tìm theo số hóa đơn";
            this.radMa.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(101, 209);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(284, 23);
            this.txtTimKiem.TabIndex = 41;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tìm Kiếm:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // sohoadon
            // 
            this.sohoadon.DataPropertyName = "sohoadon";
            this.sohoadon.HeaderText = "Số Hóa Đơn ";
            this.sohoadon.Name = "sohoadon";
            this.sohoadon.Width = 120;
            // 
            // sohoadonct
            // 
            this.sohoadonct.DataPropertyName = "sohoadonct";
            this.sohoadonct.HeaderText = "Số Hóa Đơn CT";
            this.sohoadonct.Name = "sohoadonct";
            this.sohoadonct.Width = 140;
            // 
            // ten_sp
            // 
            this.ten_sp.DataPropertyName = "ten_sp";
            this.ten_sp.HeaderText = "Tên Sản Phẩm";
            this.ten_sp.Name = "ten_sp";
            this.ten_sp.Width = 145;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số Lượng";
            this.soluong.Name = "soluong";
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn Giá";
            this.dongia.Name = "dongia";
            // 
            // thanhtien
            // 
            this.thanhtien.DataPropertyName = "thanhtien";
            this.thanhtien.HeaderText = "Thành Tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.Width = 120;
            // 
            // frmIHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 577);
            this.Controls.Add(this.radTimTheoTen);
            this.Controls.Add(this.radMa);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvhdct);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btninhoadon);
            this.Controls.Add(this.txtsohoadonct);
            this.Controls.Add(this.txtsohoadon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIHD";
            this.Text = "IN HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmIHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhdct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsohoadon;
        private System.Windows.Forms.TextBox txtsohoadonct;
        private DevExpress.XtraEditors.SimpleButton btninhoadon;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private System.Windows.Forms.DataGridView dgvhdct;
        private System.Windows.Forms.RadioButton radTimTheoTen;
        private System.Windows.Forms.RadioButton radMa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohoadonct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}