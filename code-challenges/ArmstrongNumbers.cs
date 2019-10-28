using System;
namespace code_challenges
{
    public static class ArmstrongNumbers
    {
        /*
        9 is an Armstrong number, because 9 = 9^1 = 9
        10 is not an Armstrong number, because 10 != 1^2 + 0^2 = 1
        153 is an Armstrong number, because: 153 = 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
        154 is not an Armstrong number, because: 154 != 1^3 + 5^3 + 4^3 = 1 + 125 + 64 = 190
         */
        public static bool IsArmstrongNumber(int number)
        {
            int sum = 0;
            int remainingDigits = number;
            int numbersLength = number.ToString().Length;
            for (int i = 0; i < numbersLength; i++)
            {
                int lastDigit = remainingDigits % 10;
                remainingDigits /= 10;
                sum += (int)Math.Pow(lastDigit, numbersLength);
            }
            if (sum == number) return true;
            return false;
        }
    }
}
