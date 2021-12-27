using System;

namespace _61._Utilizando_o_termo_this
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acessar acessar = new Acessar();
            if (acessar.Login("abc123"))
            {
                Console.WriteLine("Acesso liberado");
            }
            else
            {
                Console.WriteLine("Senha invalida");
            }
        }
    }
}
