using System;

namespace CursoCSharp.ClassesMetodos
{
    public class DesafioAtributo
    {
        readonly int x = 10;

        public static void Executar()
        {
            // Acessar a váriavel 'x' dentro do método executar;

            Console.WriteLine(new DesafioAtributo().x);

            Console.ReadKey();
        }
    }
}
