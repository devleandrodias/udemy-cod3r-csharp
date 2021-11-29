using System;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresAtribuicao
    {
        public static void Executar()
        {
            int num1;

            // Atribuição Substutiva num1 = 10
            num1 = 10;
            Console.WriteLine(num1);

            // Atribuição Aditiva num1 = num1 + 3
            num1 += 3;

            Console.WriteLine(num1);

            // Atribuição Subtrativa num1 = num1 - 1
            num1 -= 1;
            Console.WriteLine(num1);

            // Atribuição Multiplicativa num1 = num1 * 2
            num1 *= 2;
            Console.WriteLine(num1);

            // Atribuição Divisivel num1 = num1 / 3
            num1 /= 10;
            Console.WriteLine(num1);

            Console.WriteLine(num1++); // Pós Fixada
            Console.WriteLine(num1--); // Pós Fixada

            Console.WriteLine(++num1); // Pré Fixada
            Console.WriteLine(--num1); // Pré Fixada

            // Atribuição por cópia
            // Atribuição por referência

            Console.Write("Selecione qualquer tecla para encerrar programa...");
            Console.ReadKey();
        }
    }
}
