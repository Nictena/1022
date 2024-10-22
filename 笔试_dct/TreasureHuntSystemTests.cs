using System;

public class TreasureHuntSystemTests
{
    [Test]
    public void TestMaxTreasureValue()
    {
        int[] treasures = { 3, 1, 5, 2, 4 };
        int result = TreasureHuntSystem.MaxTreasureValue(treasures);
        Console.WriteLine(result);
    }
}
