using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Angajat
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaAngajati MyAngajati = new ListaAngajati();
            MyAngajati.Load();

            foreach (string s in MyAngajati.View())
            {
                Console.WriteLine(s.ToString());
            }
            Console.WriteLine();
            MyAngajati.Sort();
            foreach (string s in MyAngajati.View())
            {
                Console.WriteLine(s.ToString());
            }

            MyAngajati.Save();
        }
    }
}
