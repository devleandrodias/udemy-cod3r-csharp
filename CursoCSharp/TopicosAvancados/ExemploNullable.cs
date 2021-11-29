using System;

namespace CursoCSharp.TopicosAvancados
{
    public class ExemploNullable
    {
        public static void Executar()
        {
            Nullable<int> inteiroNullo = null;
            int? inteiroNulloInterrogacao = null;

            inteiroNullo = 4;
            inteiroNulloInterrogacao = 3;

            // Se inteiroNullo for nullo valor padrão será 10

            int inteiroNaoNulo = inteiroNullo ?? 10;

            if (!inteiroNulloInterrogacao.HasValue)
                Console.WriteLine("Váriavel não tem valor");

            bool? booleana = null;

            // Se tiver valor traz, se não traz valor padrão pro tipo da variavel

            Console.WriteLine(booleana.GetValueOrDefault());

            Console.WriteLine(inteiroNullo);
            Console.WriteLine(inteiroNaoNulo);
            Console.WriteLine(inteiroNulloInterrogacao);
        }
    }
}
