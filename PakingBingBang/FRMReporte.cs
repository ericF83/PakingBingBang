using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PakingBingBang
{
    public partial class FRMReporte : Form
    {
        public List<Datos> Indatos = new List<Datos>();
        public FRMReporte()
        {
            InitializeComponent();
        }

        private void FRMReporte_Load(object sender, EventArgs e)
        {
            this.RpPacking.LocalReport.DataSources.Clear();
            this.RpPacking.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet", Indatos));
            this.RpPacking.RefreshReport();
        }

        private void RpPacking_Print(object sender, Microsoft.Reporting.WinForms.ReportPrintEventArgs e)
        {
            var setup = RpPacking.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(1,1,1,1);
            setup.Landscape = true;
            RpPacking.SetPageSettings(setup);
        }

        private void RpPacking_ReportExport(object sender, Microsoft.Reporting.WinForms.ReportExportEventArgs e)
        {
            //string ext = e.Extension.Name;
            //if(ext == "PDF")
            //{

            //}
            //e.Cancel = true;
            //string mimeType;
            //string encoding;
            //string fileNameExtension;
            //string[] streams;
            //Microsoft.Reporting.WinForms.Warning[] warnings;

            //Microsoft.Reporting.WinForms.Report report;
            //if (RpPacking.ProcessingMode == Microsoft.Reporting.WinForms.ProcessingMode.Local)
            //    report = RpPacking.LocalReport;
            //else
            //    report = RpPacking.ServerReport;

            //ReportPageSettings pages; 
            //pages = RpPacking.LocalReport.GetDefaultPageSettings();
            
            //var bytes = report.Render(e.Extension.Name, e.DeviceInfo,
            //                Microsoft.Reporting.WinForms.PageCountMode.Actual, out mimeType,
            //                out encoding, out fileNameExtension, out streams, out warnings);

            //var path = string.Format(@"C:\file\file.{0}", fileNameExtension);
            //System.IO.File.WriteAllBytes(path, bytes);


            //MessageBox.Show(string.Format("Exported to {0}", path));
        }
    }
}
