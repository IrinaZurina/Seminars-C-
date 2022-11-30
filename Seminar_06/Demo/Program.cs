// 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reversedArray = ReverseArray1(array);
Console.WriteLine(String.Join(" ", reversedArray));

ReverseArray2(array);
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];
    for (int i = 0; i < size; i ++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] ReverseArray1(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i ++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}

void ReverseArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length/2; i ++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - 1  -i];
        inArray[inArray.Length - 1 - i] = k;
    }
}