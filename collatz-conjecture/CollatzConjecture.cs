using System;
using Xunit.Sdk;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0)
            throw new ArgumentOutOfRangeException(); // check the number for being more than zero
        else if (number) // if even delete by two, check result. i++ for every transaction

    }
}