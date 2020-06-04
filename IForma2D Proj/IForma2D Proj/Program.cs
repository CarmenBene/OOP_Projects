using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IForma2D_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Patrat p = new Patrat(4);

        }

        public void GetValues(IForma2d values)
        {
            Console.WriteLine($"Aria {values.Denumire} este: {values.Arie()}");
            Console.WriteLine($"Lungime frontiera {values.Denumire} este: {values.LungimeaFrontierei()}");
        }
    }
}
