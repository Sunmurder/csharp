using System;


public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string str = phrase.ToUpper();
        string str1 = str.Replace("_", " ").Replace("-", " ");
        string[] strSplit = str1.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        string answer = "";
             for (int i = 0; i < strSplit.Length; i++)
        {
            answer = answer + strSplit[i].Substring(0, 1);
        }
             return answer;
    }
}