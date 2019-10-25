using System;
using System.Collections.Generic;

namespace code_challenges
{
    public class HighScores
    {
        List<int> list;
        public HighScores(List<int> list)
        {
            this.list = list;
        }

        public List<int> Scores()
        {
            return list;
        }

        public int Latest()
        {
            return list[list.Count];
        }

        public int PersonalBest()
        {
            int max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }

        public List<int> PersonalTopThree()
        {
            List<int> topThree = new List<int>();
            int highest = 0;
            int secondHighest = 0;
            int thirdHighest = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > thirdHighest)
                {
                    thirdHighest = list[i];
                }
                else if (list[i] > secondHighest)
                {
                    thirdHighest = secondHighest;
                    secondHighest = list[i];
                }
                else if (list[i] > highest)
                {
                    thirdHighest = secondHighest;
                    secondHighest = highest;
                    highest = list[i];
                }
            }
            topThree.Add(highest);
            topThree.Add(secondHighest);
            topThree.Add(thirdHighest);
            return topThree;
        }
    }
}
