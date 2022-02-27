using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades
{
    internal class LbToKgClass
    {
        public void KgToLb(double getValue)
        {

            double result = getValue / 2.20462;
            Console.WriteLine(" \n{0} Libra(s) = {1} Kg", getValue, Math.Round(result, 3));
        }
    }
}
