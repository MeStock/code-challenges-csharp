using System;
using System.Collections.Generic;

namespace code_challenges
{
    public static class Series
    {
        public static string[] Slices(string numbers, int sliceLength)
        {
            if (numbers.Length < 1 || sliceLength < 1 || sliceLength > numbers.Length) throw new ArgumentException();
            List<string> result = new List<string>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i + sliceLength > numbers.Length) break;
                result.Add(numbers.Substring(i, sliceLength));
            }
            return result.ToArray();
        }
    }
}
