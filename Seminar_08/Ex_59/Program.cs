// 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

Console.Clear();

int row = GetNumberFromUser("Введите количество строк: ","Ошибка ввода!");
int col = GetNumberFromUser("Введите количество столбцов: ","Ошибка ввода!");
int[,] matrix = GetArray(row, col, 0, 100);
PrintArray(matrix);
Console.WriteLine();

int[,] newMatrix = DeleteRowCol(matrix, FindMinInArray(matrix));
PrintArray(newMatrix);


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


// метод для поиска минимального элемента
int[] FindMinInArray(int[,] array)
{
    int min = array[0, 0];
    int[] minCoord = {0, 0};
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < min) 
            {
                min = array[i,j];
                minCoord[0] = i;
                minCoord[1] = j;
            }
        }
    }
    return minCoord;
}

// метод для создания матрицы без строки и столбца
int [,] DeleteRowCol(int[,] array, int[] coord)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int tempI = 0;
    int tempJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == coord[0]) 
        {
            tempI = 1;
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == coord[1]) 
        {
            tempJ = 1;
            continue;
        }
            newArray[i - tempI, j - tempJ] = array[i,j];
            
        }
        tempJ = 0;
    }
    return newArray;
}