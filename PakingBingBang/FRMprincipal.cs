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
    public partial class FRMprincipal : Form
    {
        public FRMprincipal()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            quitar();
            FRMBuscaOrd nuevo = new FRMBuscaOrd(this);
            nuevo.TopLevel = false;
            nuevo.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            nuevo.Parent = PnlPrincipal;
            nuevo.Show();
            nuevo.BringToFront();
            //AddFormInPanel(new FRMBuscaOrd());

        }

        private void btnXCancel_Click(object sender, EventArgs e)
        {
            FRMGridHist hist = new FRMGridHist();
            hist.TopLevel = false;
            hist.StartPosition = FormStartPosition.CenterScreen;
            hist.Parent = PnlPrincipal;
            hist.Show();
            hist.BringToFront();
        }

        private void btnXPend_Click(object sender, EventArgs e)
        {
            quitar();
            FRMPendientes pendiente = new FRMPendientes(this);
            pendiente.TopLevel = false;
            pendiente.StartPosition = FormStartPosition.CenterScreen;
            pendiente.Parent = PnlPrincipal;
            pendiente.Show();
            pendiente.BringToFront();
            
        }

        public void quitar()
        {
            //if (this.PnlPrincipal.Controls.Count > 0)
            //    this.PnlPrincipal.Controls.RemoveAt(0);
            foreach (Control ctr in this.PnlPrincipal.Controls)
            {
                if (ctr is Form)
                    this.PnlPrincipal.Controls.Remove(ctr);
            }
        }

        private void AddFormInPanel(object formHijo)
        {
            if (this.PnlPrincipal.Controls.Count > 0)
                this.PnlPrincipal.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            //fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            fh.BringToFront();
            this.PnlPrincipal.Controls.Add(fh);
            //this.PnlPrincipal.Tag = fh;
            fh.Show();

        }
    }
}
