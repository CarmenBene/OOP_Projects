using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Angajat
{
    class Comparer: IComparer<Angajat>
    {
        public int Compare(Angajat a, Angajat b)
        {
            return a.nume.CompareTo(b.nume);
        }
    }
}
