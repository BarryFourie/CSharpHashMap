using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[][] testCases = new int[][]
       {
            new int[] { }, // Empty array
            new int[] { 1 }, // Single element array
            new int[] { 2, 2, 2, 2, 2 }, // All elements are the same
            new int[] { 1, 2, 3, 4, 5 }, // No majority element
            new int[] { 3, 3, 3, 1, 2 }, // Majority element at the start
            new int[] { 1, 2, 3, 3, 3 }, // Majority element at the end
            new int[] { 1, 3, 3, 3, 2 }, // Majority element in the middle
            new int[] { -1, -1, -1, 2, 2 }, // Array with negative numbers
            new int[] { -1, 1, -1, 1, -1 }, // Array with mixed positive and negative numbers
            new int[] { 1000000, 1000000, 1000000, 2, 2 }, // Array with large numbers
            new int[] { 1, 1, 2, 2, 3, 3 }, // Array with duplicates but no majority
            new int[] { 1, 1, 2, 2 } // Array with exactly half elements same
       };

        foreach (var testCase in testCases)
        {
            Console.WriteLine(FindNumber(testCase));
        }
    }

    /// <summary>
    /// Finds the majority integer in an array, if it exists.
    /// </summary>
    /// <param name="nums">The array of integers.</param>
    /// <returns>The majority element as a string, or "No intetger is in the majority" if no integer element exists.</returns>
    public static string FindNumber(int[] nums)
    {
        Dictionary<int, int> dictCounts = new Dictionary<int, int>();
        int counts = nums.Length / 2;

        foreach (int num in nums)
        {
            if (dictCounts.ContainsKey(num))
            {
                dictCounts[num]++;
            }
            else
            {
                dictCounts[num] = 1;
            }

            if (dictCounts[num] > counts)
            {
                return num.ToString();
            }
        }

        return "No integer is in the majority.";
    }
}