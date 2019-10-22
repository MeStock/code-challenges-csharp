using System;
using System.Collections.Generic;

namespace code_challenges
{
    /*
    We define a magic square to be an  n x x matrix of distinct positive integers from  1 to n^2 
    where the sum of any row, column, or diagonal of length n is always equal 
    to the same number: the magic constant.

    You will be given a 3x3 matrix s of integers in the inclusive range [1,9]. 
    We can convert any digit a to any other digit b in the range [1,9] at cost of |a-b|. 
    Given s, convert it into a magic square at minimal cost. Print this cost on a new line.

    Note: The resulting magic square must contain distinct integers in the inclusive range [1,9].

    For example, we start with the following matrix s:

    Input:
        5 3 4
        1 5 8
        6 4 2
    Changes to Magic Square:
        8 3 4
        1 5 9
        6 7 2
    Output: 4


    */
    public class MagicSquare
    {
        static int formingMagicSquare(int[][] s)
        {
            HashSet<int> numbersWeHaveSeen = new HashSet<int>();
            int[] requiredNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> duplicates = new List<int>();
            int numberOfChanges = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s[i].Length; j++)
                {
                    if (!numbersWeHaveSeen.Contains(s[i][j]))
                    {
                        numbersWeHaveSeen.Add(s[i][j]);
                        requiredNumbers[s[i][j] - 1] = 0;
                    }
                    else
                    {
                        duplicates.Add(s[i][j]);
                    }
                }
            }

            for (int k = 0; k < duplicates.Count; k++)
            {
                for (int l = 0; l < requiredNumbers.Length; l++)
                {
                    if (requiredNumbers[l] != 0)
                    {
                        numberOfChanges += Math.Abs(duplicates[k] - requiredNumbers[l]);
                        requiredNumbers[l] = 0;
                        break;
                    }
                }
            }
            return numberOfChanges;
        }
    }
}
