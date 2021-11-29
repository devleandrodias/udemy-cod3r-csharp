using System;

namespace CursoCSharp.Fundamentos
{
    public class NotacaoPonto
    {
        public static void Executar()
        {
            string saudacao = "Olá";

            Console.WriteLine(saudacao.ToUpper().Insert(3, " World").Replace("World", "Mundo!"));

            string valorImportante = null;

            /*
             * Váriaveis que estão nullas caso tentar acessar
             * alguma propriedade vai quebrar, para resolver 
             * esse problemas utliza-se o caracteres ? de
             * nullabe
             */

            Console.WriteLine(valorImportante?.Length);
        }
    }
}
