using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEquipos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Formulario2 form2 = new Formulario2();
            this.Visible = false;
            form2.Visible = true;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Formulario5 form5 = new Formulario5();
            this.Visible = false;
            form5.Visible = true;
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            Formulario3 form3 = new Formulario3();
            this.Visible = false;
            form3.Visible = true;
        }
    }
}
