using System;

namespace CursoCSharp.ClassesMetodos
{
    public class Produto
    {
        public Produto()
        {

        }

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public double CalcularPrecoDesconto() => Preco - (Preco * Desconto);
    }

    public class AtributosEstaticos
    {
        public static void Executar()
        {
            Produto.Desconto = 0.5;

            /*
             * Atributos estáticos pertencem as classes e são usados por todos
             */

            Produto p1 = new Produto("Caneta", 3.2, 0.2);

            Produto p2 = new Produto() {
                Nome = "Lápis",
                Preco = 1.25,
            };

            Console.WriteLine($"Produto {p1.Nome}, por {p1.Preco} reais");
            Console.WriteLine($"Produto {p2.Nome}, por {p2.Preco} reais");

            Console.ReadKey();
        }
    }
}
