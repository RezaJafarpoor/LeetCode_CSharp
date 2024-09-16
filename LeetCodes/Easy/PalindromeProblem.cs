namespace LeetCodes.Easy;

public class PalindromeProblem
{
    public bool IsPalindrome(int s)
    {
        int copy = s; 
        int result = default;
        if (s < 0) return false;
        while (copy != 0)
        {
            result = 10*result + copy % 10;
            copy = copy / 10;
        }

        return result == s;
    }
}