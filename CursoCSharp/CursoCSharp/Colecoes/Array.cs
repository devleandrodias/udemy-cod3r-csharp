using System;

namespace CursoCSharp.Colecoes
{
    public class Array
    {
        public static void Executar()
        {
            /*
             * Array é uma estrutura homogênea
             * Array é uma estrutura estática (Ela não cresce)
             * Array é uma estrutura indexada apartir do 0
             */
            string[] alunos = new string[5];
            string []pessoas = new string[2]; // Esse também é um padrão válido

            Console.WriteLine(pessoas);

            alunos[0] = "Leandro";
            alunos[1] = "Thaísa";
            alunos[2] = "Beatriz";
            alunos[3] = "Carlos";
            alunos[4] = "Manuel";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;

            double[] notas = { 10.0, 3.4, 2.5, 6.2, 6.2, 7.0 };

            // Usando Foreach

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            // Usando For

            for (int i = 0; i < notas.Length; i++)
            {
                somatorio += notas[i];
            }   

            Console.WriteLine("Média das notas: {0}", somatorio / notas.Length);

            char[] arrayCaracteres = { 'A', 'r', 'r', 'a', 'y' };

            var palavra = new string(arrayCaracteres);

            Console.WriteLine($"Palavra: {palavra}");

            Console.ReadKey();
        }
    }
}
