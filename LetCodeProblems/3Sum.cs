using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetCodeProblems
{
    public class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            for (int fixo = 0; fixo < nums.Length; fixo ++)
            {
                for (int j = 0; j < nums.Length; j ++)
                {
                    if (j == fixo)
                    {
                        if (j + 1 == nums.Length) break;
                        j++;
                    }
                    for (int k = 0; k < nums.Length; k ++)
                    {
                            if (nums[j] + nums[k] + nums[fixo] == 0 && j != k && j != fixo && fixo != k)
                        {
                            var temp = new List<int>() { nums[j], nums[k], nums[fixo] };
                            if (!result.Any(list => list.SequenceEqual(temp)))
                            {
                                result.Add(temp);
                            }

                        }
                    }
                }
            }

            return result;
        }
    }
}
