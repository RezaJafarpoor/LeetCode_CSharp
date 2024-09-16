namespace LeetCodes.Easy;

public class RomanToIntegerProblem
{
    public int RomanToInteger(string s)
    {
        int result = default;
        for (int i = 0; i < s.Length ; i++)
        {
            result += romanTranslator(s[i]);
            if (i is not 0)
            {
                if (romanTranslator(s[i]) > romanTranslator(s[i - 1]))
                {
                    result -= 2 * romanTranslator(s[i-1]);
                }   
            }
        }

        return result;
    }


    private int romanTranslator(char s)
    {
        return s switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0
        };
    }
}