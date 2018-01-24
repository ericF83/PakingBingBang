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
    public partial class ctrlGridDetalleTop : UserControl
    {
        public ctrlGridDetalleTop()
        {
            InitializeComponent();
        }

        private void ctrlGridDetalleTop_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvXT2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dgvXT2.Rows)
            {

                total = total + Convert.ToInt32(row.Cells["CANT"].Value);
                txtTot.Text = Convert.ToString(total);
               
            }
        }
    }
}
