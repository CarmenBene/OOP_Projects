using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfata_IForma2D
{
    public class Cerc : IForma2D
    {
        public string denumire = "Cerc";
        static double pi = Math.PI;

        public static double Arie(double radius)
        {
            return pi * Math.Pow(radius, 2);
        }

        public static double LungimeaFrontierei(double radius)
        {
            return (2 * pi) * radius;
        }
    }
}
