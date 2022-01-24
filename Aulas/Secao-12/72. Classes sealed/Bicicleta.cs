using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72._Classes_sealed
{
    sealed internal class Bicicleta : Veiculo
    {
        public override void Acelerar()
        {
            throw new NotImplementedException();
        }
        public override void Parar()
        {
            throw new NotImplementedException();
        }
    }
}
