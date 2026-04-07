using System;
namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("========== 6) Ler A, B, C ==========");
            Console.ResetColor();
            Console.Write("Informe o Valor de A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Informe o Valor de B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Informe o Valor de C: ");
            int c = int.Parse(Console.ReadLine());

            int soma = a + b;
            if(soma < c)
            {
                Console.WriteLine($"Valor de a: {a} | Valor de b: {b} | Valor de c: {c}");
            }
            else
            {
                Console.WriteLine("Valor de a + b é maior que o valor de c");
            }

        }
    }
}