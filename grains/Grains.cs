using System;

public static class Grains
{
    public static ulong Square(int n) => n > 0 && n <65 ? Convert.ToUInt64(1)<<n-1 : throw new ArgumentOutOfRangeException();
    public static ulong Total() => ulong.MaxValue;
}