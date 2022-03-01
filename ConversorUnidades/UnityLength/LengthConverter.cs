using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades.UnityLength
{
    internal class LengthConverter
    {
        public void Length()
        {
            // Conversor das unidades de comprimento

            Console.WriteLine("\n E possivel fazer conversão das seguintes unidades:");
            Console.WriteLine(" 1. Quilometro\n 2. Metro\n 3. Milha");

            Console.Write("\n De: ");
            int unit1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Para: ");
            int unit2 = Convert.ToInt32(Console.ReadLine());

            // Condicional de erro
            LengthErro lenghtErro = new LengthErro();
            lenghtErro.ConditionErro(unit1, unit2);

            Console.Write("\n Entre com o valor a ser convertido: ");
            double value = Convert.ToDouble(Console.ReadLine());
            // Swith
            LenghtSwitch lenghtSwitch = new LenghtSwitch();
            lenghtSwitch.Condition(unit1, unit2, value);


        }

    }
}
