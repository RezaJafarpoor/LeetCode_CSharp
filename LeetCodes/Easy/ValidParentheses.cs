namespace LeetCodes.Easy;

public class ValidParentheses
{

    public bool IsValid(string input)
    {
        var stack = new Stack<char>();
        var dict = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };
        for (int i = 0; i < input.Length; i++)
        {
            if (dict.ContainsValue(input[i]))
            {
                stack.Push(input[i]);
            }

            else if (dict.ContainsKey(input[i]))
            {
                if (stack.Count == 0 || stack.Pop() != dict[input[i]])
                {
                    return false;
                }
            }
            
        }

        return stack.Count == 0;
    }

}