// 배열에서 요소 지우기

// 1. 마지막 배열 원소 지움
// 2. 첫 원소 지움
// 3. 주어진 인덱스 지움

// Declare an integer array of 10 elements.
int[] intArray = new int[10];

// The array currently contains 0 elements
int length = 0;

// Add elements at the first 6 indexes of the Array.
for (int i = 0; i < 4; i++)
{
	intArray[length] = i;
	length++;
}

for(int i = 1; i < length; i++)
{
	intArray[i - 1] = intArray[i];
}


for (int i = 2; i < length; i++)
{
	intArray[i - 1] = intArray[i];
}



for (int i = 0; i < length; i++)
{
	Console.WriteLine("Index " + i + " contains " + intArray[i]);
}

