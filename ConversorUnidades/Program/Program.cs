using System;

namespace ConversorUnidades
{
    internal class Program
    {
        static void Main(string[] args)
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

                userEntre = ToDoNow(userEntre); // Opção final de execução

                if (userEntre == 0)
                {
                    CloseApp();
                }
                else
                {
                    message.Message_Start();
                    userEntre = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        static int ToDoNow(int userEntre) // escolha do usuário ao final da operação
        {
            Console.WriteLine("\n 0. Sair\n 1. Realizar uma nova conversao");
            Console.Write(" O que deseja fazer agora? ");
            userEntre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            return userEntre;
        }

        static void CloseApp()
        {
            Console.WriteLine(" Calculadora encerrada");
            Environment.Exit(0);
        }
    }

}
