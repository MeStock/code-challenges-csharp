using System;
namespace code_challenges
{
    /*
     Given five positive integers, find the minimum and maximum
     values that can be calculated by summing exactly four of the five integers.
     Then print the respective minimum and maximum values as a single
     line of two space-separated long integers.

     For example, arr = [1,3,5,7,9]. Our minimum sum is 1+3+5+7 = 16 and our maximum sum is 3+5+7+9 = 24. We would print
     16 24
     */
    public class MiniMaxSum
    {
        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine($"{sum - max} {sum - min}");
        }
    }
}
