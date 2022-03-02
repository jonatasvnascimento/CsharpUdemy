using System;

namespace _81_FatorialRecursividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fatorial: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Fatorial de {num}! = {fat(num)}");

           static int fat(int num)
            {
                if (num <= 0)
                {
                    return 1;
                }
                return num * fat(num - 1);
            }
        }
    }
}
