using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades
{
    internal class TonToLbClass
    {
        public void TonToLb(double getValue)
        {

            double result = getValue * 2204.62;
            Console.WriteLine(" \n{0} tonelada(s) = {1} lb", getValue, Math.Round(result, 2));
        }
    }
}
