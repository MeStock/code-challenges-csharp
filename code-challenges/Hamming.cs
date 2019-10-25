using System;
namespace code_challenges
{
    public class Hamming
    {
        public static int Distance(string firstStrand, string secondStrand)
        {
            int distance = 0;
            if (firstStrand.Length != secondStrand.Length) throw new ArgumentException();
            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i])
                {
                    distance++;
                }
            }
            return distance;
        }
    }
}
