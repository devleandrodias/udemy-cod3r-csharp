using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    public class Fila
    {
        public static void Executar()
        {
            /*
             * FIFO: Firs In Fist Out
             * Primeiro que entra é o primeiro que sai
             */

            var fila = new Queue<string>(); // Esse usa genérics

            fila.Enqueue("Thaísa");
            fila.Enqueue("Leandro");
            fila.Enqueue("Bratriz");

            // Peek pega o primeiro elemento da fila mas não o remove
            Console.WriteLine(fila.Peek());

            Console.WriteLine(fila.Count);

            fila.Dequeue();
            
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue(); // Esse não usa generics

            salada.Enqueue("Pessoa 1");
            salada.Enqueue("Pessoa 2");
            salada.Enqueue(true);
            salada.Enqueue(123.123);

            Console.WriteLine(salada.Contains("Pessoa 2"));

            Console.ReadKey();
        }
    }
}
