using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class ultils
    {
        public static bool isNumeric(string numbers)
        {
            bool isnumeric = false;
            char[] chars = numbers.ToCharArray();
            foreach (var number in numbers)
            {
                isnumeric = isnumeric ? char.IsDigit(number) : isnumeric;
            }
            return isnumeric;
        }
    }
}
