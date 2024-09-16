// ReSharper disable All
namespace LeetCodes.Easy;

public class TwoSumProblem
{

    public int[] TwoSum(int[] input, int target)
    {
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input.Length; j++)
            {
                if (i == j)
                {
                     continue;
                }
                if (input[i] + input[j] == target)
                {
                    return new [] { i, j };
                }
            }
        }

        return [];
    }
}