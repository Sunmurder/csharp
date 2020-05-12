using System;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

public static class RnaTranscription
{
    public static string ToRna(string nucleotide)
    {
        char[] nucleotide_Given = nucleotide.ToCharArray();
        string answer = String.Empty;
        for (int i = 0; i < nucleotide.Length; i++)
        {
            if (nucleotide_Given[i] == 'G')
                answer = answer + "C";
            else if (nucleotide_Given[i] == 'C')
                answer = answer + "G";
            else if (nucleotide_Given[i] == 'T')
                answer = answer + "A";
            else if (nucleotide_Given[i] == 'A')
                answer = answer + "U";
            else throw new System.ArgumentException("Provide correct nucleotide");
        }
        return answer;

      
    }
}