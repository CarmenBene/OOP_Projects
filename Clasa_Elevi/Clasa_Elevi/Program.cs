using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clasa_Elevi
{
    class Program
    {
        static List<Elev> elevi = new List<Elev>();
        static void Main(string[] args)
        {

        }

        static void save()
        {
            TextWriter dataSave = new StreamWriter(@"..\..\data.out");
            foreach (Elev e in elevi)
                dataSave.WriteLine(e.ToString());
            dataSave.Close();
        }
        static void Load()
        {
            TextReader dataLoad = new StreamReader(@"..\..\data");
            string buffer;
            while ((buffer = dataLoad.ReadLine()) != null)
                elevi.Add(new Elev(buffer));
            dataLoad.Close();
        }
        static int StringCompare(string A,string B)
        {
            if (A.Length < B.Length)
                return -1;
            else
                if (A.Length > B.Length)
                return 1;
            else
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] < B[i])
                        return -1;
                    else if (A[i] > B[i])
                        return 1;
                }
            }
            return 0;
        }
    }
}
