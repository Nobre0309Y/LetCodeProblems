using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetCodeProblems
{
    public class IsPalindrome
    {
        public bool IsPalindromeMethod(int x)
        {
            int aux = x;
            int result = 0;
            int counter = 1;

            while(aux > 0)
            {
                result = result * counter + aux % 10;
                aux /= 10;
                counter = 10;
            }
            return result == x? true : false;
        }
    }
}
