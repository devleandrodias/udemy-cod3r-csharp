using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    public class Set
    {
        public static void Executar()
        {
            HashSet<Produto> carrinhoCompra = new HashSet<Produto>();

            Produto livro = new Produto("Game of Thrones", 49.9);

            /*
             * HasSet é um conjunto
             * HasSet não é indexada
             * Qualquer ação que use index é perdida
             * HasSet não aceita repetição
             */

            carrinhoCompra.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Roupa de Cama", 89.50),
                new Produto("Lençol de Cama", 89.50),
                new Produto("Caixa bom-bom", 9.99)
            };

            carrinhoCompra.UnionWith(combo); // Conjunto -> AddRange

            Console.WriteLine($"Quantidade de itens no carrinho:" +
                $" {carrinhoCompra.Count}");

            foreach (var item in carrinhoCompra)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Encerrou repetição...");

            carrinhoCompra.Add(livro);

            Console.WriteLine(carrinhoCompra.Count);

            Console.ReadKey();
        }
    }
}
