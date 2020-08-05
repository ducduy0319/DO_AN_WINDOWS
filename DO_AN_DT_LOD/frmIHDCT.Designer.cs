namespace DO_AN_DT_LOD
{
    partial class frmIHDCT
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
            this.rptvIHDCT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvIHDCT
            // 
            this.rptvIHDCT.ActiveViewIndex = -1;
            this.rptvIHDCT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvIHDCT.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvIHDCT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvIHDCT.Location = new System.Drawing.Point(0, 0);
            this.rptvIHDCT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rptvIHDCT.Name = "rptvIHDCT";
            this.rptvIHDCT.Size = new System.Drawing.Size(803, 330);
            this.rptvIHDCT.TabIndex = 0;
            this.rptvIHDCT.ToolPanelWidth = 233;
            // 
            // frmIHDCT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 330);
            this.Controls.Add(this.rptvIHDCT);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIHDCT";
            this.Text = "IN HÓA ĐƠN CHI TIẾT";
            this.Load += new System.EventHandler(this.frmIHDCT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvIHDCT;
    }
}