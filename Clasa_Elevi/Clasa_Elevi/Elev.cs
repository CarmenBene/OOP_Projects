using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Elevi
{
    public class Elev
    {
        public string name;
        string surname;
        public float media;

        public Elev()
        {

        }

        public override string ToString()
        {
            return name + " " + surname + " " + media.ToString("0.00");
        }
    }
}
