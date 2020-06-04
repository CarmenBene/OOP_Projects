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
            Console.WriteLine("Aria patratului este: "+ Patrat.Arie(4));
            Console.WriteLine("Perimetrul patratului este: "+ Patrat.LungimeaFrontierei(4));
            Console.WriteLine("Aria cercului este: "+ Cerc.Arie(5));
            Console.WriteLine("Circumferinta cercului este: "+ Cerc.LungimeaFrontierei(5));
        }
    }
}
