using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73._Membros_sealed
{
    internal class Humano
    {
        public virtual void Olho()
        {
            Console.WriteLine("Humano.Olho");
        }
        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelo");
        }

    }
    class Pessoa : Humano
    {
        public sealed override void Olho()
        {
            Console.WriteLine("Pessoa.Olho");
        }
        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelo");
        }
    }

    class Homem : Pessoa
    {
        //public override void Olho()
        //{
        //    Console.WriteLine("Homem.Olho");
        //}
        public override void Cabelos()
        {
            Console.WriteLine("Homem.Cabelo");
        }
    }
}
