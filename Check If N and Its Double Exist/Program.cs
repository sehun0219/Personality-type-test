

// 임의의 원소 m*2가 n일때 m과 n이 있으면 true, 없으면 false
public class Solution
{
    public bool CheckIfExist(int[] arr)
    {
        if (arr == null)
        {
            return false;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if (i!=j)
                {
                    if (arr[i] == 2 * arr[j])
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}