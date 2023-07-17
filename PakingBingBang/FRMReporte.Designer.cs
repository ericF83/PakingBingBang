namespace PakingBingBang
{
    partial class FRMReporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMReporte));
            this.RpPacking = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RpPacking
            // 
            this.RpPacking.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.DatosBindingSource;
            this.RpPacking.LocalReport.DataSources.Add(reportDataSource1);
            this.RpPacking.LocalReport.ReportEmbeddedResource = "PakingBingBang.Report.rdlc";
            this.RpPacking.Location = new System.Drawing.Point(0, 0);
            this.RpPacking.Name = "RpPacking";
            this.RpPacking.Size = new System.Drawing.Size(1337, 603);
            this.RpPacking.TabIndex = 0;
            this.RpPacking.ReportExport += new Microsoft.Reporting.WinForms.ExportEventHandler(this.RpPacking_ReportExport);
            this.RpPacking.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.RpPacking_Print);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(718, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DatosBindingSource
            // 
            this.DatosBindingSource.DataSource = typeof(PakingBingBang.Datos);
            // 
            // FRMReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RpPacking);
            this.Name = "FRMReporte";
            this.Text = "FRMReporte";
            this.Load += new System.EventHandler(this.FRMReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpPacking;
        private System.Windows.Forms.BindingSource DatosBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}