using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63._Método_construtor_da_classe
{
    internal class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;
        public int anoNascimento;

        public Pessoa()
        {
            nome = "Vazio";
            sobrenome = "Vazio";
            idade = 0;
            anoNascimento = 0;
        }

    }
}
