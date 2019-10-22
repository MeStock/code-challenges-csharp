using System;
namespace code_challenges
{
    /*
     * Given an array of integers, calculate the fractions of its elements
     * that are positive, negative, and are zeros. Print the decimal value
     * of each fraction on a new line.
     */

    public class PlusMinus
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            decimal numberOfPositives = 0.0m;
            decimal numberOfNegatives = 0.0m;
            decimal numberOfZeros = 0.0m;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    numberOfPositives++;
                }
                else if (arr[i] < 0)
                {
                    numberOfNegatives++;
                }
                else
                {
                    numberOfZeros++;
                }
            }
            Console.WriteLine(numberOfPositives > 0 ? (numberOfPositives / (decimal)arr.Length) : 0);
            Console.WriteLine(numberOfNegatives > 0 ? (numberOfNegatives / (decimal)arr.Length) : 0);
            Console.WriteLine(numberOfZeros > 0 ? (numberOfZeros / (decimal)arr.Length) : 0);

        }
    }
}
