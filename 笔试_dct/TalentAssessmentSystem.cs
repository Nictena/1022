using System;

//时间复杂度：O(m+n)
//空间复杂度：O(1)


public class TalentAssessmentSystem
{
    public static double FindMedianTalenIndex(int[] fireAbility, int[] iceAbility)
    {
        int totalLength = fireAbility.Length + iceAbility.Length;
        int midIndex = totalLength / 2;

        int i = 0, j =0;
        int left = 0, right = 0;

        if (totalLength % 2 == 0)
        {
            for(int k = 0; k < midIndex;k++)
            {
                if( i < fireAbility.Length || (j >= iceAbility.Length || fireAbility[i] <= iceAbility[j]))
                {
                    left = right;
                    right = fireAbility[i];
                    i++;
                }
                else
                {
                    left = right;
                    right = iceAbility[j];
                    j++;
                }
            }
            return left + right;
        }
        else
        {
            for(int k =0;k<midIndex;k++)
            {
                if (i < fireAbility.Length && (j >= iceAbility.Length || fireAbility[i] <= iceAbility[j]))
                {
                    right = fireAbility[i];
                    i++;
                }
                else
                {
                    right = iceAbility[j];
                    j++;
                }
            }
            return right;
        }
        }
    }
}