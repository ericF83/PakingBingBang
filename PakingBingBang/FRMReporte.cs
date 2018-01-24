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
    }
}
