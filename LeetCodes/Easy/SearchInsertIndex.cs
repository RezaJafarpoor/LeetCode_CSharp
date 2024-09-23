using System.Reflection.Metadata.Ecma335;

namespace LeetCodes.Easy;

public class SearchInsertIndex
{

    public int SearchInsert(int[] nums, int target)
    {
        int start = 0;
        int end = nums.Length - 1;
        int middle = -1;
        while (start <= end)
        {
             middle = start + (end - start) / 2;

            

            if (nums[middle] > target)
            {
                end = middle - 1;
            }

            else if (nums[middle]<target)
            {
                start = middle + 1;
            }
            else
            {
                return middle;
            }
        }

        return start;
    }

}