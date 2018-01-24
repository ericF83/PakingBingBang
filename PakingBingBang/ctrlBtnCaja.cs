using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PakingBingBang
{
    public partial class ctrlBtnCaja : UserControl
    {
       public int id_pack;
        public int id_caja;
        public FRMPacking frm;
        FRMprincipal principal = new FRMprincipal();
        public ctrlBtnCaja( FRMPacking Frm)
        {
            this.frm = Frm;
            InitializeComponent();
        }

        private void btnXbtn_Click(object sender, EventArgs e)
        {
            FRM_DET_CAJAS caja = new FRM_DET_CAJAS(id_pack, id_caja, frm);
            caja.Text = "Caja " + Convert.ToString(id_caja);
            caja.ShowDialog();         
            if (caja.Cancelado)
            {
                foreach(Control ctr in frm.pnlBox.Controls)
                {
                    if(ctr.GetType() == typeof(ctrlBtnCaja))
                        frm.pnlBox.Controls.Remove(ctr);                    
                }
                frm.GeneraBrtn();
                
            }
        }
    }
}
