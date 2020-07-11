using System;

namespace CursoCSharp.ClassesMetodos
{
    public class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach(string pessoa in pessoas)
            {
                Console.WriteLine($"Olá {pessoa}, Bom Dia!!");
            }
        }

        public static void Executar()
        {
            Recepcionar("Pedro", "Manu", "Roger", "Leandro");

            Console.ReadKey();
        }
    }
}
