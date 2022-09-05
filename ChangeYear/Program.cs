
class Program
{
    static void Main(string[] args)
    {
        // fullSet = 1,1,2,2,2,8
        int[] fullSet = { 1, 1, 2, 2, 2, 8 };
        int[] input = new int[6];
        int[] output = new int[6];
        for (int i = 0; i < input.Length; i++)
        {
            int inputNum = int.Parse(Console.ReadLine());
            input[i] = inputNum;
        }
        for (int i = 0; i < output.Length; i++)
        {
            output[i] = fullSet[i] - input[i];
            Console.Write(output[i]+ " ");
        }
        Console.ReadLine();
    }
}