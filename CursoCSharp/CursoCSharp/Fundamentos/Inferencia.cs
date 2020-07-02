using System;

namespace CursoCSharp.Fundamentos
{
    public class Inferencia
    {
        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            var tipoAindaIndefinidoDeveSerInicializada = 123;

            tipoAindaIndefinidoDeveSerInicializada = 10;

            Console.WriteLine(tipoAindaIndefinidoDeveSerInicializada);

            var inferencia = "Inferência pro tipo string var -> string";

            inferencia = "só pode ser string mesmo não estando definido tipo implicitamente";

            Console.WriteLine(inferencia);
        }
    }
}
