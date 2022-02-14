using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79._Recursividade
{
    internal class Recursiva
    {
        public void Executar(string msg, int loop)
        {
            for (int i = 0; i< loop; i++)
            {
                Console.WriteLine(msg);
            }
        }

        public void ExecutarR(string msg, int loop)
        {
            if (loop > 0)
            {
                Console.WriteLine(msg);
                Executar(msg, loop - 1);
            }
           
        }
    }
}
