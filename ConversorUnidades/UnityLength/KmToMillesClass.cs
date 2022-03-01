using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades.UnityLength
{
    internal class KmToMillesClass
    {
        public void KmToMilles(double getValue)
        {
            double result = getValue / 1.609;
            Console.WriteLine("\n {0}Km = {1} Mi", getValue, Math.Round(result, 2));
        }
    }
}
