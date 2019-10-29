using System;
using System.Collections.Generic;

namespace code_challenges
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            if (nucleotide.Length < 1) return nucleotide;
            char[] result = nucleotide.ToCharArray();
            Dictionary<char, char> translator = new Dictionary<char, char>();
            translator.Add('G', 'C');
            translator.Add('C', 'G');
            translator.Add('T', 'A');
            translator.Add('A', 'U');
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = translator[result[i]];
            }

            return new string(result);
        }
    }
}
