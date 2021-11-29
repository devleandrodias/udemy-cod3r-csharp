using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {

        public string Nome;
        public int Idade;
        public double Nota;

        public Aluno(string nome, int idade, double nota)
        {
            Nome = nome;
            Idade = idade;
            Nota = nota;
        }
    }

    public class Linq1
    {
        /*
         * LINQ: Language Integreted Query
         * Linguagem de Consulta Integrada
         */


        public static void Executar()
        {
            List<Aluno> alunos = new List<Aluno>() {
                new Aluno("Leandro Dias", 19, 10.0){ },
                new Aluno("André Guedes", 21, 4.3){ },
                new Aluno("Ana Beatriz", 20, 6.4){ },
                new Aluno("Salve Jorge", 21, 9.3){ },
                new Aluno("Ana Júlia", 18, 2.0){ },
                new Aluno("Ana Beatriz", 42, 6.3){ },
                new Aluno("Ana Júlia", 12, 7.0){ },
                new Aluno("Márcio Perereia", 47, 4.4){ },
            };

            string firulas = "=*=*=*=*=*=*=";

            Console.WriteLine($"{firulas} APROVADOS {firulas}\n");

            // Filter

            IEnumerable<Aluno> aprovados = alunos
                .Where(x => x.Nota >= 7.0)
                .OrderBy(x => x.Nome);

            // Mapping

            IEnumerable<string> reprovados = alunos
                .Where(x => x.Nota < 7.0)
                .OrderBy(x => x.Nota)
                .Select(x => x.Nome);

            foreach (Aluno aluno in aprovados)
            {
                Console.WriteLine($"Aprovado: {aluno.Nome}! Nota {aluno.Nota}");
            }

            Console.WriteLine("");

            foreach (string aluno in reprovados)
            {
                Console.WriteLine($"Reprovado: {aluno}...");
            }

            // LINQ em formato parecido com SQL

            IEnumerable<string> listaChamadaPorIdade =
                from aluno in alunos
                where aluno.Idade >= 18
                orderby aluno.Idade
                select aluno.Nome;

            Console.WriteLine($"\n{firulas} LISTA CHAMADA {firulas}\n");

            int aux = 1;

            foreach (string aluno in listaChamadaPorIdade)
            {
                Console.WriteLine($"{aux}) - {aluno}");
                aux++;
            }

            Console.ReadKey();
        }
    }
}
