using System;

namespace InverterNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2, nome3, nome4, aux;

            Console.Write("Digite o primeiro 1 nome: ");
            nome1 = Console.ReadLine();
            Console.Write("Digite o primeiro 2 nome: ");
            nome2 = Console.ReadLine();
            Console.Write("Digite o primeiro 3 nome: ");
            nome3 = Console.ReadLine();
            Console.Write("Digite o primeiro 4 nome: ");
            nome4 = Console.ReadLine();

            aux = nome1;
            nome1 = nome4;
            nome4 = aux;
            aux = nome2;
            nome2 = nome3;
            nome3 = aux;



            Console.WriteLine($"{nome1} {nome2} {nome3} {nome4}");
        }
    }
}
