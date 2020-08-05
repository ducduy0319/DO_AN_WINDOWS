namespace DO_AN_DT_LOD
{
    partial class frmTKDTcs
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
            this.rptvTK = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvTK
            // 
            this.rptvTK.ActiveViewIndex = -1;
            this.rptvTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvTK.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvTK.Location = new System.Drawing.Point(0, 0);
            this.rptvTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rptvTK.Name = "rptvTK";
            this.rptvTK.Size = new System.Drawing.Size(675, 380);
            this.rptvTK.TabIndex = 0;
            this.rptvTK.ToolPanelWidth = 233;
            // 
            // frmTKDTcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 380);
            this.Controls.Add(this.rptvTK);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTKDTcs";
            this.Text = "THỐNG KÊ DOANH THU";
            this.Load += new System.EventHandler(this.frmTKDTcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvTK;
    }
}