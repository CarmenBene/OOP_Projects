using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereRationale
{
    class Program
    {
        static void Main(string[] args)
        {
            Q A = new Q(15,25);
            Q B = new Q(2,8);

            Console.WriteLine("Primul numar este: " + A.ToString());
            Console.WriteLine("Al doilea numar este: " + B.ToString());

            //Adunare
            Q C = A + B;
            Console.WriteLine("Suma celor 2 numere este: " + C.ToString());

            //Scadere
            Q S = A - B;
            Console.WriteLine("Diferenta celor 2 numere este: " + S.ToString());

            //Inmultire
            Q D = A * B;
            Console.WriteLine("Produsul celor 2 numere este: " + D.ToString());

            //Impartire
            Q I = A / B;
            Console.WriteLine("Rezultatul impartirii este: "+I.ToString());

            //Ridicare la putere
            int power = 4;
            Q E = Q.POW(A, power);
            Console.WriteLine("Primul numar la puterea " + power + "este: " + E.ToString());

            int power2 = 2;
            Q E2 = Q.POW(B, power);
            Console.WriteLine("Al doilea numar la puterea " + power2 + "este: " + E2.ToString());


            Console.WriteLine("A<B?");
            if (A < B)
                Console.WriteLine("Da");
            else
                Console.WriteLine("Nu");

            Console.WriteLine("A>B?");
            if (A > B)
                Console.WriteLine("Da");
            else
                Console.WriteLine("Nu");

            Console.WriteLine("A=B?");
            if (A == B)
                Console.WriteLine("Da");
            else
                Console.WriteLine("Nu");

            Console.WriteLine("A!=B?");
            if (A != B)
                Console.WriteLine("Da");
            else
                Console.WriteLine("Nu");

            Console.ReadKey();

        }
    }
}
