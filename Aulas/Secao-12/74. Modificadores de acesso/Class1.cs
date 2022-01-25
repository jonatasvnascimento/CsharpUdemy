using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _74._Modificadores_de_acesso
{
    internal class Teste
    {
        private string nome;
        public string sobrenome;

        private void Metodo1() { }
        public void Executar() { }
    }
    class Humano
    {
        protected string nome;
        private string sobrenome;
        internal int idade;
    }
    class Homem : Humano
    {
        public void Executar() {
            nome = "";
        }
    }
}
