
using System;
using System.Collections.Generic;

public class Solution
{
    private static readonly int[] RANGE_OF_VALUES = { 1, 100 };

    public IList<int> LongestCommonSubsequence(int[][] arrays)
    {
        int[] frequency = new int[RANGE_OF_VALUES[1] + 1];
        IList<int> longestCommonSubsequence = new List<int>();

        foreach (int[] numbers in arrays)
        {
            foreach (int value in numbers)
            {
                ++frequency[value];
            }
        }

        for (int value = RANGE_OF_VALUES[0]; value <= RANGE_OF_VALUES[1]; value++)
        {
            if (frequency[value] == arrays.Length)
            {
                longestCommonSubsequence.Add(value);
            }
        }

        return longestCommonSubsequence;
    }
}
