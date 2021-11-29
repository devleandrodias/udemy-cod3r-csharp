using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    public class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;

            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultureInfoBR = new CultureInfo("pt-BR");
            CultureInfo cultureInfoUS = new CultureInfo("en-US");

            Console.WriteLine(valor.ToString("C0", cultureInfoBR));
            Console.WriteLine(valor.ToString("C0", cultureInfoUS));

            int inteiro = 256;

            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
