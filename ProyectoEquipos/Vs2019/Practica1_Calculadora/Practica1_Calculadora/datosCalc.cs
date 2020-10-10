using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Practica1_Calculadora
{
    class datosCalc
    {
        //Atributos
        private String digito;
        private double resultado;
        private Boolean suma;
        private Boolean resta;
        private Boolean multiplicacion;
        private Boolean division;

        //Metodo para dar un valor inicial a los atributos
        //Bolean inicien con false para luego cambiar a true

        public datosCalc() {
            digito = "";
            resultado = 0;
            suma = false;
            resta = false;
            multiplicacion = false;
            division = false;
        
        
        }
        //get y set
        public string Digito { get => digito; set => digito = value; }
        public double Resultado { get => resultado; set => resultado = value; }
        public bool Suma { get => suma; set => suma = value; }
        public bool Resta { get => resta; set => resta = value; }
        public bool Multiplicacion { get => multiplicacion; set => multiplicacion = value; }
        public bool Division { get => division; set => division = value; }


        public void agregarNum(int num)
        {
            Digito = digito + num;
        }

        public void sumaNum(String num) {
            resultado = Convert.ToDouble(num);
            suma = true;
            Digito = (" "); 
             
        }

        public void restaNum(String num)
        {
            resultado = Convert.ToDouble(num);
            resta = true;
            Digito = (" ");

        }

        public void multiplicacionNum(String num)
        {
            resultado = Convert.ToDouble(num);
            multiplicacion= true;
            Digito = (" ");

        }

        public void divisionNum(String num)
        {
            resultado = Convert.ToDouble(num);
            division = true;
            Digito = (" ");

        }
        public Double Calculo(String num) {
            if (suma == true)
            {
                resultado += Convert.ToDouble(num);
            }
            else if (resta == true)
            {
                resultado -= Convert.ToDouble(num);
            }
            else if (multiplicacion == true)
            {
                resultado *= Convert.ToDouble(num);
            }
            else if (division == true) {
                resultado /= Convert.ToDouble(num);
            }
            suma = false;
            resta = false;
            multiplicacion = false;
            division = false;
            return resultado;
        }
            
    }
}
