using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades.UnityLength
{
    internal class KmToMeterClass
    {
        public void KmToMeter(double getValue)
        {
            double result = getValue * 1000;
            Console.WriteLine("\n {0}Km = {1}m", getValue, result);
        }
    }
}
