using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62._Delegates
{
    internal class Matematica
    {
        public void somar(int v1, int v2)
        {
            int soma = v1 + v2;
            Console.WriteLine($"A soma de {v1} + {v2} = {soma}");
        }
        public void subitrair(int v1, int v2)
        {
            int sub = v1 - v2;
            Console.WriteLine($"A subtração de {v1} - {v2} = {sub}");
        }
        public void multiplicar(int v1, int v2)
        {
            int mult = v1 * v2;
            Console.WriteLine($"A soma de {v1} * {v2} = {mult}");
        }
        public void dividir(int v1, int v2)
        {
            int div = v1 / v2;
            Console.WriteLine($"A subtração de {v1} / {v2} = {div}");
        }
    }
}
