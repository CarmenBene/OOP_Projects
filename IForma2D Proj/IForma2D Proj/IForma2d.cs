using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IForma2D_Proj
{
    interface IForma2d
    {
        string Denumire { get; }
        double Arie();
        double LungimeaFrontierei();
    }
}
