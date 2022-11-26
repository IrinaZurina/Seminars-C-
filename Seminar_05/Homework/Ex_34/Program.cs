// 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Задаем рандомный размер массива
int arraySize = new Random().Next(3, 20);

// Заполняем массив
int[] array = GetArray(arraySize, 100, 999);
Console.Write(String.Join(" ", array));

// Создаем переменную для подсчета четных чисел
int evenNum = CountEvenNumbers(array);
Console.WriteLine($" -> {evenNum}");

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

// Метод для подсчета четных чисел
int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int element in array)
    {
        if (element % 2 == 0) count += 1;
    }
    return count;
}