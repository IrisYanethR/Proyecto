using ProyectoEquipos.Negocio;
using ProyectoEquipos.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoEquipos
{
    public partial class Formulario3 : Form
    {
        public Formulario3()
        {
            InitializeComponent();
        }

        private void Atras2_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            this.Visible = false;
            men.Visible = true;
        }

        private void btnCalcular1_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            clsNotas cls = new clsNotas();

            String num1 = txtLab1.Text;
            String num2 = txtPar1.Text;

            Double r1 = cls.funcPromedio1(num1, num2);
            notas.Pro1 = r1;

            txtPro1.Text = Convert.ToString(r1);
            //--------------------------------------------------
            String num3 = txtLab2.Text;
            String num4 = txtPar2.Text;

            Double r2 = cls.funcPromedio2(num3, num4);
            notas.Pro2 = r2;

            txtPro2.Text = Convert.ToString(r2);
            //--------------------------------------------------
            String num5 = txtLab3.Text;
            String num6 = txtPar3.Text;

            Double r3 = cls.funcPromedio3(num5, num6);
            notas.Pro3 = r3;

            txtPro3.Text = Convert.ToString(r3);
            //--------------------------------------------------

            Double pro1 = notas.Pro1;
            Double pro2 = notas.Pro2;
            Double pro3 = notas.Pro3;

            Double r = cls.funcProFinal(pro1, pro2, pro3);

            txtResultado.Text = Convert.ToString(r);

            if (r >= 6)
            {
                txtResultado.Text = "Aprobado-->" + r;
            }
            else
            {
                txtResultado.Text = "Reprobado-->" + r;
            }
        }
    
    }
}
