using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfata_IForma2D
{
    class Program
    {
        public interface IForma2D
        {
            double Arie();
            double LungimeaFrontierei();
            string denumire { get; }
        }

        static void Main(string[] args)
        {
            Patrat P = new Patrat(4);
            GetValues(P);
            Cerc C = new Cerc(5);
            GetValues(C);
        }

        public static void GetValues(IForma2D values)
        {
            Console.WriteLine($"Aria {values.denumire} este: {values.Arie()}");
            Console.WriteLine($"Perimetrul {values.denumire} este: {values.LungimeaFrontierei()}");
        }
    }
}
