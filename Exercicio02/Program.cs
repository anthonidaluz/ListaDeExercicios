using System;
namespace Exercicio02
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("========== 2) Calcular Consumo Médio de Combustível por KM ==========");
            Console.ResetColor();
            Console.Write("Informe a quilometragem inicial do veículo: ");
            double kmInicial = double.Parse(Console.ReadLine());

            Console.Write("Quilometragem Final: ");
            double kmFinal = double.Parse(Console.ReadLine());

            Console.Write("Quantidade de combustível gasto (em litros): ");
            double litrosGastos = double.Parse(Console.ReadLine());

            double consumoMedio = (kmFinal - kmInicial) / litrosGastos;

            Console.WriteLine($"Consumo Médio de Comnbustível por KM: {consumoMedio}");



        }
    }
}
