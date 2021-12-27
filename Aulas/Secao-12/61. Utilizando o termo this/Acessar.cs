using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61._Utilizando_o_termo_this
{
    internal class Acessar
    {
        string Senha = "abc123";
        public bool Login(string paramSenha)
        {
           return this.Senha == paramSenha;
        }
    }
}
