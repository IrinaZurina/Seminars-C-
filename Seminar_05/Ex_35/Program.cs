// 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

// Создаем и заполняем массив
int[] array = GetArray(123, 0, 1000);

// Создаем счетчик чисел
int count = CountNumbers(array, 10, 99);

Console.Write(String.Join(" ", array));
Console.WriteLine($" Rоличество элементов массива от 10 до 99 = {count}");

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

// Метод для подсчета чисел из интервала
int CountNumbers(int[] array, int minValue, int maxValue)
{
    int count = 0;
    foreach (int element in array)
    {
        if (minValue <= element && element <= maxValue) 
        {
            count += 1;
        }
    }

    return count;

}