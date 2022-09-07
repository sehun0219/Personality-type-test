
class Program
{
    public static bool LinearSearch(int[] arr, int length, int element)
    {
        if (arr == null || length == 0)
        {
            return false;
        }
        for (int i = 0; i < length; i++)
        {
            if (arr[i] == element)
            
            return true;
        }

        return false;
    }

    static void Main(string[] args)
    {
        int[] arr1 = new int[10];
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = i;
        }

        Console.WriteLine(LinearSearch(arr1, 10, 3));
    }
}


