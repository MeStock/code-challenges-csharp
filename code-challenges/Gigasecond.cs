using System;
namespace code_challenges
{
    public static class Gigasecond
    {
        public static DateTime Add(DateTime moment)
        {
            int gigsec = 1000000000;
            var duration = new System.TimeSpan(0, 0, 0, gigsec);
            return moment.Add(duration);
        }
    }
}
