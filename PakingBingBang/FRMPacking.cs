using DevComponents.DotNetBar;
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
    public partial class FRMPacking : Form
    {
        TabItem newTab = new TabItem();
        Conexion conex = new Conexion();
        TabControlPanel panel = new TabControlPanel();
        public DevComponents.DotNetBar.TabControl tabP = new DevComponents.DotNetBar.TabControl();
        public DevComponents.DotNetBar.Controls.SwitchButton swBtnPack = new DevComponents.DotNetBar.Controls.SwitchButton();
        int ID_packing;
        int Cont_art = 0;
        bool esPendiente = false;
        private string TipoMov = "";
        public FRMPacking(bool esPend)
        {
            InitializeComponent();
            this.esPendiente = esPend;                    
        }

        public FRMPacking(bool esPend, string tipoMov)
        {
            InitializeComponent();
            this.esPendiente = esPend;
            this.TipoMov = tipoMov;
        }
        //public FRMPacking(int id_pack)
        //{
        //    this.ID_packing = id_pack;
        //}

        private void FRMPacking_Load(object sender, EventArgs e)
        {

            //AgregarTap(this.Ordenes);

            //newTab = tabP.CreateTab("New Tab");
            //panel = (TabControlPanel)newTab.AttachedControl;
            //panel.Controls.Add(new ctrlGridDetalle());

            //newTab = tabP.CreateTab("New Tab1");
            //panel = (TabControlPanel)newTab.AttachedControl;
            //panel.Controls.Add(new ctrlGridDetalle());      


        }
         
        public void AgregarTap(Dictionary<int,string> ordenes, int id_p)
        {
            Conexion con = new Conexion();
            ID_packing = id_p;
            lblXnIdp.Text = Convert.ToString(id_p);
            List<string> listCategoria = new List<string>();
            if(tabP.Tabs.Count == 0)
            {                
                tabP.Size = new Size(1145, 400);                
                //tabP.CloseButtonOnTabsVisible = true;
                tabP.TabItemClose += new DevComponents.DotNetBar.TabStrip.UserActionEventHandler(this.tabControl1_TabItemClose);
            }
            int x = 10, y = 25, increm = 280;
                foreach (int key in ordenes.Keys) // recorre la lista
                {
                    bool found = false;
                    foreach (TabItem tab in tabP.Tabs) // recorre el tab para no repetir ordenes
                    {
                        if (ordenes[key] == tab.Text) // busca si ya existe un tab con la orden 
                        {                        
                            found = true; // si existe no la agrega
                            //MessageBox.Show("existe");
                        }
                    }
                    if (!found)
                    {
                        newTab = tabP.CreateTab(ordenes[key]);                        
                        panel = (TabControlPanel)newTab.AttachedControl;
                        panel.AutoScroll = true;
                        listCategoria = con.listaCat(key, TipoMov);
                        foreach(string s in listCategoria)
                        {
                            if (s == "TOPS")
                            {
                                ctrlGridDetalleTop ctT = new ctrlGridDetalleTop();
                                ctT.Name = ordenes[key].ToString() + s;
                                ctT.lblXorden.Text = s;
                                ctT.Location = new Point(x, y);
                                ctT.AutoScroll = true;
                                panel.Controls.Add(ctT);
                                con.dgvT(ctT, key,TipoMov);
                                y = y + increm;
                                Cont_art = Cont_art + Convert.ToInt32(ctT.txtTot.Text);
                                txtXT_art.Text = Convert.ToString(Cont_art );
                                                       
                            }                            
                            else if (s == "BOTTOMS - DAM")
                            {
                                ctrlGridDetalleBD ctBD = new ctrlGridDetalleBD();

                                ctBD.Name = ordenes[key].ToString() + s;
                                ctBD.lblXorden.Text = s;
                                ctBD.Location = new Point(x, y);
                                panel.Controls.Add(ctBD);
                                con.dgvBD(ctBD,key, TipoMov);
                                y = y + increm;
                                Cont_art = Cont_art + Convert.ToInt32(ctBD.txtTot.Text);
                                txtXT_art.Text = Convert.ToString(Cont_art );
                            }                           
                            else if (s == "BOTTOMS - CAB")
                            {
                                ctrlGridDetalleBC ctBC = new ctrlGridDetalleBC();
                                ctBC.Name = ordenes[key].ToString() + s;
                                ctBC.lblXorden.Text = s;
                                ctBC.Location = new Point(x, y);
                                panel.Controls.Add(ctBC);
                                con.dgvBC(ctBC, key, TipoMov);
                                y = y + increm;
                                Cont_art = Cont_art + Convert.ToInt32(ctBC.txtTot.Text);
                                txtXT_art.Text = Convert.ToString(Cont_art );
                            }                            
                            else if (s == "UNITALLA")
                            {
                                ctrlGridDetalle ctU = new ctrlGridDetalle();
                                ctU.Name = ordenes[key].ToString() + s;
                                ctU.lblXorden.Text = s;
                                ctU.Location = new Point(x, y);
                                panel.Controls.Add(ctU);
                                con.dgvUN(ctU, key, TipoMov);
                                y = y + increm;
                                Cont_art = Cont_art + Convert.ToInt32(ctU.txtTot.Text);
                                txtXT_art.Text = Convert.ToString(Cont_art );
                            }

                        else if (s == "OTROS")
                        {
                            ctrlGridDetalleOtros ctO = new ctrlGridDetalleOtros();
                            ctO.Name = ordenes[key].ToString() + s;
                            ctO.lblXorden.Text = s;
                            ctO.Location = new Point(x, y);
                            panel.Controls.Add(ctO);
                            con.dgvOTROS(ctO, key, TipoMov);
                            y = y + increm;
                            Cont_art = Cont_art + Convert.ToInt32(ctO.txtTot.Text);
                            txtXT_art.Text = Convert.ToString(Cont_art);
                        }

                    }
                    //Cont_art = Cont_art + conex.total_orden(key);
                    swBtnPack = new DevComponents.DotNetBar.Controls.SwitchButton();
                    swBtnPack = propiedades(ordenes[key]);
                    panel.Name = Convert.ToString(key);                    
                    panel.Controls.Add(swBtnPack);
                    panel.AutoScroll = true;
                                       
                    this.PnlTabs.Controls.Add(tabP);
                    conex.GeneraDetallePack(id_p, Convert.ToInt32(ordenes[key]));
                    found = false;
                    x = 10; y = 25;
                }
                
                }

            if (esPendiente)
            {
                GeneraBrtn();
                if(ordenes.Count() > 0)
                try
                {
                    DescontarEnGrid(ID_packing, conex.GET_MOVID(Convert.ToInt32(tabP.SelectedPanel.Name),TipoMov));
                }
                catch(Exception ER)
                {
                    MessageBox.Show("Error: Pendiente-DescontarEnGrid. " + ER.Message);
                }
                
            }
            
            //foreach (string ord in ListaOrd)
            //{
            //    newTab = tabP.CreateTab(ord);
            //    panel = (TabControlPanel)newTab.AttachedControl;
            //    panel.Controls.Add(new ctrlGridDetalle());
            //    this.Controls.Add(tabP);              
                
            //}
        }
        private void tabControl1_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            TabItem itemRemove = tabP.SelectedTab;
            
                tabP.Tabs.Remove(itemRemove);
                tabP.Controls.Remove(itemRemove.AttachedControl);
                tabP.RecalcLayout();
           if(tabP.Tabs.Count == 0)
            {
                this.Dispose();
            }
            
        }

        public Object regresaTipoGrid( string categorias)
        {
            var x = new Object();

            x = new ctrlGridDetalle();

            return x;
        }

        private void swBtnPack_ValueChanged(object sender, EventArgs e)
        {
            swBtnPack = (DevComponents.DotNetBar.Controls.SwitchButton)sender;
            string n = "";
            if (swBtnPack.Value == true)
            {
                n = tabP.SelectedPanel.Name;
                //tabP.SelectedTab.AttachedControl.Name = n;
                
                foreach (Control c in tabP.Controls)
                {
                     if (c.Name != n)
                        c.Enabled = false;                                        
                }

                FRM_agregarArticulos AgrArt = new FRM_agregarArticulos(ID_packing, this, TipoMov);
                AgrArt.lblXorden.Text = "ORDEN " + tabP.SelectedPanel.Name;
                AgrArt.vaciarInfoOrden(Convert.ToInt32(tabP.SelectedPanel.Name));
                AgrArt.ShowDialog();
                GeneraBrtn();
                //if (conex.Orden_Completa(ID_packing, Convert.ToInt32(tabP.SelectedPanel.Name)))
                //    swBtnPack.Enabled = false;
                //else
                    swBtnPack.Value = false;
                DescontarEnGrid(ID_packing, conex.GET_MOVID(Convert.ToInt32(tabP.SelectedPanel.Name),TipoMov));
            }
            else
            {
                n = tabP.SelectedPanel.Name;
                //tabP.SelectedTab.AttachedControl.Name = n;

                foreach (Control c in tabP.Controls)
                {
                    if (c.Name != n)
                        c.Enabled = true;
                }
            }
        }

        public void DescontarEnGrid(int idpack,  int idord)
        {
            int ncolor = 0;
            string art = "";
            foreach (Control ctr in tabP.Controls)
            {
                if (ctr.GetType() == typeof(TabControlPanel))
                {
                    TabControlPanel tab = (TabControlPanel)ctr;
                    foreach (Control control in tab.Controls)
                    {
                        if (control.GetType() == typeof(ctrlGridDetalleTop))
                        {
                            ctrlGridDetalleTop ctop = control as ctrlGridDetalleTop;
                            for(int x = 0; x <= ctop.dgvXT2.RowCount - 1; x++)
                            {                               
                              ncolor = Convert.ToInt32(ctop.dgvXT2.Rows[x].Cells["nColor"].Value);
                              art = ctop.dgvXT2.Rows[x].Cells["ART"].Value.ToString();
                              ctop.dgvXT2.Rows[x].Cells["escan"].Value = conex.Actualiza_grid(idpack, conex.GET_MOVID(Convert.ToInt32(tab.Name),TipoMov), art, ncolor);
                              
                            }
                        }

                        if (control.GetType() == typeof(ctrlGridDetalle))
                        {
                            ctrlGridDetalle ctop = control as ctrlGridDetalle;
                            for (int x = 0; x <= ctop.dgvXdetalle.RowCount - 1; x++)
                            {
                                ncolor = Convert.ToInt32(ctop.dgvXdetalle.Rows[x].Cells["nColor"].Value);
                                art = ctop.dgvXdetalle.Rows[x].Cells["ART"].Value.ToString();
                                ctop.dgvXdetalle.Rows[x].Cells["escan"].Value = conex.Actualiza_grid(idpack, conex.GET_MOVID(Convert.ToInt32(tab.Name),TipoMov), art, ncolor);

                            }
                        }

                        if (control.GetType() == typeof(ctrlGridDetalleBC))
                        {
                            ctrlGridDetalleBC ctop = control as ctrlGridDetalleBC;
                            for (int x = 0; x <= ctop.dataGridViewX1.RowCount - 1; x++)
                            {
                                ncolor = Convert.ToInt32(ctop.dataGridViewX1.Rows[x].Cells["nColor"].Value);
                                art = ctop.dataGridViewX1.Rows[x].Cells["ART"].Value.ToString();
                                ctop.dataGridViewX1.Rows[x].Cells["escan"].Value = conex.Actualiza_grid(idpack, conex.GET_MOVID(Convert.ToInt32(tab.Name),TipoMov), art, ncolor);

                            }
                        }

                        if (control.GetType() == typeof(ctrlGridDetalleBD))
                        {
                            ctrlGridDetalleBD ctop = control as ctrlGridDetalleBD;
                            for (int x = 0; x <= ctop.dgvXT1.RowCount - 1; x++)
                            {
                                ncolor = Convert.ToInt32(ctop.dgvXT1.Rows[x].Cells["nColor"].Value);
                                art = ctop.dgvXT1.Rows[x].Cells["ART"].Value.ToString();
                                ctop.dgvXT1.Rows[x].Cells["escan"].Value = conex.Actualiza_grid(idpack, conex.GET_MOVID(Convert.ToInt32(tab.Name),TipoMov), art, ncolor);

                            }
                        }
                    }
                }

            }
        }

        public DevComponents.DotNetBar.Controls.SwitchButton propiedades(string id)
        {
            DevComponents.DotNetBar.Controls.SwitchButton swBtnPack = new DevComponents.DotNetBar.Controls.SwitchButton();
            swBtnPack.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            swBtnPack.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            swBtnPack.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            swBtnPack.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            swBtnPack.BackgroundStyle.Class = "";
            swBtnPack.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            swBtnPack.Location = new System.Drawing.Point(10, 2);
            swBtnPack.Name = "swBtn" + id;
            swBtnPack.OffBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            swBtnPack.OffText = "PACK";
            swBtnPack.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            swBtnPack.OnText = "PACKING";
            swBtnPack.Size = new System.Drawing.Size(120, 22);
            swBtnPack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            swBtnPack.SwitchBackColor = System.Drawing.Color.Silver;
            swBtnPack.ValueChanged += new System.EventHandler(this.swBtnPack_ValueChanged);
            swBtnPack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //swBtnPack.Size = new System.Drawing.Size(120, 22);
            return swBtnPack;
        }

        private void btnXAdd_Click(object sender, EventArgs e)
        {
            if (!esPendiente)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(FRMBuscaOrd)) // busca si esta abierto el FRMPacking
                    {
                        frm.BringToFront();
                        frm.Visible = true;
                    }
                } 
            }
            else
            {
                FRMBuscaOrd frm = new FRMBuscaOrd(esPendiente,this, ID_packing);
                frm.Show();

            }
            
        }

        private void FRMPacking_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            if (!esPendiente)
            {
                if(conex.Verifica_estatus(ID_packing) == "PENDIENTE" || conex.Verifica_estatus(ID_packing) == "SIN_FINALIZAR" || conex.Verifica_estatus(ID_packing) == "INICIADO")
                {
                    if (MessageBox.Show("el estatus del packing actual sigue en " + conex.Verifica_estatus(ID_packing) + Environment.NewLine + "Desea continuar? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (MessageBox.Show("Desea guardar el packing?", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            conex.terminarSF(ID_packing);
                            this.Dispose();
                        }
                        else
                        {
                            conex.cancelar_todo(ID_packing);
                            this.Dispose();
                        }

                    }
                    else
                        e.Cancel = true;

                }                
                
            }
            else
                this.Dispose();
            
                
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Desea cacncelar la captura?", "",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                conex.cancelar_todo(ID_packing);
                this.Dispose();                
            }
        }

        private void btnXCaja_Click(object sender, EventArgs e)
        {

        }

        public void GeneraBrtn()
        {
            int numero_c = conex.N_cajas(ID_packing);
            int y = 12; 
            for(int x = 1; x <= numero_c; x++)
            {
                ctrlBtnCaja c = new ctrlBtnCaja(this);                
                c.id_caja = x;
                c.id_pack = ID_packing;
                c.btnXbtn.Text = "Caja " + Convert.ToString(x);
                c.Location = new System.Drawing.Point(y, 12);
                pnlBox.Controls.Add(c);
                y = y + 180;
            }
            txtXtotalT.Text = Convert.ToString(conex.total_artC(ID_packing));
            
        }

        private void accion_btn(object sender , EventArgs e)
        {
            
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            
            if (conex.ValidaCaja(ID_packing))
            {
                //OBJ_CRY.Refresh();
                //OBJ_CRY.SetParameterValue("@Id_Packing", ID_packing);
                //OBJ_CRY.DataSourceConnections[0].SetConnection(conex.SERV, conex.BASE, conex.USER, conex.PASSWORD);
                //F.crystalReportViewer1.ReportSource = OBJ_CRY;                
                //F.ShowDialog();
                conex.GeneraReporte(ID_packing);
            }
            else
            {
                if (MessageBox.Show("falta capturar datos en algunas de las cajas, Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //OBJ_CRY.Refresh();
                    //OBJ_CRY.SetParameterValue("@Id_Packing", ID_packing);
                    //OBJ_CRY.DataSourceConnections[0].SetConnection(conex.SERV, conex.BASE, conex.USER, conex.PASSWORD);
                    //F.crystalReportViewer1.ReportSource = OBJ_CRY;
                    //F.ShowDialog();
                    conex.GeneraReporte(ID_packing);
                }
                else
                    return;
            }
            
        }

        private void pnlBox_ControlRemoved(object sender, ControlEventArgs e)
        {
            foreach (Control ctr in this.pnlBox.Controls)
            {
                if (ctr.GetType() == typeof(ctrlBtnCaja))
                    this.pnlBox.Controls.Remove(ctr);
            }
        }

        private void btnXTerminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Terminar el Packing?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conex.terminarPack(ID_packing);
                this.Dispose();             
            }
        }
    }
}
