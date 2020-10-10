using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoEquipos.Negocio
{
    class clsNotas
    {
        public Double funcPromedio1(String num1, String num2)
        {
            Double lab1 = Convert.ToDouble(num1);
            Double exa1 = Convert.ToDouble(num2);

            Double PromedioLab1 = lab1 * 0.40;
            Double PromedioExa1 = exa1 * 0.60;

            Double Promedio = PromedioLab1 + PromedioExa1;
            Promedio /= 3;

            return Promedio;
        }

        public Double funcPromedio2(String num1, String num2)
        {
            Double lab2 = Convert.ToDouble(num1);
            Double exa2 = Convert.ToDouble(num2);

            Double PromedioLab2 = lab2 * 0.40;
            Double PromedioExa2 = exa2 * 0.60;

            Double Promedio = PromedioLab2 + PromedioExa2;
            Promedio /= 3;

            return Promedio;
        }

        public Double funcPromedio3(String num1, String num2)
        {
            Double lab3 = Convert.ToDouble(num1);
            Double exa3 = Convert.ToDouble(num2);

            Double PromedioLab3 = lab3 * 0.40;
            Double PromedioExa3 = exa3 * 0.60;

            Double Promedio = PromedioLab3 + PromedioExa3;
            Promedio /= 3;

            return Promedio;
        }

        public Double funcProFinal(Double pro1, Double pro2, Double pro3)
        {
            Double total = pro1 + pro2 + pro3;
            return total;
        }
    }
}

