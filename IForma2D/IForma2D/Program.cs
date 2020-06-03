using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfata_IForma2D
{
    class Program
    {
        public interface IForma2D
        {
            void Arie();
            void LungimeaFrontierei();
            string denumire { get; }
        }
       
        static void Main(string[] args)
        {

        }
    }
}
