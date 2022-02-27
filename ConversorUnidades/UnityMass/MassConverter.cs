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

            int whatToDo = 1;
            while (whatToDo != 0)
            {

                Console.Write("\n De: "); // É precisso melhorar essa messagem kkk
                int unit1 = Convert.ToInt32(Console.ReadLine());

                Console.Write(" Para: ");
                int unit2 = Convert.ToInt32(Console.ReadLine());

                if (unit1 < 1 || unit1 > 3 || unit2 < 1 || unit2 > 3)
                {
                    Console.WriteLine("\n ERROR");
                    Environment.Exit(0);
                }
                else if (unit1 == unit2)
                {
                    Console.WriteLine("\n ERROR");
                    Environment.Exit(0);
                }

                Console.Write(" \nEntre com o valor a ser convertido: ");
                double value = Convert.ToDouble(Console.ReadLine());
                switch (unit1, unit2)
                {
                    case (1, 2): // Tonelada para Quilograma
                        TonToKgClass tonToKg = new TonToKgClass();
                        tonToKg.TonToKg(value);
                        break;
                    case (1, 3): // Tonelada para Libra
                        TonToLbClass tonToLb = new TonToLbClass();
                        tonToLb.TonToLb(value);
                        break;
                    case (2, 1): // Quilograma para Tonelada
                        KgToTonClass kgToTon = new KgToTonClass();
                        kgToTon.KgToTon(value);
                        break;
                    case (2, 3): // Quilograma para Libra
                        KgToLbClass kgToLb = new KgToLbClass();
                        kgToLb.KgToLb(value);
                        break;
                    case (3, 1): // Libra para Tonelada
                        LbToTonClass lbToTon = new LbToTonClass();
                        lbToTon.LbToTon(value);
                        break;
                    case (3, 2): // Libra para Quilograma
                        LbToKgClass lbToKg = new LbToKgClass();
                        lbToKg.KgToLb(value);
                        break;
                }
                
            }
        }
    }
}