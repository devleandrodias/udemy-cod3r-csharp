using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Linq2
    {
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

            Aluno jorge = alunos.Single(x => x.Nome.Equals("Salve Jorge"));

            Aluno primeiraAna = alunos.FirstOrDefault(x => x.Nome.Equals("Ana"));

            Aluno ultimaAna = alunos.LastOrDefault(x => x.Nome.Equals("Ana"));

            Aluno jorgeInexistente = alunos.SingleOrDefault(x =>
                x.Nome.Equals("Salve Jorge Inexistente"));

            // O valor padrão de um objeto é null

            Console.WriteLine($"Olá {jorge.Nome}, sua nota é {jorge.Nota}");

            if (jorgeInexistente == null) Console.WriteLine("Aluno Inexistente");

            // Exemplo paginação

            IEnumerable<Aluno> puleUmPegueTres = alunos.Skip(1).Take(3);

            // Maior nota sala

            double alunoMaiorNota = alunos.Max(x => x.Nota);

            // Somar valor das notas da sala

            double somatorioNotas = alunos.Sum(x => x.Nota);

            // Descobrir média das notas da sala

            double mediaNotasTurma = alunos.Average(x => x.Nota);

            // Descobrir média das notas dos aprovados

            double mediaNotasAprovados = alunos
                .Where(x => x.Nota >= 7.0)
                .Average(x => x.Nota);

            Console.ReadKey();
        }
    }
}
