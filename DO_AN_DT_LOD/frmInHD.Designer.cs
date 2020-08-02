namespace DO_AN_DT_LOD
{
    partial class frmInHD
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
            this.rplvHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rplvHD
            // 
            this.rplvHD.ActiveViewIndex = -1;
            this.rplvHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rplvHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.rplvHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rplvHD.Location = new System.Drawing.Point(0, 0);
            this.rplvHD.Name = "rplvHD";
            this.rplvHD.Size = new System.Drawing.Size(618, 268);
            this.rplvHD.TabIndex = 0;
            // 
            // frmInHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 268);
            this.Controls.Add(this.rplvHD);
            this.Name = "frmInHD";
            this.Text = "frmInHD";
            this.Load += new System.EventHandler(this.frmInHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rplvHD;
    }
}