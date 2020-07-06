using System;

namespace CursoCSharp.ClassesMetodos
{
    public class Carro
    {
        public Carro()
        {

        }

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public string Modelo;
        public string Fabricante;
        public int Ano;

        public override string ToString() => string.Format($"Carro de modelo " +
            $"{Modelo}, fabricado por {Fabricante}, no ano {Ano}");
    }

    public class Construtores
    {
        public static void Executar()
        {
            /*
             * Quando você não define um construtor para a classe o
             * construtor padrão está presente () construtor vazio,
             * não recebe nenhum parametro e develve uma instância da 
             * classe, o construtor tem mesmo nome que a classe
             */

            Carro carro1 = new Carro() {
                Modelo = "BMW X6",
                Fabricante = "BMW",
                Ano = 2020
            };

            Carro carro2 = new Carro("Eco Sport", "Ford", 2017);     

            Console.WriteLine(carro1.ToString());
            Console.WriteLine(carro2.ToString());

            Console.ReadKey();
        }
    }
}
