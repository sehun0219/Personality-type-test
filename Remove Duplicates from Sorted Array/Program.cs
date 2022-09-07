
// 중복되는 값을 1개만 쓰고 몇개의 요소가 쓰였는지 리턴하는 함수

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            
        }
        int insert = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[insert] = nums[i];
                insert++;
            }
        }
        return insert;


    }
}
