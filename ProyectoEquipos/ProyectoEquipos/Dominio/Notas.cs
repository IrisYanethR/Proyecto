using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoEquipos.Dominio
{
    class Notas
    {
        private String lab1;
        private String lab2;
        private String lab3;

        private String exa1;
        private String exa2;
        private String exa3;

        private Double pro1;
        private Double pro2;
        private Double pro3;

        private Double promedioFinal;

        public string Lab1 { get => lab1; set => lab1 = value; }
        public string Lab2 { get => lab2; set => lab2 = value; }
        public string Lab3 { get => lab3; set => lab3 = value; }
        public string Exa1 { get => exa1; set => exa1 = value; }
        public string Exa2 { get => exa2; set => exa2 = value; }
        public string Exa3 { get => exa3; set => exa3 = value; }
        public double Pro1 { get => pro1; set => pro1 = value; }
        public double Pro2 { get => pro2; set => pro2 = value; }
        public double Pro3 { get => pro3; set => pro3 = value; }
        public double PromedioFinal { get => promedioFinal; set => promedioFinal = value; }

    }
}
