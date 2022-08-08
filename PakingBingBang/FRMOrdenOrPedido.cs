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
    public partial class FRMOrdenOrPedido : Form
    {
        public string tipoMov = "";
        FRMBuscaOrd Frm = new FRMBuscaOrd();
        public FRMOrdenOrPedido(FRMBuscaOrd frm)
        {
            InitializeComponent();
            this.Frm = frm;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rdbOR.Checked)
                Frm.TipoMov = "Orden Surtido";
            else if (rdbPED.Checked)
                Frm.TipoMov = "Solicitud";
            this.Close();
        }
    }
}
