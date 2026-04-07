using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("========== 5) Calcular Média Provas ==========");
            Console.ResetColor();
            Console.Write("Informe a primeira nota: ");
            double prova1 = double.Parse(Console.ReadLine());
            Console.Write("Informe a segunda nota: ");
            double prova2 = double.Parse(Console.ReadLine());
            double media = (prova1 + prova2) / 2;
            Console.WriteLine($"A média das provas é: {media:F2}");
        }

    }
}