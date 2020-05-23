using System;
using Xunit.Sdk;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException();
        int opsIncremental = 0;
        while (number != 1)
            if (number % 2 == 0)
            {
                number = number / 2;
                opsIncremental++;
            }
            else if (number % 2 != 0)
            {
                number = (number*3) + 1;
                opsIncremental++;
            }
        return opsIncremental;

    }
}