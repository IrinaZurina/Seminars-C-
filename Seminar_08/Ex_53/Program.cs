// 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.;

Console.Clear();

int row = GetNumberFromUser("Введите количество строк: ","Ошибка ввода!");
int col = GetNumberFromUser("Введите количество столбцов: ","Ошибка ввода!");
int[,] matrix = GetArray(row, col, 0, 100);
PrintArray(matrix);
Console.WriteLine();
SwapLinesInArray(matrix);
PrintArray(matrix);


//  метод получения числа от пользователя
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    } 
}

// метод для заполнения массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);;
        }
    }
    return result;
}

// метод для вывода массива на экран
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
             Console.Write($"{inArray[i, j]} ");
        }
         Console.WriteLine();
     }
}


// метод 
void SwapLinesInArray(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[array.GetLength(0)-1, i];
        array[array.GetLength(0)-1, i] = temp;

    }
}

