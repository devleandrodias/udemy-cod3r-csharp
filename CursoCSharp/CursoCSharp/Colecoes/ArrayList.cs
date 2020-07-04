using System;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    public class ColecoesArrayList
    {
        public static void Executar()
        {
            // Array List é uma lista heterogenea

            ArrayList arrayList = new ArrayList
            {
                "Palavra",
                3,
                true
            };

            arrayList.Add(3.12);

            foreach (object item in arrayList)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }

            Console.ReadLine();
        }
    }
}
