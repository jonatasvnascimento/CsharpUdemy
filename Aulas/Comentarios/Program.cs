using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        enum dia
        {
            segunda, terça
        }
        struct pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }
        static void Main(string[] args)
        {
            #region struct objetc

            pessoa p1 = new pessoa()
            {
                nome = "Morgan Freman",
                idade = 52,
                altura = 1.96,
            };
            #endregion

            Console.WriteLine(p1.idade);
            Console.ReadKey();
        }
    }
}
