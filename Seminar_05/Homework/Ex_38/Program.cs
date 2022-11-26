// 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// Задаем рандомный размер массива
int arraySize = new Random().Next(3, 10);

// Заполняем массив
double[] array = GetArray(arraySize, 0, 100);
Console.Write(String.Join(" ", array));

// Создаем переменную для вычисления разности между мин и макс
double diff = GetMaxMinDifference(array);
Console.WriteLine($" -> {diff}");

// Метод для генерации исходного массива
double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

// Метод для вычисления разности между мин и макс
double GetMaxMinDifference(double[] array)
{
    double diff;
    double min = array[0];
    double max = array[0];
    foreach (double element in array)
    {
        if (element <= min) min = element;
        else if (element >= max) max = element;
    }
    diff = max - min;
    return diff;
}