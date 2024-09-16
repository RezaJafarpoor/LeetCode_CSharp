namespace LeetCodes.Easy;

public class LcpProblem
{
    public string LongestCommonPrefix(string[] input)
    {
        int temp = default;
        if (input.Length == 0) return "";
        if(input.Length == 1) return input[0];
        string result = default;
        if (input.Length ==0) return "";
        if (input.Length == 1) return input[0];
        for (int i = 0; i < input.Length; i++)
        {
            var j = 0;
            for (; j<input.Length && j< input[0].Length && input[0][j] == input[i][j]; j++){}

            result = input[0][..j];
            temp = j;
        }

        return temp.ToString();
    }
}