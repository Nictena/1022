using System;

public class TalentAssessmentSystemTests
{
    [Test]
    public void TestFindMedianTalentIndex()
    {
        int[] fireAbility = { 1, 3, 7, 9, 11 };
        int[] iceAbility = { 2, 4, 8, 10, 12, 14 };
        double finalMedianTalent = TalentAssessmentSystem.FindMedianTalenIndex(fireAbility, iceAbility);
        Console.WriteLine(finalMedianTalent.ToString());
    }
}