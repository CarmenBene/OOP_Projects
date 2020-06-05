using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher P = new Publisher();
            SubscriberA A = new SubscriberA();
            SubscriberB B = new SubscriberB();
            
            P.eveniment += new iteratie(A.HandlerA);
            P.eveniment += new iteratie(B.HandlerB);
            P.DeclansareEveniment();

        }
    }
}
