using ProyecSuma.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyecSuma.Negocio
{
    class ClsSuma
    {
        public int sumar(Suma sum)
        {

            return sum.Num1 + sum.Num2;
        }
    }
}
