namespace LeetCodes.Easy;

public class ValidParentheses
{
    public bool IsValid(string input)
    {
        var stack = new Stack<char>();
        for (int i = input.Length -1; i >= 0; i--)
        {
            if (
                input[i] =='(' && stack.Peek()==')'
                || input[i] =='{' && stack.Peek() == '}'
                || input[i] =='[' && stack.Peek() == ']'
                )
            {
                stack.Pop();
            }
            else
            {
                stack.Push(input[i]);
            }
        }
        
        if (stack.Count == 0)
        {
            return true;
        }
        return false;



    }
}