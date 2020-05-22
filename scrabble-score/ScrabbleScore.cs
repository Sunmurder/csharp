using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        var onlyLetters = new String(input.Where(Char.IsLetter).ToArray()).ToLower(); //adjust the string to have letters only and turn to lower case all
        Dictionary<char, int> points = new Dictionary<char, int>(); // creating dictionary to assing points value to letters
        char[] alpha = "aeioulnrstdgbcmpfhvwykjxqz".ToCharArray(); //letters
        int[] sequence = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 5, 8, 8, 10, 10 }; //correspinding values
        for (int i = 0; i < 26; i++)  //cycle to populate the dictionary
        {
            points.Add(alpha[i], sequence[i]);
        }
        char[] answer = points.Aggregate(onlyLetters, (result, s) => result.Replace(s.Key, (char)s.Value)).ToCharArray(); // replaces keys in string with its values turns to char array
        int result = 0;
        for (int i = 0; i < answer.Length; i++) //cycle to add all digits
        {
            result = result + Convert.ToInt32(answer[i]);
        }
        return result; //return result
    }
}