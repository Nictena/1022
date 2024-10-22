using System;
using System.Runtime.Remoting.Messaging;


//时间复杂度：O(n^2)
public class EnergyFieldSystem
{
    public static float MaxEnergyField(int[] heights)
    {
        if(heights == null || heights.Length < 2)
            return 0;

        float maxEnergy = 0;
        int n = heights.Length;

        for(int i = 0;i<n-1;i++)
        {
            for(int j = i+1;j<n;j++)
            {
                int height1 = heights[i];
                int height2 = heights[j];
                int width = j - i;

                float area = 0.5f * (height1 + height2) * width;

                if(area >maxEnergy)
                {
                    maxEnergy = area;
                }
            }
        }
        return maxEnergy;
    }
}

