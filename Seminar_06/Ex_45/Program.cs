// 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] arrayOrig = GenerateArrayWithNumbers(15,0,10);
Console.WriteLine(string.Join(" ", arrayOrig));
int[] arrayCopy = CopyArray(arrayOrig);
Console.WriteLine(string.Join(" ", arrayCopy));

static int[] CopyArray(int[] array)
{
    int[] tempArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        tempArray[i] = array[i];
    }
    return tempArray;
}

static int[] GenerateArrayWithNumbers(int arraySize, int lowLimit, int highLimitIncluded)
{
    Random random = new Random();
    int[] array = new int[arraySize];

    for (int i = 0; i < arraySize; i++)
    {
        array[i] = random.Next(lowLimit, highLimitIncluded + 1);
    }
    return array;
}