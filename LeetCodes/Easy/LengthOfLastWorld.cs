namespace LeetCodes.Easy;

public class LengthOfLastWorld
{
    public int lengthOfLastWorld(string input)
    {
        int start = 0;
        string lastWord = " ";
        int end = 0;
        for (int i = 0; i < input.Length; i++)
        {
            end = i;
            if (input[i] == ' ' )
            {
                
                var temp = input[start .. end];
                start = end;
                if (temp != " ")
                {
                    lastWord = temp;
                }
            }
        }
        
        Console.WriteLine(lastWord);

        return lastWord.Length;
    }
}