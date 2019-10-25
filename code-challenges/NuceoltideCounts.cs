using System;
using System.Collections.Generic;

namespace code_challenges
{
    public class NuceoltideCounts
    {
        public static Dictionary<char, int> Count(string sequence)
        {
            Dictionary<char, int> nucleotideCount = new Dictionary<char, int>();
            nucleotideCount.Add('A', 0);
            nucleotideCount.Add('C', 0);
            nucleotideCount.Add('G', 0);
            nucleotideCount.Add('T', 0);
            for (int i = 0; i < sequence.Length; i++)
            {
                if (!nucleotideCount.ContainsKey(sequence[i])) throw new ArgumentException();
                nucleotideCount[sequence[i]]++;
            }
            return nucleotideCount;
        }
    }
}
