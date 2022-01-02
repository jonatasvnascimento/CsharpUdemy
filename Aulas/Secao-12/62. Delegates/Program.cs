using System;

namespace _62._Delegates
{
    internal class Program
    {
        delegate void Operacao(int n1, int n2);
        static void Main(string[] args)
        {
            Matematica modulo = new Matematica();
            Operacao operacao = null;

            operacao += modulo.somar;
            operacao += modulo.subitrair;
            operacao += modulo.dividir;
            operacao += modulo.multiplicar;

            operacao(2, 2);
            
            operacao -= modulo.multiplicar;
            operacao(2, 2);




        }
    }
}
