using System;

namespace CursoCSharp.ClassesMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada;

        public Moto()
        {

        }

        public Moto(string marca, string modelo, int cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public string GetMarca() => Marca;

        public void SetMarca(string marca) => Marca = marca;

        public string GetModelo() => Modelo;

        public void SetModelo(string modelo) => Modelo = modelo;

        public uint GetCilindrada() => Cilindrada;

        public void SetCilindrada(uint cilindrada) => Cilindrada = cilindrada;
    }

    // uint = inteiro sem sinal (Apenas positivo)

    public class GetSet
    {
        public static void Executar()
        {
            Moto moto1 = new Moto(marca: "Kawasaki", modelo: "Ninja ZX-6R",
                cilindrada: 636);

            Moto moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(19);

            Console.WriteLine($"Moto: {moto1.GetModelo()}, da marca " +
                $"{moto1.GetMarca()}, tem cilindradra de " +
                $"{moto1.GetCilindrada()}");

            Console.WriteLine($"Moto: {moto2.GetModelo()}, da marca " +
                $"{moto2.GetMarca()}, tem cilindradra de " +
                $"{moto2.GetCilindrada()}");

            Console.ReadKey();
        }
    }
}
