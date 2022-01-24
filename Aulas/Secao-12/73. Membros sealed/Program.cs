using System;

namespace _73._Membros_sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humano humano = new Humano();
            Pessoa pessoa = new Pessoa();
            Homem homem = new Homem();

            humano.Olho();
            humano.Cabelos();
            pessoa.Olho();
            pessoa.Cabelos();
            homem.Olho();
            homem.Cabelos();

        }
    }
}
