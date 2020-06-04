using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IForma2D_Proj
{
    class Patrat : IForma2d
    {
        public string Denumire => "Patrat";

        public double l;
        public Patrat(double l)
        {
            this.l = l;
        }

        public double Arie()
        {
            return Math.Pow(l, 2);
        }

        public double LungimeaFrontierei()
        {
            return 4 * l;
        }
    }
}
