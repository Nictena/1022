using System;
using System.Diagnostics;

//时间复杂度：O(n)
//空间复杂度：O(n)

public class TreasureHuntSystem
{
    public static int MaxTreasureValue(int[] treasures)
    {
        if (treasures == null || treasures.Length == 0)
            return 0;
        if (treasures.Length == 1)
            return treasures[0];

        int[] dp = new int[treasures.Length];
        dp[0] = treasures[0];
        dp[1] = Math.Max(treasures[0], treasures[1]);

        for (int i = 0; i < treasures.Length; i++)
        {
            dp[i] = Math.Max(dp[i - 1], dp[i - 2] + treasures[i]);
        }
        return dp[treasures.Length - 1];
    }
}