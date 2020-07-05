using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    public class Dicionario
    {
        public static void Executar()
        {
            /*
             * Dicionário é uma estrutura chave valor
             * aceita repetição no valor mas não aceita
             * repetição na chave
             */

            Dictionary<int, string> filmes = new Dictionary<int, string>
            {
                { 2000, "Gladiador" },
                { 2002, "Homem-Aranha" },
                { 2004, "Os Incríveis" },
                { 2006, "O Grande Truque" }
            };

            Console.Write("Digite o ano do filme: ");

            int.TryParse(Console.ReadLine(), out int anoFilme);

            if (filmes.ContainsKey(anoFilme))
            {
                Console.WriteLine($"Filme {filmes[anoFilme]} do ano " +
                    $"de {anoFilme}");

                Console.WriteLine($"Existe filme no ano {anoFilme}? " +
                    $"{filmes.GetValueOrDefault(anoFilme)}");
            }

            Console.WriteLine(filmes.ContainsValue("Resident Evil"));

            Console.WriteLine("Removeu? {0}", filmes.Remove(2000));

            filmes.TryGetValue(2006, out string filme2006);

            Console.WriteLine("Qual filme existe em 2006? {0}", filme2006);

            foreach (int chave in filmes.Keys)
            {
                Console.WriteLine(chave);
            }

            foreach (string titulo in filmes.Values)
            {
                Console.WriteLine(titulo);
            }

            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"O filme {filme.Value} é do ano de " +
                    $"${filme.Key}");
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"O filme {filme.Value} é do ano de " +
                    $"${filme.Key}");
            }

            Console.ReadKey();
        }
    }
}
