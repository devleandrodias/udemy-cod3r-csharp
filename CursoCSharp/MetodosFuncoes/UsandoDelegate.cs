using System;

namespace CursoCSharp.MetodosFuncoes
{
    public class UsandoDelegate
    {
        delegate double Soma(double x, double y);

        delegate void ImprimirSoma(double x, double y);

        static double MinhaSoma(double a, double b) => a + b;

        static void ImprimirMinhaSoma(double a, double b) =>
            Console.WriteLine(MinhaSoma(a, b));
        
        public static void Executar()
        {
            Soma p1 = MinhaSoma;

            Console.WriteLine(p1(10, 5));

            ImprimirSoma op2 = ImprimirMinhaSoma;

            op2(35.28934723, 15.23452345);

            Func<double, double, double> op3 = MinhaSoma;

            Console.WriteLine(op3(123.5, 123.5));

            Action<double, double> op4 = ImprimirMinhaSoma;

            op4(12.5, 12.5);

            Console.ReadKey();
        }
    }
}
