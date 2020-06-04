using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Publisher
{
    public delegate void iteratie(int n);
    class Publisher
    {
        public event iteratie eveniment;

        public void DeclansareEveniment()
        {
            for (int i = 0; i < 7; i++)
            {
                if (eveniment != null)
                    eveniment(i);
            }
        }

    }
}
