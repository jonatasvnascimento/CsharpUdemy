using System;

namespace _80._Argumentos_do_método_main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = args[0];
            string senha = args[1];
            string senhaADM = "123";

            if (senha == senhaADM && nome == "admin")
            {
                Console.WriteLine($"Bem vindo{nome}");
            }
            else
            {
                Console.WriteLine("Senha informada invalida");
            }

        }
    }
}
