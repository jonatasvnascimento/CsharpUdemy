using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71._Classes_abstratas
{
    internal class Carro : Veiculo
    {
        public int VelocidadeMaxima { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou!!!");
        }
        public override void Parar()
        {
            Console.WriteLine("Parou de acelerar");
        }

        public void LigarMotor()
        {
            Console.WriteLine("Motor ligado");
        }

    }
}
