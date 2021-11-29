using System;

namespace CursoCSharp.MetodosFuncoes
{
    delegate double Operacao(double x, double y);

    public class LambdasDelegate
    {
        public static void Executar()
        {
            /*
             * O que é um Delegate? 
             * 
             * Um Delegate é voçe definir um tipo que armazena uma assinatura
             * de uma função.
             * 
             * Uma vez que você cria uma váriavel do tipo delegate, espera-se
             * que seja atribuido uma função que respeite a assinatura do 
             * delegate.
             */

            Operacao soma = (x, y) => x + y;
            Operacao subtracao = (x, y) => x - y;
            Operacao multiplcacao = (x, y) => x * y;
            Operacao divisao = (x, y) => x / y;

            Console.WriteLine(soma(2.464, 23423.234));
            Console.WriteLine(subtracao(23424.2345, 324523.34));
            Console.WriteLine(multiplcacao(23424.54325, 23453245.435));
            Console.WriteLine(divisao(23424.23, 23454.34));

            Console.ReadKey();
        }
    }
}
