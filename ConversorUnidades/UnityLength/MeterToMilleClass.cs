using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades.UnityLength
{
    internal class MeterToMilleClass
    {
        public void MeterToMille(double getValue)
        {
            double result = getValue / 1609;
            Console.WriteLine("\n {0}m = {1} Mi", getValue, Math.Round(result, 8));
        }
    }
}
