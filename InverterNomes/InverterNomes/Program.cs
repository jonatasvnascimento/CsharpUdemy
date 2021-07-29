using System;

namespace InverterNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, aux;

            Console.Write("Digite o primeiro 1 nome");
            nome1 = Console.ReadLine();
            Console.Write("Digite o primeiro 2 nome");
            nome2 = Console.ReadLine();
            Console.Write("Digite o primeiro 3 nome");
            nome3 = Console.ReadLine();
            Console.Write("Digite o primeiro 4 nome");
            nome4 = Console.ReadLine();

            Console.WriteLine($"{nome1} {nome2} {nome3} {nome4}");
        }
    }
}
