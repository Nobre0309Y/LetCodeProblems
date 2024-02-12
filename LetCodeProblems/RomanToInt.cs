using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LetCodeProblems
{
    public class RomanToInt
    {

        public int RomanToIntMethod(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i] == 'I')
                {
                    if (i == s.Length - 1)
                    {
                        result++;
                        break;
                    }
                    else if (s[i + 1] == 'V')
                    {
                        result += 4;
                        i++;
                    }
                    else if (s[i + 1] == 'X')
                    {
                        result += 9;
                        i++;
                    }
                    else result += 1;
                }



                else if (s[i] == 'V') result += 5;




                else if (s[i] == 'X')
                {
                    if (i == s.Length - 1)
                    {
                        result += 10;
                        break;
                    }
                    else if (s[i + 1] == 'L')
                    {
                        result += 40;
                        i++;
                    }
                    else if (s[i + 1] == 'C')
                    {
                        result += 90;
                        i++;
                    }
                    else result += 10;
                }



                else if (s[i] == 'L') result += 50;



                else if (s[i] == 'C')
                {
                    if (i == s.Length - 1)
                    {
                        result += 100;
                        break;
                    }
                    else if (s[i + 1] == 'D')
                    {
                        result += 400;
                        i++;
                    }
                    else if (s[i + 1] == 'M')
                    {
                        result += 900;
                        i++;
                    }
                    else result += 100;
                }



                else if (s[i] == 'D') result += 500;




                else if (s[i] == 'M') result += 1000;
               
            }
            return result;
        }
        
    }
}

