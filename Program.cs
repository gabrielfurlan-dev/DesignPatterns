using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha qual pattern deseja executar: ");
            
            var input = Console.ReadKey();
            int numeroPattern = 0;

            if (char.IsDigit(input.KeyChar))
                numeroPattern = int.Parse(input.KeyChar.ToString());

            ExecutarPattern(numeroPattern);
        }

        private static void ExecutarPattern(int numeroPattern)
        {
            Console.Clear();
            
            switch (numeroPattern)
            {
                case 1:
                    new AbstractFactory.AbstractFactory().Main();
                break;

                default:
                    Console.WriteLine("Opção inválida");
                break;
            }
        }
    }
}