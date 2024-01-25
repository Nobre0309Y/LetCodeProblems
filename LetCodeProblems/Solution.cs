public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {


        for (var fixoDaSoma = 0; fixoDaSoma < nums.Count(); fixoDaSoma++)
        {
            var aux = 0;
            while (aux < nums.Count())
            {
                if (nums[fixoDaSoma] + nums[aux] == target && fixoDaSoma != aux)
                {
                    return new int[2] { fixoDaSoma, aux };
                }
                aux++;
            }
        }

        return null;
    }
}