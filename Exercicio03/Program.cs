using System;
namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("========== 3) Celsius para Fahrenheit ==========");
            Console.ResetColor();
            Console.Write("Informe a temperatura em Celsius: ");
            float tempCelsius = float.Parse(Console.ReadLine());

            float tempFahrenheit = (tempCelsius * 9 / 5) + 32;
            Console.WriteLine($"Temperatua em Fahrenheit {tempFahrenheit} F");


        }
    }
}