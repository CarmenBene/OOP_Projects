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

        public Elev(string data)
        {
            string[] local = data.Split(' ');
            this.name = local[0];
            this.surname = local[1];

            int NotesNr = int.Parse(local[2]);
            for (int i = 0 ; i < NotesNr ; i ++ )
                media += float.Parse(local[i + 3]);
            media = media / (float)NotesNr;
        }

        public override string ToString()
        {
            return name + " " + surname + " " + media.ToString("0.00");
        }
    }
}
