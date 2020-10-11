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
            fmrInicioSesion form2 = new fmrInicioSesion();
            this.Visible = false;
            form2.Visible = true;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            frmSuma form5 = new frmSuma();
            this.Visible = false;
            form5.Visible = true;
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            frmPromedio form3 = new frmPromedio();
            this.Visible = false;
            form3.Visible = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
