using System;
using System.Linq;



public static class Isogram
{
    static void Main()
    {
        Isogram.IsIsogram("skiddly");
    }
    public static bool IsIsogram(string word)
    {
        word = new string(word).ToLower().Replace("_", "").Replace("-", "").Replace(" ", ""); //removes spaces/dashes/hiphens and to lower case
        char[] test = word.ToCharArray(); //string to character array
        int answer = 0;
        char[] buffer = new char[test.Length]; //created a buffer character array to compara against

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < buffer.Length; j++)
                if (buffer[j] == test[i])
                    buffer[j] = test[i];
            if (buffer.Contains(test[i])) //check if index i of original char array is in buffer char array


                answer = answer + 1; //if yes add 1 to answer
            else buffer[i] = test[i]; // if add it to buffer char array and will be comprared to the next index 
        }
        if (answer > 0) //if answer is more than 0 means there is at least one repeating character
            return false;
        else return true;


    }
}
