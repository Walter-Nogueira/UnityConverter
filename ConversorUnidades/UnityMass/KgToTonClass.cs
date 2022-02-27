using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades
{
    internal class KgToTonClass
    {
        public void KgToTon(double getValue)
        {

            double result = getValue / 1000;
            Console.WriteLine("\n {0} Kg = {1} Tonelada(s)", getValue, Math.Round(result, 3));
        }
    }
}
