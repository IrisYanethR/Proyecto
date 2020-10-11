using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEquipos
{
    public partial class frmSuma : Form
    {
        public frmSuma()
        {
            InitializeComponent();
        }

        private void btnAtras3_Click(object sender, EventArgs e)
        {
            Menu form4 = new Menu();
            this.Visible = false;
            form4.Visible = true;
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {

        }
    }
}
