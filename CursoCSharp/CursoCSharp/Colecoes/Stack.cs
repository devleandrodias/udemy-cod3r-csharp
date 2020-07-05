using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    public class ColecaoStack
    {
        public static void Executar()
        {
            /*
             * First in Last Out
             * Primeiro item que entra é o último item que sai em uma stack
             */

            Stack pilha = new Stack();

            pilha.Push(3);
            pilha.Push('A');
            pilha.Push("Leandro");

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item} - {item.GetType()}");
            }

            // Remove valor que está no início da pilha

            Console.WriteLine($"\nRemovendo... {pilha.Pop()}\n");

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item} - {item.GetType()}");
            }

            Console.WriteLine($"Qual seria próximo a ser removido? " +
                $"{pilha.Peek()}");

            Console.WriteLine($"Quantos itens ainda existem na pilha? " +
                $"{pilha.Count}");

            Console.ReadKey();
        }
    }
}
