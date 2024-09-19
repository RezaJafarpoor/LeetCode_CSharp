namespace LeetCodes.Easy;

public class LcpProblem
{
    public string LongestCommonPrefix(string[] input)
    {
        string lcp = "";

        for (int i = 0; i < input[0].Length; i++)
        {
            for (int j = 0; j < input.Length; j++)
            {
                if (i >= input[j].Length || input[0][i] != input[j][i])
                {
                    return lcp;
                }
            }
            lcp += input[0][i];
            
        }
        return lcp ;

    }
}