using System;

namespace CursoCSharp.ClassesMetodos
{
    public class CalculadoraComum
    {
        /*
         * Uma assinatura do método é composta por
         * Nome do Método (Somar) e seus parâmetros (int x, int y)
         * Nos parametros o que conta é o tipo e a quantidade.
         * 
         * A assinatura do método deve ser única dentro da classe
         */

        public int Somar(int a, int b) => a + b;
        public int Somar(int a, int b, int c) => a + b + c;
    }

    public class MetodosComRetorno
    {
        public static void Executar()
        {
            Console.WriteLine(new CalculadoraComum().Somar(5, 10, 5));

            Console.ReadKey();
        }
    }
}
