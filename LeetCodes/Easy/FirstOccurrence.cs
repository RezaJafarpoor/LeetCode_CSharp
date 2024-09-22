namespace LeetCodes.Easy;

public class FirstOccurrence
{
    public int StrStr(string haystack, string needle)
    {
        int counter = 0;
        int i = 0;
        int j = 0;

        while (counter + needle.Length <= haystack.Length)
        {
            if (needle[i] == haystack[j])
            {
                i++;
                j++;
            }
            else
            {
                i = 0;
                counter++;
                j = counter;
            }

            if (i > needle.Length -1 )
            {
                // Console.WriteLine(counter);
                return counter;
            }

        }

        return -1;
    }
}