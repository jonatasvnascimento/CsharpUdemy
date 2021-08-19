using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

        inicio:

            Console.Write("Operador: ");
            string opreacao = Console.ReadLine();
            string result = "";

            if (opreacao == "+" ||
                opreacao == "*" ||
                opreacao == "/" ||
                opreacao == "-")
            {
                result = opreacao;
            }
            else
            {
                goto inicio;
            }

            Console.Write("Informe o primeiro numero: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.Write("Informe o segundo numero: ");
            int v2 = int.Parse(Console.ReadLine());
            int soma = v1 + v2;

            if (result == "+")
            {
                int mais = v1 + v2;
                Console.WriteLine($"{mais}");

                if (mais % 2 == 0)
                {
                    Console.Write("Numero e par");
                }
                else
                {
                    Console.WriteLine("Numero não e par");
                }
            }
            else if (result == "-")
            {
                int menos = v1 - v2;
                Console.WriteLine($"{menos}");

                string veric = menos % 2 == 0 ? "Par" : "Impar";

                Console.WriteLine($"{veric}");

            }
            else if (result == "*")
            {
                int multiplic = v1 * v2;
                Console.WriteLine($"{multiplic}");
                string veric = multiplic % 2 == 0 ? "Par" : "Impar";
                Console.WriteLine($"{veric}");

            }
            else if (result == "/")
            {
                Console.WriteLine($"{v1 / v2}");
            }

            Console.Write("Deseja continuar: [s/n] ");
            string resp = Console.ReadLine();

            if (resp == "S" || resp == "s")
            {
                goto inicio;
            }

        }
    }
}
