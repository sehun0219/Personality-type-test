// 배열이 있는데 타겟 숫자를 입력하면 합이되는 인덱스들이 튀어나와 다른 배열을 만든다.




using System.Collections;

public class Solution
{
    
    public int[] TwoSum(int[] nums, int target)
    {
        Hashtable hm = new Hashtable();
        for (int i = 0; i < nums.Count(); i++)
        {
            if (!hm.ContainsKey(nums[i]))
            {
                hm.Add(nums[i], i);
            }
            int x = target - nums[i];
            if (hm.ContainsKey(x) && (int)hm[x] != i)
            {
                return new int[] { (int)hm[x], i };
            }
        }
        throw new ArgumentException("error");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] arr = new int[] { 1, 2, 3, 4 };
        var result = solution.TwoSum(arr, 4);
        foreach (var item in result)
        {
            Console.Write(item + " ");
        }
    }
}

// 커런트  + x = target