namespace tugas_PBO_08012019
{
    partial class frm_ReportKaryawanGaji
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
            this.repotKaryawanGaji = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // repotKaryawanGaji
            // 
            this.repotKaryawanGaji.Location = new System.Drawing.Point(0, 0);
            this.repotKaryawanGaji.Name = "ReportViewer";
            this.repotKaryawanGaji.Size = new System.Drawing.Size(1000, 400);
            this.repotKaryawanGaji.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.repotKaryawanGaji);
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 400);
            this.panel1.TabIndex = 0;
            // 
            // frm_ReportKaryawanGaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1032, 437);
            this.Controls.Add(this.panel1);
            this.Name = "frm_ReportKaryawanGaji";
            this.Text = "frm_ReportKaryawanGaji";
            this.Load += new System.EventHandler(this.Frm_ReportKaryawanGaji_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repotKaryawanGaji;
        private System.Windows.Forms.Panel panel1;
    }
}