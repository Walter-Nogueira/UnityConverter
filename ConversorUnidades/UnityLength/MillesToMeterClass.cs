using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades
{
    internal class MillesToMeterClass
    {
        public void MillesToMeter(double getValue)
        {
            double result = getValue * 1609;
            Console.WriteLine("\n {0} Mi = {1}m", getValue, Math.Round(result));
        }
    }
}
