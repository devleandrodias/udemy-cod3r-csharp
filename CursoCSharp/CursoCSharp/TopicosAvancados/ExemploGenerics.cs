using System;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        readonly T valorPrivado;

        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
        }

        public T MetodoGenerico(T valor) =>
            new Random().Next(0, 2) == 0 ? Coisa : valor;

        public T GetValor => valorPrivado;
        
    }

    public class CaixaInt : Caixa<int>
    {
        public CaixaInt(int coisa) : base(coisa)
        {

        }
    }

    public class ExemploGenerics
    {
        public static void Executar()
        {
            Caixa<int> caixaGenerico = new Caixa<int>(1000);

            Console.WriteLine(caixaGenerico.MetodoGenerico(33));

            Console.WriteLine(caixaGenerico.Coisa.GetType().Name);

            Console.ReadKey();
        }
    }
}
