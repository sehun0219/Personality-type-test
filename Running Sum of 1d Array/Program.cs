//Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
//Return the running sum of nums.

/*
Define an array result.
Initialize the first element of result with the first element of the input array.
At index i append the sum of the element nums[i] and previous running sum result[i - 1] to the result array.
repeat step 3 for all indices from 1 to n-1.
*/

public class Solution
{
    public int[] RunningSum(int[] nums)
    {
        if (nums.Length < 1 || nums.Length > 1000)
        {
            return nums;
        }

        for(int i = 1; i <nums.Length; i++)
        {
            int result = nums[i];
            if (result < - 10e6 || result > 10e6)
            {
                continue;
            }
            int sum = result + nums[i - 1];
            nums[i] = sum;
        }
        return nums;
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[4] { 1, 2, 3, 4 };
        Solution solution = new Solution();
        var a = solution.RunningSum(nums);
        foreach (var item in a)
        {
            Console.WriteLine(item);
        }
    }
}


//Time complexity: O(n)O(n) where nn is the length of the input array.
//This is because we use a single loop that iterates over the entire array to calculate the running sum.

//Space complexity: O(1)O(1) since we don't use any additional space to find the running sum.
//Note that we do not take into consideration the space occupied by the output array.

