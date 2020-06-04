using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfata_IForma2D
{
    public class Patrat : IForma2D
    {
        public string denumire = "Patrat";

        public static double Arie(double l)
        {
            return l * l;
        }

        public static int LungimeaFrontierei(int l)
        {
            return 4 * l;
        }
    }
}
