
// Given an array nums of integers, return how many of them contain an even number of digits.

public class Solution
{
    public int FindNumbers(int[] nums)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int val = nums[i];
            string nString = val.ToString();
            
            if (nString.Length % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}