using System;
using System.Collections.Generic;
using System.Linq;

public static class RnaTranscription
{
    private static readonly Dictionary<char, char> transcriptions =
        new Dictionary<char, char>()
        {
            { 'G', 'C' },
            { 'C', 'G' },
            { 'T', 'A' },
            { 'A', 'U' }
        };

    public static string ToRna(string nucleotide)
    {
        if (string.IsNullOrEmpty(nucleotide))
        {
            return string.Empty;
        }
        
        return new string(nucleotide.Select(dna => transcriptions[dna]).ToArray());
    }
}