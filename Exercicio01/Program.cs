using System;
namespace Exercicio01
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("========== 1) Calcular volume Caixa ==========");
            Console.ResetColor();

            Console.Write("Informe o Comprimento da Caixa: ");
            double comprimento = Double.Parse(Console.ReadLine());
            Console.Write("Informe a largura da Caixa: ");
            double largura = Double.Parse(Console.ReadLine());
            Console.Write("Informe a Altura da Caixa: ");
            double altura = Double.Parse(Console.ReadLine());

            double volume = comprimento * largura * altura;

            Console.WriteLine($"O Volume da caixa é: {volume}");

        }
    }
}
