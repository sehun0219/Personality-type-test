
// 연습장

int[] intArray = new int[6];
int length = 0;

// Add 3 elements to the Array
for (int i = 0; i < 3; i++)
{
    intArray[length] = i;
    length++;
}
intArray[length] = 10;
length++;


for (int i = 3; i >= 0; i--)
{
    intArray[i + 1] = intArray[i];
}
intArray[0] = 20;



for (int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine("Index " + i + " contains " + intArray[i]);
}