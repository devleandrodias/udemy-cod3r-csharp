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

    public class CalculadoraCadeia
    {
        public int Resultado { get; private set; }

        public CalculadoraCadeia Somar(int x)
        {
            Resultado += x;

            /*
             * this = instância atual do objeto que você está trabalhando
             */

            return this;
        }

        public CalculadoraCadeia Multiplicar(int x)
        {
            Resultado *= x;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            Resultado = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(Resultado);
            return this;
        }
    }

    public class MetodosComRetorno
    {
        public static void Executar()
        {
            Console.WriteLine(new CalculadoraComum().Somar(5, 10, 5));

            _ = new CalculadoraCadeia()
                .Somar(5).Somar(15).Multiplicar(2).Multiplicar(100).Imprimir();

            Console.ReadKey();
        }
    }
}
