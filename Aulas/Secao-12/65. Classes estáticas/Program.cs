using System;

namespace _65._Classes_estáticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematica.taxa = 10;
            int valor = Matematica.Adicionar(10);
            int valor2 = Matematica.Diminuir(10);
            Console.WriteLine(
                $"{valor2}\n" +
                $"{valor}");
        }
    }
}
