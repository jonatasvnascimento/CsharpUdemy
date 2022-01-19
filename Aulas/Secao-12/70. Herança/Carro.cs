using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70._Herança
{
    internal class Carro: Veiculo
    {
        public int VelocidadeMaxima { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("Motor ligado");
        }
       
    }
}
