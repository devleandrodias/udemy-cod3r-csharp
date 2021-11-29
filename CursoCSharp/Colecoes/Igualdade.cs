using System;

namespace CursoCSharp.Colecoes
{
    public class Igualdade
    {
        public static void Executar()
        {
            Produto p1 = new Produto("Livro Guerra Nas Estrelas", 10.0);
            Produto p2 = new Produto("Livro Guerra Nas Estrelas", 10.0);
            Produto p3 = p2;
            Produto p4 = new Produto("Livro Guerra dos Tronos", 49.99);

            // Nesse caso está comparando endereço de memórias
            Console.WriteLine(p1 == p2);

            // Nesse caso está comparando dois endereços de memória iguais
            Console.WriteLine(p2 == p3);

            // Método Equal
            Console.WriteLine(p1.Equals(p2));

            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p3.GetHashCode());
            Console.WriteLine(p4.GetHashCode());

            Console.ReadKey();
        }
    }
}
