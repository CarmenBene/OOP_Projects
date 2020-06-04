using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IForma2D_Proj
{
    class Cerc : IForma2d
    {
        public string Denumire => "Cerc";

        public double radius;
        static double pi = Math.PI;
        public Cerc(double radius)
        {
            this.radius = radius;
        }
        public double Arie()
        {
            return pi * Math.Pow(radius, 2);
        }

        public double LungimeaFrontierei()
        {
            return (2 * pi) * radius;
        }

    }
}
