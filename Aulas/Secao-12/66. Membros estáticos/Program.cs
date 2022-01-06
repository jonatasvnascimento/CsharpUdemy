using System;

namespace _66._Membros_estáticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa.maioridade = 18;
            Pessoa p1 = new Pessoa();
            p1.nome = "P1";
            p1.idade = 24;

            Console.WriteLine(
                $"{p1.nome}\n" +
                $"{p1.idade}" );

            
        }
    }
}
