using System;

namespace CursoCSharp.MetodosFuncoes
{
    public class ExemploLambda
    {
        public static void Executar()
        {
            /*
             * Lambda no C# é uma função anônima e essa função 
             * é armazenada dentro de uma váriavel algoNoConsole (Action)
             * Action á uma função que não tem retorno (void)
             * Func obrigatoriamente tem um retorno
             */

            Action algoNoConsole = () => Console.WriteLine("Utilizando lambda no C#");

            algoNoConsole();

            // Só um parâmetro siguinifica que é o retorno da função

            Func<int> jogarDado = () => new Random().Next(1, 7);

            Console.WriteLine($"Jogar dado... Valor {jogarDado()} ");

            /*
             * Mais de um parâmetro o último é o retorno da função e primeiros
             * são os parâmetros da função
             */

            Func<int, string> conversorHex = numero => numero.ToString("X");

            Console.WriteLine(conversorHex(140023));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            DateTime dataAtual = DateTime.Now;

            Console.WriteLine(formatarData(dataAtual.Day, dataAtual.Month,
                dataAtual.Year));

            Console.WriteLine(formatarData(1, 5, 2010));

            Console.ReadKey();
        }
    }
}
