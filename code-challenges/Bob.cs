using System;
using System.Text.RegularExpressions;

namespace code_challenges
{
    public static class Bob
    {
        public static string Response(string statement)
        {
            char[] separatedStatement = statement.Trim().ToCharArray();
            char lastElement = separatedStatement.Length < 1 ? ' ' : separatedStatement[separatedStatement.Length - 1];
            bool isUpperCase = isYelling(statement);

            if (isUpperCase)
            {
                return lastElement == '?' ? "Calm down, I know what I'm doing!" : "Whoa, chill out!";
            }
            else if (lastElement == ' ')
            {
                return "Fine. Be that way!";
            }
            else if (lastElement == '?')
            {
                return "Sure.";
            }
            else
            {
                return "Whatever.";
            }
        }

        public static bool isYelling(string statement)
        {
            string statementWithNoSpecialCharacters = Regex.Replace(statement, "[^a-zA-Z_.]+", "", RegexOptions.Compiled);
            if (statementWithNoSpecialCharacters.Length == 0) return false;
            for (int i = 0; i < statementWithNoSpecialCharacters.Length; i++)
            {
                if (!Char.IsUpper(statementWithNoSpecialCharacters[i]))
                    return false;
            }
            return true;
        }
    }
}
