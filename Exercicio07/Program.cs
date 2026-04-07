using System;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("========== 7) Calcular IMC ==========");
            Console.ResetColor();

            Console.Write("Informe sua altura: ");
            float altura = float.Parse(Console.ReadLine());

            Console.Write("Informe seu peso: ");
            float peso = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            Console.WriteLine($"\nSeu IMC é: {imc:F1}");

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Você está com o peso ideal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Você está acima do peso");
            }
            else
            {
                Console.WriteLine("Você está obeso");
            }
        }
    }
}