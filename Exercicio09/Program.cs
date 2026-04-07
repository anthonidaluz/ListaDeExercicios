using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("========== 9) A! Fatorial ==========");
        Console.ResetColor();

        Console.Write("Informe um valor para calcular o fatorial: ");
        int numero = int.Parse(Console.ReadLine());

        int fatorial = 1;

        Console.Write($"{numero}! = ");

        for (int i = numero; i >= 1; i--)
        { 
            fatorial *= i; 

            if (i == 1)
            {
                Console.Write(i);
            }
            else
            {
                Console.Write($"{i} X ");
            }
        }

        Console.WriteLine($" = {fatorial}");
    }
}