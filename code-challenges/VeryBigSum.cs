using System;
namespace code_challenges
{
    /*
    Calculate and print the sum of the elements in an array,
    keeping in mind that some of those integers may be quite large.


    Sample Input

    5
    1000000001 1000000002 1000000003 1000000004 1000000005
    Output

    5000000015
    */

    public class VeryBigSum
    {
        static long AVeryBigSum(long[] ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
