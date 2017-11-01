using System;
using System.Collections.Generic;
using System.Linq;

public class NucleotideCount
{
    private IDictionary<char, int> count;
    public NucleotideCount(string sequence)
    {
        if (sequence.Count(x => x != 'A' && x != 'C' && x != 'G' && x != 'T') > 0)
        {
            throw new InvalidNucleotideException();
        }
        
        count = new Dictionary<char, int>{
            { 'A', sequence.Count(x => x == 'A') },
            { 'C', sequence.Count(x => x == 'C') },
            { 'G', sequence.Count(x => x == 'G') },
            { 'T', sequence.Count(x => x == 'T') },
        };
    }

    public IDictionary<char, int> NucleotideCounts
    {
        get
        {
            return count;
        }
    }
}

public class InvalidNucleotideException : Exception { }
