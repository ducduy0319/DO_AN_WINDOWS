namespace DO_AN_DT_LOD
{
    partial class frmLuongNV
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
            this.rptvLuongNV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvLuongNV
            // 
            this.rptvLuongNV.ActiveViewIndex = -1;
            this.rptvLuongNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvLuongNV.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvLuongNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvLuongNV.Location = new System.Drawing.Point(0, 0);
            this.rptvLuongNV.Name = "rptvLuongNV";
            this.rptvLuongNV.Size = new System.Drawing.Size(726, 268);
            this.rptvLuongNV.TabIndex = 0;
            // 
            // frmLuongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 268);
            this.Controls.Add(this.rptvLuongNV);
            this.Name = "frmLuongNV";
            this.Text = "frmLuongNV";
            this.Load += new System.EventHandler(this.frmLuongNV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvLuongNV;
    }
}