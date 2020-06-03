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
            Load();

            for (int i = 0; i < elevi.Count - 1; i++)
            {
                for (int j = i + 1; j < elevi.Count; j++)
                    if ((elevi[i].media < elevi[j].media) || ((elevi[i].media < elevi[j].media) && (StringCompare(elevi[i].name, elevi[j].name) < 0)))
                    {
                        Elev aux = elevi[i];
                        elevi[i] = elevi[j];
                        elevi[j] = aux;
                    }
            }

            elevi.Sort((x, y) =>
            {
                var result = y.media.CompareTo(x.media);
                if (result == 0) 
                    result = y.name.CompareTo(x.name);
                return result;
            });

            Save();
        }

        static void Save()
        {
            TextWriter dataSave = new StreamWriter(@"..\..\data.out");
            foreach (Elev e in elevi)
                dataSave.WriteLine(e.ToString());
            dataSave.Close();
        }
        static void Load()
        {
            TextReader dataLoad = new StreamReader(@"..\..\data.txt");
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
