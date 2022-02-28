using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades
{
    internal class LenghtSwitch
    {
        public void Condition(double unit1, double unit2, double value)
        {
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
                case (3, 1): // Milha para Quilometro
                    MillesToKmClass millesToKm = new MillesToKmClass();
                    millesToKm.MillesToKm(value);
                    break;
                case (3, 2):
                    MillesToMeterClass millesToMeter = new MillesToMeterClass();
                    millesToMeter.MillesToMeter(value);
                    break;
            }
        }
    }
}
