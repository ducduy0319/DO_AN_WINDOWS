namespace DO_AN_DT_LOD
{
    partial class frmThoiGianLV
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
            this.rptvTGLV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvTGLV
            // 
            this.rptvTGLV.ActiveViewIndex = -1;
            this.rptvTGLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvTGLV.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvTGLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvTGLV.Location = new System.Drawing.Point(0, 0);
            this.rptvTGLV.Name = "rptvTGLV";
            this.rptvTGLV.Size = new System.Drawing.Size(659, 268);
            this.rptvTGLV.TabIndex = 0;
            // 
            // frmThoiGianLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 268);
            this.Controls.Add(this.rptvTGLV);
            this.Name = "frmThoiGianLV";
            this.Text = "frmThoiGianLV";
            this.Load += new System.EventHandler(this.frmThoiGianLV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvTGLV;
    }
}