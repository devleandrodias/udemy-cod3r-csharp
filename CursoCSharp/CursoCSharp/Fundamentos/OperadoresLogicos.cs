using System;

namespace CursoCSharp.Fundamentos
{
    public class OperadoresLogicos
    {
        public static void Executar()
        {
            bool executouTrabalho1 = true;
            bool executouTrabalho2 = true;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine("Comprou TV 50? {0}", comprouTv50);

            // Ou Exclusivo, um é verdadeiro e outro é falso
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine("Comprou TV 32? {0}", comprouTv32);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine("Comprou Sorvete? {0}", comprouSorvete);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete);

            // Operadores Unários (!)
            // Operadores Binários (||, !=, ==)
            // Operadores Ternários 
        }
    }
}
