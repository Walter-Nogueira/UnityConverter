using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades.UnityLength
{
    internal class MeterToKmClass
    {
        public void MeterToKm(double getValue)
        {
            double result = getValue / 1000;

            if (getValue >= 1 || getValue <= 9)
                Console.WriteLine("\n {0}m = {1}Km", getValue, Math.Round(result, 3));
            else
                Console.WriteLine("\n {0}m = {1}Km", getValue, Math.Round(result, 2));
        }
    }
}
