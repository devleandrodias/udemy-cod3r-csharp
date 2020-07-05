using System;

namespace CursoCSharp.MetodosFuncoes
{
    delegate string StringOperacao(string s);

    public class DelegateFuncAnonima
    {
        public static void Executar()
        {
            /*
             * O tipo de retorno está definido pelo tipo do Delegate,
             * depois do = é uma função anônima
             */

            /*
             * Propósito da função inverter um array de caracteres
             * em uma string
             */

            static string inverter(string s)
            {
                char[] charArray = s.ToCharArray();

                Array.Reverse(charArray);

                return new string(charArray);
            }

            Console.WriteLine(inverter("C# é show"));
            Console.WriteLine(inverter("Amor".ToUpper()));

            Console.ReadKey();
        }
    }
}
