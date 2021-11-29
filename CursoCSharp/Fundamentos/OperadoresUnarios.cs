using System;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresUnarios
    {
        public static void Executar()
        {
            int valorNegativo = -5;
            int numero1 = 2;
            int numero2 = 3;
            bool booleano = true;

            Console.WriteLine(-valorNegativo);
            Console.WriteLine(!booleano);

            numero1++;
            Console.WriteLine(numero1);

            --numero1;
            Console.WriteLine(numero1);

            /*
             * Siguinifica que primeiro o --numero2 será decrementado
             * antes de ser feito a comparação e o numero1++ será 
             * incrementado após fazer a comparação
             */

            Console.WriteLine(numero1++ == --numero2);
            Console.WriteLine($"N1: {numero1} \nN2: {numero2}");

            Console.ReadKey();
        }
    }
}
