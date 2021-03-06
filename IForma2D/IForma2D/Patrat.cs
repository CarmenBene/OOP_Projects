﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIForma2D
{
    public class Patrat : IForma2D
    {
        public string denumire => "Patrat";
        public double l;
        public Patrat(double l)
        {
            this.l = l;
        }

        public double Arie()
        {
            return Math.Pow(l, 2);
        }

        public double LungimeaFrontierei()
        {
            return 4 * l;
        }
    }
}
