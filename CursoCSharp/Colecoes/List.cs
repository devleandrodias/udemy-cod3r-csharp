using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override string ToString() => $"Produto: {Nome} por {Preco}";

        /*
         * HasCode é como se fosse um indice de banco de dados utilizado 
         * para agrupar um conjunto de dados que depois vai ser verificado
         * pelo equals
         */
        
        public override int GetHashCode() => HashCode.Combine(Nome, Preco);

        /*
         * Equals é mais lento que o HasCode, se você tiver não tiver o equals
         * e o hascode em sintonia terá pesquisas inconsistente dentro de 
         * estruturas de hascode, nunca deixe compara com referência de memória
         * quanto mais itens com mesmo HasCode, mais lento será sua pesquisa
         * ideal, será cada instância ter seu próprio HasCode
         */

        public override bool Equals(object obj)
        {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }
    }


    public class List
    {
        public static void Executar()
        {
            List<Produto> carrinhoCompra = new List<Produto>();

            Produto livro = new Produto("Game of Thrones", 49.9);

            /*
             * List é mais dinâmico pode ir acrescentando mais itens a ela,
             * List é uma estrutura indexada
             * List aceita repetição
             */

            carrinhoCompra.Add(livro);

            var combo = new List<Produto>
            {
                new Produto("Roupa de Cama", 89.50),
                new Produto("Lençol de Cama", 89.50),
                new Produto("Caixa bom-bom", 9.99)
            };

            carrinhoCompra.AddRange(combo);
           
            Console.WriteLine($"Quantidade de itens no carrinho:" +
                $" {carrinhoCompra.Count}");

            // Remover o elemento no index 3

            carrinhoCompra.RemoveAt(3);

            foreach (var item in carrinhoCompra)
            {
                Console.WriteLine(carrinhoCompra.IndexOf(item));
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Encerrou repetição...");

            carrinhoCompra.Add(livro);

            Console.WriteLine(carrinhoCompra.Count);
            Console.WriteLine(carrinhoCompra.LastIndexOf(livro));

            Console.ReadKey();
        }
    }
}
