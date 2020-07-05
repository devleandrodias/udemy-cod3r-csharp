using System;

namespace CursoCSharp.MetodosFuncoes
{
    public static class ExtensoesInteiro
    {
        // this é instância atual do inteiro que vai estar sendo passado

        public static int Soma(this int num1, int num2) => num1 + num2;

        public static int Subtracao(this int num1, int num2) => num1 - num2;
    }

    public class MetodosExtensao
    {
        public static void Executar()
        {
            int numero = 5;

            Console.WriteLine(numero.Soma(15));
            Console.WriteLine(numero.Subtracao(2));
            Console.WriteLine(10.Subtracao(5));

            Console.ReadKey();
        }
    }
}
