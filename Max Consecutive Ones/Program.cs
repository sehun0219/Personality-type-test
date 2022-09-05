//Given a binary array nums, return the maximum number of consecutive 1's in the array.

// strategy 
// 1. make some array for collecting only 1
// 2. compare the length of them

public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxCount = 0;
        int minCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                minCount++;
            }
            else
            {
                minCount = 0;
            }
            if (minCount > maxCount)
            {
                maxCount = minCount;
            }
        }
        return maxCount;
        
    }
}
