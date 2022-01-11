using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68._Propriedades_da_classe__get___set_
{
    internal class Teste
    {
        private string _nome;
        private string _sobrenome { get; } = "Player";
        private int _idade;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int idade
        {
            get { return _idade; }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Valor menor que 18");
                }
                else
                {
                    _idade = value;
                }
            }
        }
        public void Apresentar()
        {
            if (_nome != "")
            {
                Console.WriteLine();
            }
        }
    }
}
