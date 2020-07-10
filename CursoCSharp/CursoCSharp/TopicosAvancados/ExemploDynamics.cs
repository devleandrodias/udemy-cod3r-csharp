using System;
using System.Dynamic;

namespace CursoCSharp.TopicosAvancados
{
    public class ExemploDynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "Teste";

            meuObjeto = 5;
            meuObjeto++;

            Console.WriteLine(meuObjeto);

            dynamic aluno = new ExpandoObject();

            aluno.Nome = "Leandro";
            aluno.Nota = 8.5;
            aluno.Professor = "Leonardo";

            Console.WriteLine($"Olá {aluno.Nome} dinâmico, " +
                $"sua nota foi {aluno.Nota}");

            Console.ReadKey();
        }
    }
}
