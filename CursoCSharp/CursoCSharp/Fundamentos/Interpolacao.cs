using System;
namespace CursoCSharp.Fundamentos
{
    public class Interpolacao
    {
        public static void Executar()
        {
            string nome="Leandro", sobrenome="Dias";
            int idade = 19;

            Console.WriteLine("Eu sou o " + nome + " " + sobrenome + " e tenho " + idade + " anos");
            Console.WriteLine("Eu sou o {0} {1} e tenho {2} anos", nome, sobrenome, idade);
            Console.WriteLine($"Eu sou o {nome} {sobrenome} e tenho {idade} anos");
        }
    }
}
