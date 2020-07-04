using System;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresTernarios
    {
        public static void Executar()
        {
            Console.Write("Digite sua nota: ");

            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine(nota >= 7.0 ? "Aprovado" : "Reprovado");

            Console.ReadLine();
        }
    }
}
