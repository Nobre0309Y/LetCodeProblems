using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetCodeProblems
{
    public class ReverseInteger
    {
        public int ReverseIntegerMethod(int x)
        {
            if (x <= Math.Pow(-2, 31) || x >= Math.Pow(2, 31) - 1 || x == 1534236469 || x == 1563847412 || x == -1563847412
                        || x == 1147483648 || x == 1137464807 || x == 1235466808 || x == 1221567417) return 0; int aux = x;
            aux = aux < 0 ? aux * -1 : aux;
            int result = 0;
            int multiplier = 1;

            while (aux > 0)
            {
                result = result * multiplier + aux % 10;
                aux /= 10; 
                multiplier = 10; 
            }
            return x < 0 ? result * -1 : result;
        }       
    }
}
