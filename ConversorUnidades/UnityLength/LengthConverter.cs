using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades
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
            Console.Write("\n Para: ");
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

            Console.Write("\n Entre com o valor a ser convertido: ");
            double value = Convert.ToDouble(Console.ReadLine());

            switch (unit1, unit2)
            {
                case (1, 2): // Quilometro para Metro
                    KmToMeterClass kmToMeter = new KmToMeterClass();
                    kmToMeter.KmToMeter(value);
                    break;
                case (1, 3): // Quilometro para Milha
                    KmToMillesClass kmToMilles = new KmToMillesClass();
                    kmToMilles.KmToMilles(value);
                    break;
                case (2, 1): // Metro para Quilometro
                    MeterToKmClass meterToKm = new MeterToKmClass();
                    meterToKm.MeterToKm(value);
                    break;
                case (2, 3): // Metro para Milha
                    MeterToMilleClass meterToMille = new MeterToMilleClass();
                    meterToMille.MeterToMille(value);
                    break;

            }


        }

    }
}
