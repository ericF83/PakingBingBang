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
    public partial class ctrlGridDetalleBD : UserControl
    {
        public ctrlGridDetalleBD()
        {
            InitializeComponent();
        }

        private void ctrlGridDetalleBD_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvXT1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dgvXT1.Rows)
            {

                total = total + Convert.ToInt32(row.Cells["CANT"].Value);
                txtTot.Text = Convert.ToString(total);

            }
        }
    }
}
