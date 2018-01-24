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
    public partial class FRMBuscaOrd : Form
    {
       public bool ocultar = false;
       FRMPacking F = new FRMPacking(false);
        Conexion conex = new Conexion();
        public int ID_packing = 0;
        public FRMprincipal prins = new FRMprincipal();
        public bool esPendiente = false;
        FRMPacking Frmpack;
        public FRMBuscaOrd(FRMprincipal Prins)
        {
            InitializeComponent();
            this.prins = Prins;

        }

        public FRMBuscaOrd( bool esPend, FRMPacking frm, int idpack)
        {
            InitializeComponent();
            this.esPendiente = esPend;
            this.Frmpack = frm;
            this.ID_packing = idpack;

        }

        private void btnXAdd_Click(object sender, EventArgs e)
        {
            //Preview pre = new Preview();
            //pre.datosgrid(this);
            Conexion con = new Conexion();
            con.Ordenes(this, txtXOrd.Text);
            txtXOrd.Text = "";

        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            if (dgvXOrdenes.Rows.Count > 0)
            {
                Dictionary<int, string> ordenes = new Dictionary<int, string>();
                bool Open = false;
                if (dgvXOrdenes.Rows.Count > 0)
                    foreach (DataGridViewRow row in dgvXOrdenes.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Checking"].Value))
                            ordenes.Add(Convert.ToInt32( row.Cells["ID"].Value), row.Cells["OrdSurt"].Value.ToString());
                    }



                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(FRMPacking)) // busca si esta abierto el FRMPacking
                    {
                        Open = true;
                    }
                }

                if (!Open) // si falso: no esta abierto, inicializa el tab y muestra el form
                {
                    ID_packing = conex.GeneraIDpacking();
                    F = new FRMPacking(false);
                    F.AgregarTap(ordenes, ID_packing);
                    F.Show();
                    //F.BringToFront();
                    this.Visible = false;

                    //FRMPacking F = new FRMPacking(true);
                    //F.AgregarTap(ordenes, ID_packing);
                    //F.TopLevel = false;
                    //F.StartPosition = FormStartPosition.CenterScreen;
                    //F.Parent = prins.PnlPrincipal;
                    //F.Show();
                    //F.BringToFront();
                    //this.Visible = false;
                }
                else
                {
                    if (!esPendiente)
                    {
                        F.AgregarTap(ordenes, ID_packing); // si esta abierto solo inserta la odern para generar un nuevo tab si esque no existe
                                                           //F.TopLevel = false;
                                                           //F.Parent = prins.PnlPrincipal;
                        F.Refresh();
                        F.BringToFront();
                    }
                    else
                        Frmpack.AgregarTap(ordenes, ID_packing);
                    
                    this.Visible = false;                   
                }

                dgvXOrdenes.Rows.Clear();
            }          


        }

        private void txtXOrd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtXOrd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnXAdd.PerformClick();                
            }
                
            if (e.KeyCode == Keys.F5 && dgvXOrdenes.Rows.Count > 0)
            {
                btnGeneraP.PerformClick();
                this.Visible = false;
            }
        }

        private void FRMBuscaOrd_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(FRMPacking)) // busca si esta abierto el FRMPacking
                {
                    dr = MessageBox.Show("Hay una captura pendiente, desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
            
        }

        private void FRMBuscaOrd_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void FRMBuscaOrd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5 && dgvXOrdenes.Rows.Count > 0)
            {
                btnGeneraP.PerformClick();
            }
        }
    }
}
