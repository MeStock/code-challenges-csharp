using System;
using System.Collections.Generic;

namespace code_challenges
{

 /*
 Alice and Bob each created one problem for HakerRank. A reviewer rates the two
 challenges, awarding points on a scale from  to  for three categories: problem
 clarity, originality, and difficulty.

We define the rating for Alice's challenge to be the triplet , and the rating
for Bob's challenge to be the triplet .

Your task is to find their comparison points by comparing  with ,  with , and  with .

If , then Alice is awarded  point.
If , then Bob is awarded  point.
If , then neither person receives a point.
Comparison points is the total points a person earned.

Given  and , determine their respective comparison points.

For example,  and . For elements , Bob is awarded a point because .
For the equal elements  and , no points are earned. Finally, for elements ,  so
Alice receives a point. Your return array would be  with Alice's score first
and Bob's second.
Sample Input 0

5 6 7
3 6 10
Sample Output 0

1 1


 */
    public class CompareTriplets
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> compareResults = new List<int>();
            int aScore = 0;
            int bScore = 0;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    aScore++;
                }
                else if (a[i] < b[i])
                {
                    bScore++;
                }
            }
            compareResults.Add(aScore);
            compareResults.Add(bScore);
            return compareResults;
        }
    }
}
