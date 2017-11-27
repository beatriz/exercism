using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var stringArray = input.ToCharArray();
        Array.Reverse(stringArray);
        return new string(stringArray);
    }
}