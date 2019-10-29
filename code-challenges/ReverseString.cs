using System;
namespace code_challenges
{
    public static class ReverseString
    {
        public static string Reverse(string input)
        {
            int middlePoint = input.Length / 2;
            char[] result = input.ToCharArray();
            for (int i = 0; i < middlePoint; i++)
            {
                char temp = result[i];
                result[i] = result[result.Length - 1 - i];
                result[result.Length - 1 - i] = temp;
            }
            return new string(result);
        }
    }
}
