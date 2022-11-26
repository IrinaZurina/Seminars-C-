// 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Задаем рандомный размер массива
int arraySize = new Random().Next(3, 10);

// Заполняем массив
int[] array = GetArray(arraySize, 0, 100);
Console.Write(String.Join(" ", array));

// Создаем переменную для подсчета суммы элементов на нечетных позициях
int sum = GetSumOddPositions(array);
Console.WriteLine($" -> {sum}");

// Метод для генерации исходного массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// Метод для подсчета уммы элементов на нечетных позициях
int GetSumOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}