using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66._Membros_estáticos
{
    internal class Pessoa
    {
        public static int maioridade = 18;
        public string nome;
        public int idade;

        public void Apresentar()
        {
            Console.WriteLine($"Hey there: {nome}");
        }
        public static int calcularIdade(int anoNasc)
        {
            return DateTime.Now.Year - anoNasc;
        }
    }
}
