using System;
using System.Collections.Generic;

namespace code_challenges
{
    public static class RotationalCipher
    {
        public enum Alphabet { a = 1, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z }
        public static string Rotate(string text, int shiftKey)
        {
            if (shiftKey == 0) return text;
            string result = "";
            foreach (char character in text)
            {
                bool characterIsUpper = false;
                if (Char.IsLetter(character))
                {
                    if (Char.IsUpper(character)) { characterIsUpper = true; }
                    Alphabet isValidLetter = (Alphabet)Enum.Parse(typeof(Alphabet), character.ToString(), true);
                    int letterAsNumber = (int)isValidLetter + shiftKey;
                    if (letterAsNumber > 26) { letterAsNumber -= 26; }
                    Alphabet newLetter = (Alphabet)letterAsNumber;
                    string newString = newLetter.ToString().ToUpper();
                    result = characterIsUpper ? result += newString : result += newLetter;
                }
                else
                {
                    result += character;
                }
            }
            return result;
        }
    }
}
