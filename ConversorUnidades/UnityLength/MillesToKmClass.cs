using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades.UnityLength
{
    internal class MillesToKmClass
    {
        public void MillesToKm(double getValue)
        {
            double result = getValue * 1.609;
            Console.WriteLine("\n {0} Mi = {1}Km", getValue, Math.Round(result, 3));
        }
    }
}
