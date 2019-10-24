using System;
namespace code_challenges
{
    public static class ResistorColor
    {
        public static int ColorCode(string color)
        {
            int selectedColor = Array.IndexOf(Colors(), color);
            return selectedColor;
        }

        public static string[] Colors()
        {
            string[] colors = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
            return colors;
        }
    }
}
