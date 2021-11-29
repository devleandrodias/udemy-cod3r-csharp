using System;
namespace CursoCSharp.Fundamentos
{
    public class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.Write("Digite a nota de corte: ");
            double.TryParse(Console.ReadLine(), out double notaCorte);

            Console.Write("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Nota inválida? {0}", nota > 10 || nota < 0);
            Console.WriteLine("Perfeito? {0}", nota == 10);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10);
            Console.WriteLine("Passou por média? {0}", nota >= notaCorte);
            Console.WriteLine("Recuperação? {0}", nota < notaCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}
