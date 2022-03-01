using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades.UnityMass
{
    internal class LbToTonClass
    {
        public void LbToTon(double getValue)
        {

            double result = getValue / 2204.62;
            Console.WriteLine("\n {0} Libra(s) = {1} Tonelada(s)", getValue, Math.Round(result, 3));
        }
    }
}
