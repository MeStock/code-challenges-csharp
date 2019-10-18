using System;
namespace code_challenges
{
    /*
    Alice is playing an arcade game and wants to climb to the top of the
    leaderboard and wants to track her ranking. The game uses Dense
    Ranking, so its leaderboard works like this:

    The player with the highest score is ranked number 1 on the leaderboard.
    Players who have equal scores receive the same ranking number,
    and the next player(s) receive the immediately following ranking number.
    For example, the four players on the leaderboard have high scores of 100, 90, 90,
    and 80. Those players will have ranks 1, 2, 2, and 3, respectively.
    If Alice's scores are 70,  80 and 105, her rankings after each game
    are 4th,  3rd and 1st.


    Sample Input:
    scores: 100 100 50 40 40 20 10
    alice: 5 25 50 120

    Sample Output:
    6 4 2 1
    */

    public class ClimbingTheLeaderboard
    {
        public static int _indexSortingHelper(int[] scores, int numberToInsert)
        {
            int middlePoint = scores.Length / 2;
            while (middlePoint > 0 || middlePoint < (scores.Length - 1))
            {
                if (numberToInsert == scores[middlePoint])
                {
                    return middlePoint;
                }
                else if (numberToInsert < scores[middlePoint])
                {
                    middlePoint = middlePoint + (middlePoint / 2);
                }
                else if (numberToInsert > scores[middlePoint])
                {
                    middlePoint = middlePoint - (middlePoint / 2);
                }
            }
            return middlePoint;
        }
        // Complete the climbingLeaderboard function below.
        static int[] FindPositionOnLeaderboard(int[] scores, int[] alice)
        {
            int[] alicePlaceOnLeaderboard = new int[alice.Length + 1];
            for (int i = 0; i < alice.Length; i++)
            {
                alicePlaceOnLeaderboard[i] = _indexSortingHelper(scores, alice[i]);
            }
            return alicePlaceOnLeaderboard;
        }
    }
}
