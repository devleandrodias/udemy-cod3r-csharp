using System;

namespace CursoCSharp.ClassesMetodos
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar() => string.Format($"Olá! Me chamo {Nome} e " +
            $"tenho {Idade} anos de idade");

        public void ApresentarNoConsole() => Console.WriteLine(Apresentar());
    }
}
