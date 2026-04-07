using System;

namespace Exercicio08
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("========== 8) Ímpar ou par ==========");
            Console.ResetColor();
            Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine($"{numero} é par.");
            }
            else
            {
                Console.WriteLine($"{numero} é ímpar.");
            }
        }
    }
}

