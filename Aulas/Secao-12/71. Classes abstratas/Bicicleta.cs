using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71._Classes_abstratas
{
    internal class Bicicleta : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Pedalou");
        }
        public override void Parar()
        {
            Console.WriteLine("Parou de pedalar");
        }
    }
}
