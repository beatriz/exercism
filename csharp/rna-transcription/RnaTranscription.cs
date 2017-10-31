using System;
using System.Collections.Generic;

public static class RnaTranscription
{
    private static Dictionary<char, string> DnaToRna = new Dictionary<char, string>
    {
        { 'G', "C" },
        { 'C', "G" },
        { 'T', "A" },
        { 'A', "U" }
    };

    public static string ToRna(string nucleotide)
    {
        var rna = string.Empty;
        foreach (var nucleotid in nucleotide)
        {
            if (!DnaToRna.ContainsKey(nucleotid))
            {
                throw new ArgumentException();
            }
            rna = string.Concat(rna, DnaToRna[nucleotid]);
        }

        return rna;
    }
}