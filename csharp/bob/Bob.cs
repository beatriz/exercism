using System;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string question)
    {
        if (string.IsNullOrWhiteSpace(question))
        {
            return "Fine. Be that way!";
        }
        if (IsAllUpper(question))
        {
            return "Whoa, chill out!";
        }
        if (question.TrimEnd().EndsWith("?"))
        {
            return "Sure.";
        }

        return "Whatever.";
    }

    private static bool IsAllUpper(string input)
    {
        if (!HasLetters(input))
        {
            return false;
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (Char.IsLetter(input[i]) && !Char.IsUpper(input[i]))
                return false;
        }
        return true;
    }

    private static bool HasLetters(string input)
    {
        return Regex.Matches(input, @"[a-zA-Z]").Count > 0;
    }
}