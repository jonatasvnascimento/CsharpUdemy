using System;

namespace _68._Propriedades_da_classe__get___set_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            t.Nome = "Angimundoi";
            t.idade = 20;

            Console.WriteLine($"{t.Nome}" +
                $"{t.idade}");
        }
    }
}
