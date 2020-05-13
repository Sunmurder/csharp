using System;
using System.Globalization;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        DateTime newTime = moment.AddSeconds(1e9);
        return newTime;
    }
}