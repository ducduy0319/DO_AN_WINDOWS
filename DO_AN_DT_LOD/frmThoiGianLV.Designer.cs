﻿namespace DO_AN_DT_LOD
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
            this.rptvTGLV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rptvTGLV.Name = "rptvTGLV";
            this.rptvTGLV.Size = new System.Drawing.Size(769, 330);
            this.rptvTGLV.TabIndex = 0;
            this.rptvTGLV.ToolPanelWidth = 233;
            // 
            // frmThoiGianLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 330);
            this.Controls.Add(this.rptvTGLV);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThoiGianLV";
            this.Text = "THỜI GIAN LV";
            this.Load += new System.EventHandler(this.frmThoiGianLV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvTGLV;
    }
}