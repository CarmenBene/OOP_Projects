using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Angajat
{
    class Angajat
    {
        public string nume;
        public int vechime;

        public Angajat(string data)
        {
            string[] local = data.Split(' ');
            nume = local[0] + " " + local[1];
            vechime = int.Parse(local[2]);
        }
        public Angajat(string nume, int vechime)
        {
            this.nume = nume;
            this.vechime = vechime;
        }
        public override string ToString()
        {
            return nume + " " + vechime;
        }
    }
}
