using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64._Sobrecarga_de_construtor__Overloading_
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
            anoNascimento = 0;
            idade = 0;
        }
        public Pessoa(string _nome, string _sobrenome)
        {
            this.nome = _nome;
            this.sobrenome= _sobrenome;
            anoNascimento = 0;
            idade = 0;
        }
        public Pessoa(string _nome, string _sobrenome, int _anoNascimento, int _idade)
        {
            this.nome = _nome;
            this.sobrenome= _sobrenome;
            this.anoNascimento = _anoNascimento;
            this.idade = Idade();
        }
        private int Idade()
        {
            return 2022 - anoNascimento;
        }
    }
}
