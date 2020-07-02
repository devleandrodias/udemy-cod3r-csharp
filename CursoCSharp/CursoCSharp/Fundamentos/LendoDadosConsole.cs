using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    public class LendoDadosConsole
    {
        public static void Executar()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"Olá Sr. {sobrenome}, {nome} e tenho {idade} " +
                $"anos e ganho {salario} de salário");
        }
    }
}
