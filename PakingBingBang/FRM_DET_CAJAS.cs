using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PakingBingBang
{
    public partial class FRM_DET_CAJAS : Form
    {
        int id_pack;
        int id_caja;
        bool cerrar = false;
        public bool Cancelado = false;
        Conexion conex = new Conexion();
        FRMPacking FRM = new FRMPacking(false);
        public FRM_DET_CAJAS(int idpack, int idcaja, FRMPacking frmP)
        {
            InitializeComponent();
            this.id_pack = idpack;
            this.id_caja = idcaja;
            this.FRM = frmP;
        }

        private void FRM_DET_CAJAS_Load(object sender, EventArgs e)
        {
            conex.DetalleDeCaja(this, id_pack, id_caja);
            conex.DetalleDeCajaPrec(this,id_pack, id_caja);
            conex.Modas(this);
            conex.get_datosCaja(this, id_pack, id_caja);
            

        }

        private void btnXSave_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(cmbXModa.Text))
            //{
            //    MessageBox.Show("Falta capturar dimenciones");
            //    return;
            //}
            
            if (String.IsNullOrEmpty(txtXPesoB.Text))
            {
                MessageBox.Show("Falta capturar Peso Bruto");
                return;
            }
            else if(Convert.ToDecimal(txtXPesoB.Text) * 1 == 0)
            {
                MessageBox.Show("No puede ser 0");
                return;
            }
            if (String.IsNullOrEmpty(txtXPesoN.Text))
            {
                MessageBox.Show("Falta capturar Peso Neto");
                return;
            }

            if(String.IsNullOrEmpty("Falta capturar Tara"))
            {
                MessageBox.Show("Falta capturar Tara");
                return;
            }

            if (conex.UpdateCaja(id_pack, id_caja, cmbXModa.SelectedValue.ToString(), Convert.ToDecimal(txtXPesoB.Text), Convert.ToDecimal(txtXPesoN.Text), Convert.ToDecimal(txtXtara.Text)))
            {
                //conex.UpdateMODA(id_pack, id_caja, Convert.ToInt32(cmbXModa.SelectedValue.ToString()));
                MessageBox.Show("Datos Grabados");
                cerrar = true;
                this.Dispose();
            }
                


        }

        private void txtXPesoB_TextChanged(object sender, EventArgs e)
        {
            validaPunto(txtXPesoB);
            if (txtXPesoB.Text.Length == 0)
                lblPbruto.Visible = false;
            else
                lblPbruto.Visible = true;
        }

        public void validaPunto(DevComponents.DotNetBar.Controls.TextBoxX txt)
        {
            int cont = 0;
            for (int x = 0; x <= txt.Text.Count() - 1; x++)
            {
                if (txt.Text.Substring(x, 1) == ".")
                {
                    cont++;
                }
            }

            if (cont > 1)
            {
                MessageBox.Show("el formato es incorrecto");
                txt.Text = String.Empty;
            }

        }

        private void txtXPesoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            bool existePunto = false;
            
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtXPesoN_TextChanged(object sender, EventArgs e)
        {
            validaPunto(txtXPesoN);
            if (txtXPesoN.Text.Length == 0)
                lblPneto.Visible = false;
            else
                lblPneto.Visible = true;
        }

        private void txtXtara_TextChanged(object sender, EventArgs e)
        {
            validaPunto(txtXtara);
            if (txtXtara.Text.Length == 0)
                lblTara.Visible = false;
            else
                lblTara.Visible = true;
        }

        private void txtXDim_TextChanged(object sender, EventArgs e)
        {
            if (txtXDim.Text.Length == 0)
                lblXnDim.Visible = false;
            else
                lblXnDim.Visible = true;
        }

        private void txtXPesoB_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtXPesoN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToDecimal(txtXPesoN.Text) * 1 > 0 && Convert.ToDecimal(txtXtara.Text) * 1 > 0)
                    txtXPesoB.Text = Convert.ToString(Convert.ToDecimal(txtXPesoN.Text) - Convert.ToDecimal(txtXtara.Text));
            }
        }

        private void btnXCancel_Click(object sender, EventArgs e)
        {
            //if (!cerrar)
            //{
            //    if (MessageBox.Show("Desea salir sin Guardar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        this.Dispose();
            //    }
            //}
            //else
            //    this.Dispose();
            if(MessageBox.Show("Desea cancelar esta caja?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                List<int> ord = new List<int>();
                
                Cancelado = true;
                ord = conex.ListaOrd(id_pack, id_caja);
                foreach(int x in ord)
                {
                    FRM.DescontarEnGrid(id_pack, x);
                }
                conex.Cancela_Caja(id_pack, id_caja);
                this.Dispose();
            }
        }

        private void txtXPesoN_Leave(object sender, EventArgs e)
        {

        }

        private void cmbXModa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void FRM_DET_CAJAS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrar)
            {
                if (MessageBox.Show("Desea salir sin Guardar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
            }
            else
                e.Cancel = true;
        }

        private void cmbXModa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
