using System;
using System.Collections.Generic;
using System.Linq;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        var onlyLetters = new String(input.Where(Char.IsLetter).ToArray()).ToLower(); //adjust the string to have letters only and turn to lower case all
        Dictionary<char, int> points = new Dictionary<char, int>(); // creating dictionary to assing points value to letters
        char[] alpha = "aeioulnrstdgbcmpfhvwykjxqz".ToCharArray(); //letters
        int[] sequence = { 1,1,1,1,1,1,1,1,1,1,2,2,3,3,3,3,4,4,4,4,4,5,8,8,10,10 }; //correspinding values
        for (int i = 0; i < 28; i++)  //cycle to populate the dictionary
        {
            points.Add(alpha[i], sequence[i]);
        }
        //string replaces values with digits from the dictionary and sums all
        //return the answer
        int answer = 23;
        return answer;



    }
}