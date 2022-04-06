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
    
    public partial class FRM_agregarArticulos : Form
    {
        int id_packing;
        int id_orden;
        FRMPacking fP = new FRMPacking(false);
        Conexion conex = new Conexion();
        int ContArt = 0;
        bool esF2 = false;
        int nCaja = 0;
        private string TipoMov = "";
        public FRM_agregarArticulos( int idP, FRMPacking f, string tipoMov)
        {
            InitializeComponent();
            this.id_packing = idP;
            this.fP = f;
            this.TipoMov = tipoMov;
        }

        public void vaciarInfoOrden( int id_vt)
        {
            this.id_orden = conex.GET_MOVID(id_vt, TipoMov);
            conex.InfoArticulosLineal(this, id_vt,id_orden,id_packing, TipoMov);
            lblXorden.Text = "Orden " + Convert.ToString(this.id_orden);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtXNum.Text != "")
                    buscarYeliminar(txtXCodigo.Text);
                else
                    buscarYeliminarF1(txtXCodigo.Text, Convert.ToInt32(txtXNum.Text));
                txtXCodigo.Text = String.Empty;
            }
                
        }

        private void buscarYeliminar(string codigo)
        {
            int scan = 1;
            bool existe = false;
            dgvArticulos.Columns["Quitar"].Visible = false;
            int TotalCant = 0, TotalEnC = 0;
            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {                
                if (conex.verificarCB(codigo, row.Cells["Articulo"].Value.ToString(), row.Cells["SUBCUENTA"].Value.ToString()))
                {
                    existe = true;
                    if (Convert.ToInt32(row.Cells["Cantidad"].Value) == Convert.ToInt32(row.Cells["EnCaja"].Value))
                    {
                        //MessageBox.Show("Cantidad total en caja","",MessageBoxButtons.OK, MessageBoxIcon.Warning,MessageBoxDefaultButton.);
                        FRMMensaje msj = new FRMMensaje();
                        msj.lblMensaje.Text = "Cantidad total en caja";
                        msj.ShowDialog();
                    }
                    else
                    {
                        row.Cells["EnCaja"].Value = Convert.ToInt32(row.Cells["EnCaja"].Value) + scan;
                        row.Cells["EnCaja"].Style.ForeColor = System.Drawing.Color.Red;
                        row.Selected = true;
                        Font font = new Font("Arial", 12.0f,FontStyle.Bold);
                        row.Cells["EnCaja"].Style.Font = font;
                        conex.Detalle_Caja(nCaja, id_packing, Convert.ToInt32(row.Cells["MovID"].Value), row.Cells["Articulo"].Value.ToString(), row.Cells["SUBCUENTA"].Value.ToString(), Convert.ToInt32(row.Cells["Cantidad"].Value), 1, codigo);
                        lblNUmero.Text = Convert.ToString(ContArt = ContArt + 1);
                        btnXCancel.Enabled = true;                
                    }
                    foreach (DataGridViewRow row1 in dgvArticulos.Rows)
                    {
                        TotalCant = TotalCant + Convert.ToInt32(row1.Cells["Cantidad"].Value);
                        TotalEnC = TotalEnC + Convert.ToInt32(row1.Cells["EnCaja"].Value);
                    }
                    if (TotalCant == TotalEnC)
                    {
                        DialogResult d = MessageBox.Show("Orden empaquetada, Desea cerrar la caja ?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (d == DialogResult.No)
                            this.Dispose();
                        else
                        {
                            conex.CerrarCAJA(id_packing, nCaja);
                            this.Dispose();
                        }
                    }
                }
                
            }
            if (!existe)
            {
                //MessageBox.Show("Este Articulo no Pertenese a la Orden");
                FRMMensaje msj = new FRMMensaje();
                msj.lblMensaje.Text = "Este Articulo no Pertenese a la Orden";
                msj.ShowDialog();
            }
        }

        private void buscarYeliminarF1(string codigo, int cantidad)
        {
            int scan = cantidad;
            bool existe = false;
            dgvArticulos.Columns["Quitar"].Visible = false;
            int TotalCant = 0, TotalEnC = 0;
            if (cantidad >= 0)
            {
                foreach (DataGridViewRow row in dgvArticulos.Rows)
                {
                    if (conex.verificarCB(codigo, row.Cells["Articulo"].Value.ToString(), row.Cells["SUBCUENTA"].Value.ToString()))
                    {
                        existe = true;
                        if (Convert.ToInt32(row.Cells["Cantidad"].Value) == Convert.ToInt32(row.Cells["EnCaja"].Value))
                        {
                            //MessageBox.Show("Cantidad total en caja");
                            FRMMensaje msj = new FRMMensaje();
                            msj.lblMensaje.Text = "Cantidad total en caja";
                            msj.ShowDialog();
                        }
                        else
                        {
                            if ((Convert.ToInt32(row.Cells["EnCaja"].Value) + scan) > Convert.ToInt32(row.Cells["Cantidad"].Value))
                            {
                                MessageBox.Show("el numero introducido excede la cantidad de articulos ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtXNum.Text = String.Empty;
                                return;
                            }
                            else
                            {
                                row.Cells["EnCaja"].Value = Convert.ToInt32(row.Cells["EnCaja"].Value) + scan;
                                row.Cells["EnCaja"].Style.ForeColor = System.Drawing.Color.Red;
                                row.Selected = true;
                                dgvArticulos.FirstDisplayedScrollingRowIndex = row.Index;
                                Font font = new Font("Arial", 12.0f, FontStyle.Bold);
                                row.Cells["EnCaja"].Style.Font = font;
                                conex.Detalle_Caja(nCaja, id_packing, Convert.ToInt32(row.Cells["MovID"].Value), row.Cells["Articulo"].Value.ToString(), row.Cells["SUBCUENTA"].Value.ToString(), Convert.ToInt32(row.Cells["Cantidad"].Value), scan, codigo);
                                lblNUmero.Text = Convert.ToString(ContArt = ContArt + scan);
                                btnXCancel.Enabled = true; 
                                txtXNum.Text = String.Empty;
                                txtXNum.Visible = false;

                                foreach(DataGridViewRow row1 in dgvArticulos.Rows)
                                {
                                    TotalCant = TotalCant + Convert.ToInt32(row1.Cells["Cantidad"].Value);
                                    TotalEnC = TotalEnC + Convert.ToInt32(row1.Cells["EnCaja"].Value);
                                }                                  
                                if (TotalCant == TotalEnC)
                                {
                                  DialogResult d =  MessageBox.Show("Orden empaquetada, Desea cerrar la caja ?","aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                                    if(d == DialogResult.No)
                                        this.Dispose();
                                    else
                                    {
                                        conex.CerrarCAJA(id_packing, nCaja);
                                        this.Dispose();
                                    }
                                        
                                }
                            }
                                                                        
                        }
                    }

                    
                }
                if (!existe)
                {
                    MessageBox.Show("Este Articulo no Pertenese a la Orden");
                }
            }
            else
            {
                MessageBox.Show("El número ingresado es negativo");
            }

            
        }

        private void dgvArticulos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvArticulos.Rows.Count % 2 == 0)
                dgvArticulos.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightSlateGray;
            else
                dgvArticulos.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;

            if(Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].Value) > 0)
            {
                dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].Style.ForeColor = System.Drawing.Color.Red;
                Font font = new Font("Arial", 10.0f, FontStyle.Bold);
                dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].Style.Font = font;
            }

            if (!conex.existe_cb(dgvArticulos.Rows[e.RowIndex].Cells["Articulo"].Value.ToString(), Convert.ToString(dgvArticulos.Rows[e.RowIndex].Cells["SUBCUENTA"].Value)))
            {
                dgvArticulos.ReadOnly = false;
                DataGridViewTextBoxCell cell1 = dgvArticulos.Rows[e.RowIndex].Cells["SUBCUENTA"] as DataGridViewTextBoxCell;
                cell1.ReadOnly = true;
                DataGridViewTextBoxCell cell2 = dgvArticulos.Rows[e.RowIndex].Cells["Articulo"] as DataGridViewTextBoxCell;
                cell2.ReadOnly = true;
                DataGridViewTextBoxCell cell3 = dgvArticulos.Rows[e.RowIndex].Cells["Estilo"] as DataGridViewTextBoxCell;
                cell3.ReadOnly = true;
                DataGridViewTextBoxCell cell4 = dgvArticulos.Rows[e.RowIndex].Cells["Color"] as DataGridViewTextBoxCell;
                cell4.ReadOnly = true;
                DataGridViewTextBoxCell cell5 = dgvArticulos.Rows[e.RowIndex].Cells["Cantidad"] as DataGridViewTextBoxCell;
                cell5.ReadOnly = true;
                DataGridViewTextBoxCell cell6 = dgvArticulos.Rows[e.RowIndex].Cells["Talla"] as DataGridViewTextBoxCell;
                cell6.ReadOnly = true;
                //dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].ReadOnly = false;

            }

        }

        private void FRM_agregarArticulos_Load(object sender, EventArgs e)
        {
            txtXCodigo.Focus();
        }

        private void btnXAdd_Click(object sender, EventArgs e)
        {
            if (txtXNum.Text == "")
                buscarYeliminar(txtXCodigo.Text);
            else
                buscarYeliminarF1(txtXCodigo.Text, Convert.ToInt32(txtXNum.Text));
            txtXCodigo.Text = String.Empty;
            txtXCodigo.Focus();
        }

        private void swbtnAbrir_Click(object sender, EventArgs e)
        {
            
        }

        private void swbtnAbrir_ValueChanged(object sender, EventArgs e)
        {

            //else
            //{
            if (swbtnAbrir.Value == true)
            {
                txtXCodigo.Enabled = true;
                btnXAdd.Enabled = true;
                txtXCodigo.Focus();
                btnXCancel.Enabled = true;
                buttonX1.Enabled = false;
            }
            else
            {

                txtXCodigo.Focus();
                DialogResult dr;
                DialogResult pre = DialogResult.Yes;
                dr = MessageBox.Show("Esta seguro de cerrar caja?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (!conex.existe_precinto(id_packing, nCaja))
                {
                    pre = MessageBox.Show("No sea agregado ningun pre-precinto. Desea Continuar?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                }

                if( pre == DialogResult.Yes)
                {
                    if (String.IsNullOrWhiteSpace(cmbXModa.Text) && swbtnAbrir.Value == false)
                    {
                        MessageBox.Show("el campo moda caja esta vacio");
                        swbtnAbrir.Value = true;
                        return;
                    }
                    if (dr == DialogResult.Yes && !String.IsNullOrWhiteSpace(cmbXModa.Text))
                    {
                        pnlBox.Enabled = false;
                        if (Convert.ToInt32(lblNUmero.Text) > 0)
                            conex.CerrarCAJA(id_packing, nCaja);
                        btnXAdd.Enabled = false;
                        btnXCancel.Enabled = false;
                        txtXCodigo.Text = "";
                        buttonX1.Enabled = true;
                        txtXCodigo.Enabled = false;
                        pnlXModa.Enabled = false;
                        btnXPend.Enabled = false;
                    }
                    if (dr == DialogResult.No)
                    {
                        swbtnAbrir.Value = true;
                    }
                }
                else
                {
                    swbtnAbrir.Value = true;
                }            
               
            }
                    
         }
            
        

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void btnItemXEliminar_Click(object sender, EventArgs e)
        {
            //for (int x = 0; x < dgvArticulos.Columns.Count; x++)
            //{
            //    if (dgvArticulos.Columns[x].Name == "Quitar")
            //        dgvArticulos.Columns[x].Visible = true;
            //}
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            int TotalCant = 0, TotalEnC = 0;
            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {
                TotalCant = TotalCant + Convert.ToInt32(row.Cells["Cantidad"].Value);
                TotalEnC = TotalEnC + Convert.ToInt32(row.Cells["EnCaja"].Value);
            }
            if(!(TotalCant == TotalEnC))
            {
                if(conex.verificaCajaP(id_packing) == 0)
                {                    
                    ContArt = 0;
                    lblXnCaja.Text = Convert.ToString(conex.GeneraIDCAJA(id_packing));
                    lblNUmero.Text = "0";
                }
                else
                {
                  lblXnCaja.Text = Convert.ToString(conex.verificaCajaP(id_packing));
                  ContArt = conex.Art_pendientes(id_packing, Convert.ToInt32(lblXnCaja.Text));
                  lblNUmero.Text = ContArt.ToString();
                }
                pnlBox.Enabled = true;
                
                conex.Modas(this);
                pnlXModa.Enabled = true;
                pnlBox.Enabled = true;
                swbtnAbrir.Value = true;
                btnXAdd.Enabled = true;
                txtXCodigo.Enabled = true;
                btnXCancel.Enabled = true;
                pnlXModa.Enabled = true;
                cmbXModa.SelectedText = String.Empty;
                txtXCodigo.Enabled = true;
                txtXNum.Enabled = true;
                btnXPend.Enabled = true;

            }
            else
            {
                MessageBox.Show("La orden ya esta empaquetada");
                buttonX1.Enabled = false;
            }
            

        }

        private void FRM_agregarArticulos_FormClosing(object sender, FormClosingEventArgs e)
        {
            int TotalCant = 0, TotalEnC = 0;
            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {
                TotalCant = TotalCant + Convert.ToInt32(row.Cells["Cantidad"].Value);
                TotalEnC = TotalEnC + Convert.ToInt32(row.Cells["EnCaja"].Value);
            }
             
            if(TotalEnC > 0 && swbtnAbrir.Value == true)
            {
                DialogResult d = MessageBox.Show("si cierra, se quitaran los articulos empaquetados de esta caja." + Environment.NewLine + "desea proceder?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult.Yes == d)
                {
                    conex.Cancela(this, id_packing, nCaja, id_orden);
                    conex.BorrarCAJA(id_packing, nCaja);
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            
            //if(conex.ExisteArt(id_packing, nCaja, id_orden) && TotalCant != TotalEnC)
            //{
            //    conex.Cancela(this, id_packing, nCaja, id_orden);
            //    conex.BorrarCAJA(id_packing, nCaja);
            //    e.Cancel = true;
            //}

        }

        private void btnXCancel_Click(object sender, EventArgs e)
        {
            //if (lblNUmero.Text == "0")
            //{
                DialogResult d = MessageBox.Show("si cancela la caja actual," + Environment.NewLine + " se quitaran los articulos empaquetados de esta caja, desea proceder?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult.Yes == d)
                {
                    conex.Cancela(this, id_packing, nCaja, id_orden);
                    conex.BorrarCAJA(id_packing, nCaja);
                 //if (Convert.ToInt32(lblXnCaja.Text) > 0)
                 //   lblXnCaja.Text = Convert.ToString(Convert.ToInt32(lblXnCaja.Text) - 1);
                //if (lblXnCaja.Text == "0")
                //{
                    pnlBox.Enabled = false;
                    txtXCodigo.Enabled = false;
                    btnXAdd.Enabled = false;
                    lblNUmero.Text = "0";
                    lblXnCaja.Text = "0";
                    buttonX1.Enabled = true;
                    btnXCancel.Enabled = false;
                //}
                    
                //}
                //else
                //{
                //    return;
                //}
               }

            
        }

        private void txtXNum_KeyDown(object sender, KeyEventArgs e)
        {
            int x = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrWhiteSpace(txtXNum.Text))
                    txtXNum.Text = "0";
                else
                    x = Convert.ToInt32(txtXNum.Text);
                buscarYeliminarF1(txtXCodigo.Text,x);
                txtXCodigo.Text = String.Empty;
                txtXCodigo.Focus();
            }
        }

        private void txtXCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtXNum.Text == "")
                    buscarYeliminar(txtXCodigo.Text);
                else
                    buscarYeliminarF1(txtXCodigo.Text, Convert.ToInt32(txtXNum.Text));
                txtXCodigo.Text = String.Empty;
                txtXNum.Visible = false;
            }

            if (e.KeyCode == Keys.F2)
            {
                txtXNum.Visible = true;
                txtXNum.Focus();

            }
        }

        private void txtXNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtXCodigo.Focus();
        }

        private void pnlBox_Click(object sender, EventArgs e)
        {
            txtXCodigo.Focus();
        }

        private void FRM_agregarArticulos_Click(object sender, EventArgs e)
        {
            txtXCodigo.Focus();
        }

        private void lblXnCaja_TextChanged(object sender, EventArgs e)
        {
            nCaja = Convert.ToInt32(lblXnCaja.Text);
        }

        private void cmbXModa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(cmbXModa.ValueMember != "")
            //conex.UpdateMODA(id_packing, nCaja, Convert.ToInt32(cmbXModa.SelectedValue.ToString()));
        }

        private void cmbXModa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conex.UpdateMODA(id_packing, nCaja, Convert.ToInt32(cmbXModa.SelectedValue.ToString()));
        }

        private void btnXCinto_Click(object sender, EventArgs e)
        {

        }

        private void txtBtnXCinto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrWhiteSpace(txtBtnXCinto.Text))
                    conex.Inserta_precinto(id_packing, nCaja, txtBtnXCinto.Text);
                else
                    MessageBox.Show("Debe capturar folio de pre-cinto.");
            }
            
        }

        private void txtBtnXCinto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBtnXCinto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void btnXPend_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea Dejar pendiente esta caja ?","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conex.CajaPendiente(id_packing, Convert.ToInt32(lblXnCaja.Text));
                this.Dispose();
            }
        }

        private void dgvArticulos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvArticulos.Columns[e.ColumnIndex].Name == "EnCaja")
            //{
            //    MessageBox.Show("ok");
            //}
        }

        private void dgvArticulos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int TotalCant = 0, TotalEnC = 0;
            if (dgvArticulos.Columns[e.ColumnIndex].Name == "EnCaja")
            {
                //if (Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["Cantidad"].Value) == Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].Value))
                //{
                //    //MessageBox.Show("Cantidad total en caja");
                //    FRMMensaje msj = new FRMMensaje();
                //    msj.lblMensaje.Text = "Cantidad total en caja";
                //    msj.ShowDialog();
                //}
                //else
                //{
                    if ((Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].Value)) > Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["Cantidad"].Value))
                    {
                        MessageBox.Show("el numero introducido excede la cantidad de articulos ", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].Value = "0";
                        txtXNum.Text = String.Empty;
                        return;
                    }
                    else
                    {
                        dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].Value = Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].Value);
                        dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].Style.ForeColor = System.Drawing.Color.Red;
                        dgvArticulos.Rows[e.RowIndex].Selected = true;
                        dgvArticulos.FirstDisplayedScrollingRowIndex = dgvArticulos.Rows[e.RowIndex].Index;
                        Font font = new Font("Arial", 12.0f, FontStyle.Bold);
                        dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].Style.Font = font;
                        conex.Detalle_Caja(nCaja, id_packing, Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["MovID"].Value), dgvArticulos.Rows[e.RowIndex].Cells["Articulo"].Value.ToString(), dgvArticulos.Rows[e.RowIndex].Cells["SUBCUENTA"].Value.ToString(), Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["Cantidad"].Value), Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].Value), "0");
                        lblNUmero.Text = Convert.ToString(ContArt = ContArt + Convert.ToInt32(dgvArticulos.Rows[e.RowIndex].Cells["EnCaja"].Value));
                        btnXCancel.Enabled = true;
                        txtXNum.Text = String.Empty;
                        txtXNum.Visible = false;

                        foreach (DataGridViewRow row1 in dgvArticulos.Rows)
                        {
                            TotalCant = TotalCant + Convert.ToInt32(row1.Cells["Cantidad"].Value);
                            TotalEnC = TotalEnC + Convert.ToInt32(row1.Cells["EnCaja"].Value);
                        }
                        if (TotalCant == TotalEnC)
                        {
                            DialogResult d = MessageBox.Show("Orden empaquetada,", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            dgvArticulos.Columns[e.ColumnIndex].ReadOnly = true;                            
                        //if (d == DialogResult.No)
                        //        this.Dispose();
                        //    else
                        //    {
                        //        conex.CerrarCAJA(id_packing, nCaja);
                        //        this.Dispose();
                        //    }

                        }
                    }
                //}
            }
        }
    }
}
