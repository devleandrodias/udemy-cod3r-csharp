using System;

namespace CursoCSharp.ClassesMetodos
{
    public class ParamsNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
        }

        public static void Executar()
        {
            Formatar(ano: 2020, mes: 10, dia: 5);

            Console.ReadKey();
        }
    }
}
