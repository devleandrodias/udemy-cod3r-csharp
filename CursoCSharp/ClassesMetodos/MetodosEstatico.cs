using System;

namespace CursoCSharp.ClassesMetodos
{
    public class CalculadoraEstatica
    {
        /*
         * Quando há um método estático ele não pertence mais ao objeto e 
         * sim a classe e não é necessário instânciar uma classe para acessa-lo.
         * Quando um método não é estático ele só é acessivel através da
         * instância.
         */

        public static int Somar(int x, int y) => x + y;
        public static int Multiplicar(int x, int y) => x * y;
    }

    public class MetodosEstatico
    {
        public static void Executar()
        {
            Console.WriteLine(CalculadoraEstatica.Multiplicar(5, 10));
        }
    }
}
