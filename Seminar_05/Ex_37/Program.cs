// 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// Задаем рандомный размер массива
int arraySize = new Random().Next(3, 20);

// заполняем массив
int[] array = GetArray(arraySize, 1, 100);
Console.WriteLine(String.Join(" ", array));

// Создаем и заполняем новый массив из произведений элементов
int[] result = PairProductArray(array);
Console.WriteLine(String.Join(" ", result));

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

// метод для создания нового массива из произведений элементов
int[] PairProductArray(int[] array)
{
    int size;
    if (array.Length % 2 == 0) size = array.Length / 2;
    else size = array.Length / 2 + 1;
    int[] result = new int[size];
    
    for (int i = 0; i < array.Length / 2; i++) // Вот в этой строке мы заканчиваем цикл не на size
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 != 0) result[size - 1] = array[size - 1]; // и вот здесь добавляем последний элемент без пары

    return result;
}