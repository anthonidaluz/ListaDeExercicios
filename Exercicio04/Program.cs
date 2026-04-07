using System;
namespace Exercicio04
{
    class Program
    {
        static void Main(String[]args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("========== 4) Calcular Salário Total ==========");
            Console.ResetColor();

            Console.Write("Informe seu Salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.Write("Informe o Total de Vendas: ");
            double totalVendas = double.Parse(Console.ReadLine());
            Console.Write("Informe o percentual da sua comissão por venda: ");
            double percentualComissao = double.Parse(Console.ReadLine());

            double comissao = (percentualComissao / 100) * totalVendas;
            double salarioTotal = salario + comissao;

            Console.WriteLine($"Seu salário total é de R$ {salarioTotal:F2}");

        }
    }
}