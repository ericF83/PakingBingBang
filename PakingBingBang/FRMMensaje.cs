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
    public partial class FRMMensaje : Form
    {
        public FRMMensaje()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FRMMensaje_Load(object sender, EventArgs e)
        {
            btnaceptar.TabStop = false;
        }
    }
}
