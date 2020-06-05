using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_Publisher
{
    class SubscriberB
    {
        public void HandlerB(int n)
        {
            Console.WriteLine("Subscriber B a primit notificare "+ n);
        }
    }
}
