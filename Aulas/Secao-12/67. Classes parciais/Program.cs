using System;

namespace _67._Classes_parciais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa.maioridade = 24;
            Pessoa p1 = new Pessoa();
            p1.nome = "Player";
            p1.idade = 18;
            Console.WriteLine(
                $"{Pessoa.CalcularIdade(1950)}" +
                $"{p1.idade}" +
                $"{p1.nome}");
        }
    }
}
