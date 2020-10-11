using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEquipos
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {



            fmrInicioSesion form2 = new fmrInicioSesion();
            this.Visible = false;
            form2.Visible = true;
        }

        private void LabBienvenidos_Click(object sender, EventArgs e)
        {

        }
    }
}
