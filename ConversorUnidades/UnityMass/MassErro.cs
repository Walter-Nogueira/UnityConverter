using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades
{
    internal class MassErro
    {
        public void ConditionErro(double unit1, double unit2)
        {
            if (unit1 < 1 || unit1 > 3 || unit2 < 1 || unit2 > 3 || unit1 == unit2)
            {
                Console.WriteLine("\n ERROR");
                Environment.Exit(0);
            }
        }
    }
}
