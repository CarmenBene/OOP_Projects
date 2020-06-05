using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Publisher
{
    class SubscriberA
    {
        public void HandlerA(int n)
        {
            Console.WriteLine("Subscriber A a primit notificare " + n);
        }
    }
}
