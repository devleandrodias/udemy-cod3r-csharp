using System;

namespace CursoCSharp.MetodosFuncoes
{
    public class DelegateComParametros
    {
        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y) => x + y;
        public static int Subtracao(int x, int y) => x - y;

        public static string Calculadora(Operacao operacao, int x, int y) =>
           $"Resultado: {operacao(x, y)}"; 

        public static void Executar()
        {
            Console.WriteLine(Calculadora(Soma, 15, 5));

            Operacao operacaoSubtracao = (int x, int y) => x - y;

            Console.WriteLine(Calculadora(operacaoSubtracao, 25, 15));

            Console.ReadKey();
        }
    }
}
