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

        static void DeclansareEveniment()
        { 

        }

    }
}
