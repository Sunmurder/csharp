using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string sentenceCount = "";
        string inputLower = input.ToLower(); 
        char[] count = inputLower.ToCharArray(); //recorded in Dec ASCII
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] >= 97 && count[i]<=122)
                {
                if(!sentenceCount.Contains(count[i].ToString())) 
                  {
                    sentenceCount = sentenceCount + count[i].ToString();
                  }
                }
        }
        return sentenceCount.Length == 26;

    }
}
