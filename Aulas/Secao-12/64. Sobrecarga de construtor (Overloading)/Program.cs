using System;

namespace _64._Sobrecarga_de_construtor__Overloading_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p2 = new Pessoa("Player","02",1900,0);
            Console.WriteLine(
                $"nome:..........{p2.nome}\n" +
                $"sobrenome:.....{p2.sobrenome}\n" +
                $"idade:.........{p2.idade}\n" +
                $"anoNascimento: {p2.anoNascimento}");
        }
    }
}
