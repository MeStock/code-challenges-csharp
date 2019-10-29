using System;
namespace code_challenges
{
    public class BreakingRecords
    {
        static int[] breakingRecords(int[] scores) {
            int currentMin = scores[0];
            int currentMax = scores[0];
            int numOfMinChanges = 0;
            int numOfMaxChanges = 0;
            for(int i = 1; i < scores.Length; i++)
            {
                if(scores[i] < currentMin)
                {
                    currentMin = scores[i];
                    numOfMinChanges++;
                }else if(scores[i] > currentMax)
                {
                    currentMax = scores[i];
                    numOfMaxChanges++;
                }
            }
            return new int[] {numOfMaxChanges, numOfMinChanges};
        }
    }
}
