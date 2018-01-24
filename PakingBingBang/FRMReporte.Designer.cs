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
            this.RpPacking = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.RpPacking.Size = new System.Drawing.Size(1191, 603);
            this.RpPacking.TabIndex = 0;
            this.RpPacking.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.RpPacking_Print);
            // 
            // DatosBindingSource
            // 
            this.DatosBindingSource.DataSource = typeof(PakingBingBang.Datos);
            // 
            // FRMReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 603);
            this.Controls.Add(this.RpPacking);
            this.Name = "FRMReporte";
            this.Text = "FRMReporte";
            this.Load += new System.EventHandler(this.FRMReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RpPacking;
        private System.Windows.Forms.BindingSource DatosBindingSource;
    }
}