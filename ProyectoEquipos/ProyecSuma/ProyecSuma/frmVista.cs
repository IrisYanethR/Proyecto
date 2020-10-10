using ProyecSuma.Dominio;
using ProyecSuma.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyecSuma.GUI
{
    public partial class frmVista : Form
    {
        public frmVista()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Suma sum = new Suma();
            ClsSuma cls = new ClsSuma();

            sum.Num1 = Convert.ToInt32(txtDato1.Text);
            sum.Num2 = Convert.ToInt32(txtDato2.Text);

            MessageBox.Show("El resultado de la suma de " + sum.Num1 + " + " + sum.Num2 + " es : " + cls.sumar(sum));
        }     
    }
}
