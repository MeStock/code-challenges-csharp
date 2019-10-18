using System;
using System.Collections.Generic;

namespace code_challenges
{
    /*
    Given a square matrix, calculate the absolute difference between the sums of its diagonals.

    For example, the square matrix  is shown below:

    1 2 3
    4 5 6
    9 8 9  
    The left-to-right diagonal 1 + 5 + 9 = 15.
    The right to left diagonal 3 + 5 + 9 = 17.
    Their absolute difference is |15 - 17| = 2.

    */

    public class DiagonalDifference
    {
        public static int CalculateDiagonalDifference(List<List<int>> arr)
        {
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr.Count; j++)
                {
                    if ((i + j) == (arr.Count - 1) && i == j)
                    {
                        primaryDiagonalSum += arr[i][j];
                        secondaryDiagonalSum += arr[i][j];
                    }
                    else if (i == j)
                    {
                        primaryDiagonalSum += arr[i][j];
                    }
                    else if ((i + j) == (arr.Count - 1))
                    {
                        secondaryDiagonalSum += arr[i][j];
                    }
                }
            }
            int absoluteDifference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
            return absoluteDifference;
        }
    }
}
