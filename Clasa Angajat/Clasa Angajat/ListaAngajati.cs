using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Angajat
{
    class ListaAngajati
    {
        Angajat[] a;

        public ListaAngajati()
        {
            a = new Angajat[0];
        }
        public void Add(Angajat add)
        {
            Angajat[] t = new Angajat[a.Length + 1];
            for (int i = 0; i < a.Length; i++)
            {
                t[i] = a[i];
            }
            t[a.Length] = add;
            a = t;
        }
         
        public void Remove(string remove)
        {
            int idx = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].nume == remove)
                {
                    idx = i;
                    break;
                }
            }
            if (idx != -1)
            {
                Angajat[] t = new Angajat[a.Length - 1];
                for (int i = 0; i < idx; i++)
                {
                    t[i] = a[i];
                }
                for (int i = idx + 1; i < a.Length; i++)
                {
                    t[i - 1] = a[i];
                }
                a = t;
            }
        }
    }
}
