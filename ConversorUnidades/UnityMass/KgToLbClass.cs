using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades
{
    internal class KgToLbClass
    {
        public void KgToLb(double getValue)
        {

            double result = getValue  * 2.20462;
            Console.WriteLine(" \n{0} Kg = {1} Libra(s)", getValue, Math.Round(result, 3));
        }
    }
}
