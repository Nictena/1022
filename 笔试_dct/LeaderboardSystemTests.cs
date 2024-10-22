using System.Collections.Generic;
using System;

public class LeaderboardSystemTests
{
    [Test]
    public void TestGetTopScores()
    {
        int[] scores = { 100, 50, 75, 80, 65 };
        int m = 3;
        List<int> topScores = LeaderboardSystem.GetTopScore(scores, m);

        Console.WriteLine(topScores);
    }

    public static void main()
    {
        LeaderboardSystemTests tests = new LeaderboardSystemTests();
        tests.TestGetTopScores();
    }
}