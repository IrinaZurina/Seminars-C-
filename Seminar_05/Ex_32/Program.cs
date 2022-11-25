// 32: Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.

//Генерируем массив
Console.Clear();
int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

// Создаем и заполняем новый массив
int[] newArray = ChangeSign(array);
Console.WriteLine(String.Join(" ", newArray));

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

// Метод для создания нового массива с противоположными элементами
int[] ChangeSign(int[] array)
{
    int[] result = array;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return result;
}