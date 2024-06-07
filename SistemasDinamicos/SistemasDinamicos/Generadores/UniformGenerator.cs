using GeneradorDeNumerosAleatorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomVarGenerator
{
    class UniformGenerator
    {
        public double li { get; set; }
        public double ls { get; set; }

        

        public double Generate(int li, int ls, double rnd)
        {
            double num = li + (ls - li) * rnd;
            return num;
        }
    }
}
