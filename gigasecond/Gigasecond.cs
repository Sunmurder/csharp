using System;
using System.Globalization;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        DateTime newTime = moment.AddSeconds(Math.Pow(10,9));
        return newTime;
    }
}