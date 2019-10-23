using System;
namespace code_challenges
{
    /*
    Sam's house has an apple tree and an orange tree that yield an
    abundance of fruit. In the diagram below, the red region
    denotes his house, where s is the start point, and t is the endpoint.
    The apple tree is to the left of his house, and the orange
    tree is to its right. You can assume the trees are located on a
    single point, where the apple tree is at point a, and the orange tree is at
    point b.


    When a fruit falls from its tree, it lands d units of distance from
    its tree of origin along the x-axis. A negative value of  means the
    fruit fell d units to the tree's left, and a positive value of
    means it falls d units to the tree's right.

    Given the value of d for m apples and n oranges, determine how many apples
    and oranges will fall on Sam's house (i.e., in the inclusive range [s,t])?
    */
    public class ApplesAndOranges
    {
        // Complete the countApplesAndOranges function below.
        static string countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int numOfApples = 0;
            int numOfOranges = 0;
            for (int i = 0; i < apples.Length; i++)
            {
                if ((apples[i] + a) >= s && (apples[i] + a) <= t)
                {
                    numOfApples++;
                }
            }
            for (int j = 0; j < oranges.Length; j++)
            {
                if ((oranges[j] + b) >= s && (oranges[j] + b) <= t)
                {
                    numOfOranges++;
                }
            }
            Console.WriteLine($"{numOfApples}");
            Console.WriteLine($"{numOfOranges}");
            return $"{numOfApples} {numOfOranges}";
        }
    }
}
