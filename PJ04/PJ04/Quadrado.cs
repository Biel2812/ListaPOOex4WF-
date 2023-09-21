using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ04
{
    internal class Quadrado
    {
        //atributos
        private double b;
        private double h;
        private double a;

        //metodos 
        public void setBase(double p)
        {
            b = p;
        }

        public void setAltura(double p)
        {
            h = p;
        }

        public double getBase()
        {
            return b;
        }

        public double getAltura()
        {
            return h;
        }

        public double getArea()
        {
            return a;
        }

        public void calcularArea()
        {
            a = (b * h) / 2;
        }
    }
}

