using System;

namespace CursoCSharp.Fundamentos
{
    public class Conversoes
    {
        public static void Executar()
        {
            /*
             * Não ocorre perda de informação
             * Conversão de forma implícita
             */

            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            /*
             * Ocorre perda de informação
             * Conversão de forma explicíta (CAST)
             */

            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine(notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInt = int.Parse(idadeString);

            // Diferentes tipos de conversōes

            Console.WriteLine($"Sua idade é {idadeInt} do tipo " +
                $"{idadeInt.GetTypeCode()}");

            int idadeConvertInt = Convert.ToInt16(idadeString);

            Console.WriteLine($"Sua idade é {idadeConvertInt} do tipo " +
                $"{idadeConvertInt.GetTypeCode()}");

            // out = converta palavra e jogue para váriavel número

            int.TryParse(idadeString, out int numero);

            Console.WriteLine("Sua idade é {0} do tipo {1}", numero,
                numero.GetTypeCode());

            Console.Write("Digite sua idade novamente: ");

            int.TryParse(Console.ReadLine(), out int result);

            Console.WriteLine("Sua idade é {0} do tipo {1}", result,
                result.GetTypeCode());
        }
    }
}
