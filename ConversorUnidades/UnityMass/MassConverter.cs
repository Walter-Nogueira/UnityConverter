using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades
{
    internal class MassConverter
    {
        public void Mass()

        {
            // Conversor das unidadas de massas

            Console.WriteLine("\n E possivel fazer conversão das seguintes unidades:");
            Console.WriteLine(" 1. Tonelada\n 2. Quilograma\n 3. Libra");

            Console.Write("\n De: "); // É precisso melhorar essa messagem kkk
            int unit1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Para: ");
            int unit2 = Convert.ToInt32(Console.ReadLine());

            MassIf massIf = new MassIf();
            massIf.ConditionErro(unit1, unit2);

            Console.Write("\n Entre com o valor a ser convertido: ");
            double value = Convert.ToDouble(Console.ReadLine());
            MassSwitch massSwitch = new MassSwitch(); // Chama a classe de S
            massSwitch.Condition(unit1, unit2, value); 
        }
    }
}