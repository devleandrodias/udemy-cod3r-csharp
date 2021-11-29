using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    public enum EMoeda
    {
        BRL = 0,
        USD = 1
    }

    public class OperadoresArimeticos
    {
        public static void Executar()
        {
            var preco = 1000.0;
            int imposto = 355;
            var desconto = 0.1;

            var total = preco + imposto;
            var totalComDesconto = total - (total * desconto);

            CultureInfo cultureInfoBR = new CultureInfo("pt-BR");
            CultureInfo cultureInfoUS = new CultureInfo("en-US");

            Console.WriteLine("Em qual moeda você quer calcular? \n [0] - BRL " +
                "\n [1] - USD");

            Console.Write("Digite sua resposta: ");

            if (int.TryParse(Console.ReadLine(), out int moeda))
            {

                CultureInfo moedaSelecionada = moeda == (int)EMoeda.BRL ?
                    cultureInfoBR : cultureInfoUS;

                Console.WriteLine($"O preço total é {total.ToString("C2", moedaSelecionada)}, " +
                    $"o valor com desconto de {desconto * 100}% é " +
                    $"{totalComDesconto.ToString("C2", moedaSelecionada)}");
            }
            else {
                Console.WriteLine("Moeda Inválida, Tente Novamente!");
            };

            // IMC

            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);

            Console.WriteLine($"Seu IMC é {imc}");

            // Par ou ímpar

            Console.Write("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out int primeiroNumero);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int segundoNumero);

            double valorDivisao = primeiroNumero / segundoNumero;
            int moduloDivisao = primeiroNumero % segundoNumero;
            string parImpar = moduloDivisao == 0 ? "Par" : "Ímpar";

            Console.WriteLine($"O módulo da divisão de " +
                $"{primeiroNumero}/{segundoNumero} é {valorDivisao} portanto é" +
                $" um número {parImpar}");
        }
    }
}
