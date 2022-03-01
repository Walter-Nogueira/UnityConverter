using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades.UnityMass
{
    internal class MassSwitch
    {
        public void Condition(double unit1, double unit2, double value)
        {
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
