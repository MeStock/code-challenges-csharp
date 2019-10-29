using System;
namespace code_challenges
{
    public static class CollatzConjecture
    {
        public static int Steps(int number, int numberOfSteps = 0)
        {
            if (number < 1) throw new ArgumentException();
            if (number == 1) return numberOfSteps;

            if (number % 2 == 0) number = number / 2;
            else number = number * 3 + 1;
            return Steps(number, numberOfSteps + 1);
        }
    }
}
