using System;
using System.Runtime.InteropServices.WindowsRuntime;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        int answer = 0;
        for (int i = 1; i < number; i++)
        {
            if (number <= 0)
                throw new System.ArgumentOutOfRangeException();
            else if (number % i == 0)
                answer += i;
           

        }
                if (answer == number)
                    return Classification.Perfect;
                else if (answer > number)
                    return Classification.Abundant;
                else if (answer < number)
                    return Classification.Deficient;
           

        return Classification.Deficient;
    }
}





