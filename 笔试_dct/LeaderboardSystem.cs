using System;
using System.Collections.Generic;


//时间复杂度：O(n^2)
//空间复杂度：O(m)

public class LeaderboardSystem
{
    public static List<int> GetTopScore(int[] scores, int m)
    {
        if (scores == null || m <= 0)
            return new List<int>();
        if (m > scores.Length)
            m = scores.Length;

        Array.Sort(scores);
        Array.Reverse(scores);

        for (int i = 0; i < scores.Length - 1; i++)
        {
            for (int j = 0; j < scores.Length - i - 1; j++)
            {
                if (scores[j] < scores[j + 1])
                {
                    // 交换scores[j]和scores[j + 1]  
                    int temp = scores[j];
                    scores[j] = scores[j + 1];
                    scores[j + 1] = temp;
                }
            }
        }

        List<int> topScores = new List<int>();
        for (int i = 0; i < m; i++)
            topScores.Add(scores[i]);
        return topScores;
    }
}
