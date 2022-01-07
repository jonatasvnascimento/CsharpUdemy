using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67._Classes_parciais
{
    partial class Pessoa
    {
        public void Apresentar()
        {
            Console.WriteLine($"Ola eu sou:{nome}");
        }
        public static int CalcularIdade(int anoNasc)
        {
            return DateTime.Now.Year - anoNasc;
        }
    }
}
