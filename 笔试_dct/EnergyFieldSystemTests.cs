using System;

public class EnergyFieldSystemTests
{
    [Test]
    public viod TestMaxEnergyField()
    {
        int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        float maxEnergy = EnergyFieldSystem.MaxEnergyField(heights);
        Console.WriteLine(maxEnergy.ToString());
    }
}