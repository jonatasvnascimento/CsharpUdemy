using System;

namespace _63._Método_construtor_da_classe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();

            Console.WriteLine(
                $"{p1.nome}\n" +
                $"{p1.sobrenome}\n" +
                $"{p1.idade}\n" +
                $"{p1.anoNascimento}\n");
        }
    }
}
