using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereRationale
{
    public class Q
    {
        static int cmmdc(int A, int B)
        {
            while (B != 0)
            {
                int r = A % B;
                A = B;
                B = r;
            }
            return A;
        }

        private int numarator;
        private int numitor;

        public Q(int numarator, int numitor)
        {
            this.numarator = numarator;
            this.numitor = numitor;
            this.ireductibil();

        }
        public Q()
        {
        }

        public override string ToString()
        {
            return "(" + numarator + "/" + numitor + ")";
        }

        public static Q operator +(Q A, Q B)
        {
            Q tor = new Q();
            tor.numarator = A.numarator * B.numitor + B.numarator * A.numitor;
            tor.numitor = A.numitor * B.numitor;
            tor.ireductibil();
            return tor;
        }

        public static Q operator *(Q A, Q B)
        {
            Q tor = new Q();
            tor.numarator = A.numarator * B.numarator;
            tor.numitor = A.numitor * B.numitor;
            tor.ireductibil();
            return tor;
        }

        public static Q operator -(Q A, Q B)
        {
            Q tor = new Q();
            tor.numarator = A.numarator * B.numitor - B.numarator * A.numitor;
            tor.numitor = A.numitor * B.numitor;
            tor.ireductibil();
            return tor;
        }

        public static Q operator /(Q A, Q B)
        {
            Q tor = new Q();
            tor.numarator = A.numarator * B.numitor;
            tor.numitor = A.numitor * B.numarator;
            tor.ireductibil();
            return tor;
        }

        public static Q POW(Q A, int n)
        {
            Q tor = new Q();
            tor.numarator = (int)Math.Pow(A.numarator, n);
            tor.numitor = (int)Math.Pow(A.numitor, n);
            tor.ireductibil();
            return tor;
        }

        public static bool operator <(Q A, Q B)
        {
            if (A.numarator * B.numitor < A.numitor * B.numarator)
                return true;
            return false;
        }

        public static bool operator >(Q A, Q B)
        {
            if (!(A < B))
                return true;
            return false;
        }

        public void ireductibil()
        {
            int t = cmmdc(numarator, numitor);
            numarator /= t;
            numitor /= t;
        }

        public static bool operator ==(Q A, Q B)
        {
            A.ireductibil();
            B.ireductibil();
            if (A.numitor == B.numitor && A.numarator == B.numarator)
                return true;
            return false;
        }

        public static bool operator !=(Q A, Q B)
        {
            if (!(A == B))
                return true;
            return false;
        }

        public static bool operator <=(Q A, Q B)
        {
            if ((A == B) || (A < B))
                return true;
            return false;
        }
        public static bool operator >=(Q A, Q B)
        {
            if (!(A <= B))
                return true;
            return false;
        }

    }
}

