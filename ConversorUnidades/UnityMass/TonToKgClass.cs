using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades.UnityMass
{
    internal class TonToKgClass
    {
        public void TonToKg(double getValue)
        {

            double result = getValue * 1000;
            Console.WriteLine("\n {0} tonelada(s) = {1} Kg", getValue, Math.Round(result, 2));
        }
    }
}
