// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
Console.Clear();

int[] array = new int[8];
FillArray(array);
PrintArray(array);

// Метод для заполнения массива
void FillArray(int[] collection)
{
    /* int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    } */

    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 2);
}

// Метод для печати массива
void PrintArray(int[] col)
{
    //вывод последовательно по одному элементу массива
      
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{col[i]} ");
        
}
