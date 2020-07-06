using System;
using System.IO;

namespace CursoCSharp.API
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home =
                (
                    Environment.OSVersion.Platform == PlatformID.Unix ||
                    Environment.OSVersion.Platform == PlatformID.MacOSX
                ) ? Environment.GetEnvironmentVariable("HOME")
                  : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%HOMEPATH%");

            return path.Replace("~", home);
        }
    }

    public class PrimeiroArquivo
    {
        public static void Executar()
        {
            Console.WriteLine("\teste\nestjs\a.txt");
            Console.WriteLine(@"\teste\nestjs\a.txt");

            string path = @"~/primeiro_arquivo.txt".ParseHome();

            Console.WriteLine(path);

            if (!File.Exists(path))
            {
                /*
                 * Using faz com que o C# aloque recursos do sistema operacional
                 * e feche eles assim que código sair do método
                 */

                using StreamWriter sw = File.CreateText(path);

                sw.WriteLine("Esse é");
                sw.WriteLine("o nosso");
                sw.WriteLine("primeiro arquivo");
            }


            Console.ReadKey();
        }
    }
}
