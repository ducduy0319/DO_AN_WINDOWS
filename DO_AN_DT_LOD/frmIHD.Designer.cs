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
            this.label4 = new System.Windows.Forms.Label();
            this.txtsohoadon = new System.Windows.Forms.TextBox();
            this.txtsohoadonct = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ratheoten = new System.Windows.Forms.RadioButton();
            this.ratheoma = new System.Windows.Forms.RadioButton();
            this.btninhoadon = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.dgvhdct = new System.Windows.Forms.DataGridView();
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
            this.label1.Location = new System.Drawing.Point(119, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Hóa Đơn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Hóa Đơn CT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IN HÓA ĐƠN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tìm Kiếm:";
            // 
            // txtsohoadon
            // 
            this.txtsohoadon.Location = new System.Drawing.Point(205, 90);
            this.txtsohoadon.Name = "txtsohoadon";
            this.txtsohoadon.Size = new System.Drawing.Size(100, 21);
            this.txtsohoadon.TabIndex = 4;
            // 
            // txtsohoadonct
            // 
            this.txtsohoadonct.Location = new System.Drawing.Point(420, 90);
            this.txtsohoadonct.Name = "txtsohoadonct";
            this.txtsohoadonct.Size = new System.Drawing.Size(100, 21);
            this.txtsohoadonct.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(170, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 21);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ratheoten
            // 
            this.ratheoten.AutoSize = true;
            this.ratheoten.Location = new System.Drawing.Point(314, 149);
            this.ratheoten.Name = "ratheoten";
            this.ratheoten.Size = new System.Drawing.Size(70, 17);
            this.ratheoten.TabIndex = 7;
            this.ratheoten.TabStop = true;
            this.ratheoten.Text = "Theo Tên";
            this.ratheoten.UseVisualStyleBackColor = true;
            // 
            // ratheoma
            // 
            this.ratheoma.AutoSize = true;
            this.ratheoma.Location = new System.Drawing.Point(407, 150);
            this.ratheoma.Name = "ratheoma";
            this.ratheoma.Size = new System.Drawing.Size(66, 17);
            this.ratheoma.TabIndex = 8;
            this.ratheoma.TabStop = true;
            this.ratheoma.Text = "Theo Mã";
            this.ratheoma.UseVisualStyleBackColor = true;
            // 
            // btninhoadon
            // 
            this.btninhoadon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btninhoadon.ImageOptions.Image")));
            this.btninhoadon.Location = new System.Drawing.Point(533, 66);
            this.btninhoadon.Name = "btninhoadon";
            this.btninhoadon.Size = new System.Drawing.Size(75, 38);
            this.btninhoadon.TabIndex = 9;
            this.btninhoadon.Text = "In HD";
            this.btninhoadon.Click += new System.EventHandler(this.btninhoadon_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(533, 110);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 39);
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
            this.dgvhdct.Location = new System.Drawing.Point(1, 216);
            this.dgvhdct.Name = "dgvhdct";
            this.dgvhdct.Size = new System.Drawing.Size(745, 150);
            this.dgvhdct.TabIndex = 11;
            this.dgvhdct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhdct_CellContentClick);
            this.dgvhdct.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvhdct_DataBindingComplete);
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
            // 
            // sohoadonct
            // 
            this.sohoadonct.DataPropertyName = "sohoadonct";
            this.sohoadonct.HeaderText = "Số Hóa Đơn CT";
            this.sohoadonct.Name = "sohoadonct";
            // 
            // ten_sp
            // 
            this.ten_sp.DataPropertyName = "ten_sp";
            this.ten_sp.HeaderText = "Tên Sản Phẩm";
            this.ten_sp.Name = "ten_sp";
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
            // 
            // frmIHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 469);
            this.Controls.Add(this.dgvhdct);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btninhoadon);
            this.Controls.Add(this.ratheoma);
            this.Controls.Add(this.ratheoten);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtsohoadonct);
            this.Controls.Add(this.txtsohoadon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIHD";
            this.Text = "frmIHD";
            this.Load += new System.EventHandler(this.frmIHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhdct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsohoadon;
        private System.Windows.Forms.TextBox txtsohoadonct;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton ratheoten;
        private System.Windows.Forms.RadioButton ratheoma;
        private DevExpress.XtraEditors.SimpleButton btninhoadon;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private System.Windows.Forms.DataGridView dgvhdct;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn sohoadonct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}