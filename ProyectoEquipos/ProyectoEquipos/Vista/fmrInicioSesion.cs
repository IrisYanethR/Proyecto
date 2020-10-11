using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEquipos
{
    public partial class fmrInicioSesion : Form
    {
        public fmrInicioSesion()
        {
            InitializeComponent();
        }

        private void btnAtras1_Click(object sender, EventArgs e)
        {
            frmBienvenida form = new frmBienvenida();
            this.Visible = false;
            form.Visible = true;
        }

        private void btnIniciarSecion_Click(object sender, EventArgs e)
        {
            Menu form6 = new Menu();
            this.Visible = false;
            form6.Visible = true;
        }
    }
}
