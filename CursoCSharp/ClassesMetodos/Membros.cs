using System;

namespace CursoCSharp.ClassesMetodos
{
    public class Membros
    {
        /*
         * Quando se dá o new em uma classe é criado um objeto
         * ou uma instância da classe, nomes diferentes com a mesma 
         * função
         */

        // Isso é um atributo da classe

        public static void Executar()
        {
            Pessoa pessoa1 = new Pessoa
            {
                Nome = "Leandro",
                Idade = 19
            };

            Console.WriteLine(pessoa1.Apresentar());

            pessoa1.ApresentarNoConsole();

            Console.ReadKey();
        }
    }
}
