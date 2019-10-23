using System;
namespace code_challenges
{
    /*
     You are choreographing a circus show with various animals. For one act,
     you are given two kangaroos on a number line ready to jump in the
     positive direction (i.e, toward positive infinity).

    The first kangaroo starts at location x1 and moves at a rate of v1 meters
    per jump. The second kangaroo starts at location x2 and moves at a
    rate of v2 meters per jump. You have to figure out a way to get
    both kangaroos at the same location at the same time as part of the show.
    If it is possible, return YES, otherwise return NO.

     */
    public class Kangaroo
    {
        // Complete the kangaroo function below.
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int maxDistance = 100000000;
            while (x1 < maxDistance && x2 < maxDistance)
            {
                if (x1 == x2)
                {
                    return "YES";
                }
                x1 += v1;
                x2 += v2;
            }
            return "NO";
        }
    }
}
