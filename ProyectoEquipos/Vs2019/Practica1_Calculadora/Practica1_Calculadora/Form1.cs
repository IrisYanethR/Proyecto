using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        datosCalc dato = new datosCalc();

        private void btn0_Click(object sender, EventArgs e)
        {
            dato.agregarNum(0);
            txtDatos.Text = dato.Digito;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dato.agregarNum(1);
            txtDatos.Text = dato.Digito;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            dato.agregarNum(2);
            txtDatos.Text = dato.Digito;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            dato.agregarNum(3);
            txtDatos.Text = dato.Digito;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            dato.agregarNum(4);
            txtDatos.Text = dato.Digito;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            dato.agregarNum(5);
            txtDatos.Text = dato.Digito;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            dato.agregarNum(6);
            txtDatos.Text = dato.Digito;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            dato.agregarNum(7);
            txtDatos.Text = dato.Digito;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            dato.agregarNum(8);
            txtDatos.Text = dato.Digito;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            dato.agregarNum(9);
            txtDatos.Text = dato.Digito;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            dato.sumaNum(txtDatos.Text);
            txtDatos.Text = "";
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            dato.restaNum(txtDatos.Text);
            txtDatos.Text = "";
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            dato.multiplicacionNum(txtDatos.Text);
            txtDatos.Text = "";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            dato.divisionNum(txtDatos.Text);
            txtDatos.Text = "";
        }

        private void btnr_Click(object sender, EventArgs e)
        {
            txtDatos.Text = "" + dato.Calculo(txtDatos.Text);
        }

        private void btnCLS_Click(object sender, EventArgs e)
        {
            txtDatos.Text = " ";
            dato.Digito = " ";
            dato.Resultado = 0;
        }
    }
}
