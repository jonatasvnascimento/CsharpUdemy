using System;

namespace _69._Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.Cliente = "Jonnes";

            double valorDeposit = 100;
            c.Depositar(valorDeposit);

            double valorSacar = 100;
            c.Sacar(valorSacar);

            Console.WriteLine(
                $"Cliente:{c.Cliente}\n" +
                $"Saldo:..{c.Saldo}");
        }
    }
}
