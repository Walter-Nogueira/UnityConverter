using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades.UnityMass
{
    internal class MassConverter
    {
        public void Mass()

        {
            // Conversor das unidadas de massas

            Console.WriteLine("\n E possivel fazer conversão das seguintes unidades:");
            Console.WriteLine(" 1. Tonelada\n 2. Quilograma\n 3. Libra");

            int whatToDo = 1;
            while (whatToDo != 0)
            {

                Console.Write("\n De: "); // É precisso melhorar essa messagem kkk
                int unit1 = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Para: ");
                int unit2 = Convert.ToInt32(Console.ReadLine());

                MassErro massErro = new MassErro(); // Condicional de erro
                massErro.ConditionErro(unit1, unit2);

                Console.Write("\n Entre com o valor a ser convertido: ");
                double value = Convert.ToDouble(Console.ReadLine());
                MassSwitch massSwitch = new MassSwitch(); // Switch
                massSwitch.Condition(unit1, unit2, value);
            }
        }
    }
}