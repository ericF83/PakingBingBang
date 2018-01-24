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
    public partial class FRMPendientes : Form
    {
        Conexion conex = new Conexion();
        FRMprincipal Frm = new FRMprincipal();
        public FRMPendientes(FRMprincipal frm)
        {
            InitializeComponent();
            this.Frm = frm;
        }

        private void FRMPendientes_Load(object sender, EventArgs e)
        {
            conex.Pendientes(this);
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Dictionary<int, string> ordenes = new Dictionary<int, string>();
            int idpack = (int)(dgvArticulos.Rows[e.RowIndex].Cells["ID"].Value);
            ordenes = conex.ListaOrden(idpack);
            FRMPacking F = new FRMPacking(true);
            F.AgregarTap(ordenes, idpack);
            F.TopLevel = false;
            F.StartPosition = FormStartPosition.CenterScreen;
            F.Parent = Frm.PnlPrincipal;
            F.Show();
            F.BringToFront();
        }
    }
}
