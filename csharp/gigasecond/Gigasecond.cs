using System;

public static class Gigasecond
{
    private const long giga = 1000000000;
    public static DateTime Add(DateTime birthDate)
    {
        return birthDate.AddSeconds(giga);
    }
}