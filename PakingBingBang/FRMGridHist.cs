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
    public partial class FRMGridHist : Form
    {
        Conexion conex = new Conexion();
        public FRMGridHist()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           if(dtpDe.Value.CompareTo(dtpA.Value) == 1)
            {
                MessageBox.Show("La fecha 'DESDE' no puede ser mayor que hasta");
            }
            else
            {
                dgvArticulos.Rows.Clear();
                conex.Historico(this, 0,"FECHA", dtpDe.Value.ToString("yyyy-MM-dd"), dtpA.Value.ToString("yyyy-MM-dd"));
            }             
        }

        private void btnXAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtXID.Text))
            {
                dgvArticulos.Rows.Clear();
                conex.Historico(this, Convert.ToInt32(txtXID.Text), "ID", "", "");
            }
            else
            {
                MessageBox.Show("Debe de introducir un ID");
            }
        }

        private void txtXID_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnXAdd.PerformClick();
            }
        }

        private void dtpDe_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnXHist.PerformClick();
            }
        }

        private void dtpA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnXHist.PerformClick();
            }
        }

        private void dgvArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          int id = (int)(dgvArticulos.Rows[e.RowIndex].Cells["ID"].Value);
            conex.GeneraReporte(id);
        }
    }
}
