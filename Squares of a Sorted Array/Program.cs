﻿//Given an integer array nums sorted in non-decreasing order, 
//return an array of the squares of each number sorted in non-decreasing order.




public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i] * nums[i];  
        }
        Array.Sort(nums);
        return nums;
    }
}