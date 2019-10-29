using System;
using System.Collections.Generic;

namespace code_challenges
{
    public static class SumOfMultiples
    {
        public static int Sum(IEnumerable<int> multiples, int max)
        {
            int sum = 0;
            for (int i = 1; i < max; i++)
            {
                bool isMultiple = false;
                foreach (int number in multiples)
                {
                    if (number == 0) continue;
                    if (i % number == 0) isMultiple = true;
                }
                if (isMultiple) sum += i;
            }
            return sum;
        }
    }
}
