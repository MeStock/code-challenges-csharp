using System;
namespace code_challenges
{
    public class Staircase
    {
        static void staircase(int n)
        {
            for (int row = 0; row < n; row++)
            {
                for (int spaces = n - row - 1; spaces > 0; spaces--)
                {
                    Console.Write(' ');
                }
                for (int hashtags = 0; hashtags <= row; hashtags++)
                {
                    Console.Write('#');
                }
                if (row != n - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
