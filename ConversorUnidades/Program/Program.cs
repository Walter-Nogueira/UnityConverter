using System;

namespace ConversorUnidades
{
    internal class Program
    {
        public void Main(string[] args)
        {
            // Aqui é onde acessa todas as classes

            Console.WriteLine(" Conversor de unidades");
            Console.WriteLine(" -----------------------------");
            MessageStart message = new MessageStart();
            message.Message_Start();
            int userEntre = Convert.ToInt32(Console.ReadLine());

            while (userEntre != 0)
            {
                switch (userEntre)
                {
                    case 1:
                        MassConverter mass = new MassConverter();
                        mass.Mass();
                        break;
                    case 2:
                        LengthConverter length = new LengthConverter();
                        length.Length();
                        break;
                }
            }

        }
    }
}
