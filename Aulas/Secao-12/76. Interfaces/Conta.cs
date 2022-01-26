using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _76._Interfaces
{
    internal class CaixaEletronico : IConta
    {
        public string Usuatio { get; set; }

        public void Depositar()
        {
        }

        public void Sacar()
        {
        }

        public void Saldo()
        {
        }

        public void SolicitarInprestimo()
        {
        }
    }

    interface IConta
    {
        string Usuatio { get; set; }
        void Depositar();
        void Sacar();
        void Saldo();
    }
}
