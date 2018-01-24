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
    public partial class ctrlGridDetalle : UserControl
    {
        public ctrlGridDetalle()
        {
            InitializeComponent();
        }

        private void ctrlGridDetalle_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvXdetalle_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dgvXdetalle.Rows)
            {

                total = total + Convert.ToInt32(row.Cells["CANT"].Value);
                txtTot.Text = Convert.ToString(total);

            }
        }

       
    }
}
