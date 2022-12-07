// 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// !!! Для успешного перемножения матриц кол-во столбцов одной матрицы д.б. равно кол-ву строк второй матрицы
// Если размер матрицы1 m x n, размер матрицы2 n x k => размер итоговой матрицы m x k
Console.Clear();

int row1 = GetNumberFromUser("Введите количество строк: ","Ошибка ввода!");
int col1 = GetNumberFromUser("Введите количество столбцов: ","Ошибка ввода!");
int row2 = GetNumberFromUser("Введите количество строк: ","Ошибка ввода!");
int col2 = GetNumberFromUser("Введите количество столбцов: ","Ошибка ввода!");

if (col1 != row2) Console.WriteLine("Произведение этих матриц найти невозможно!");
else
{
    int[,] matrix1 = GetArray(row1, col1, 0, 10);
    PrintArray(matrix1);
    Console.WriteLine();
    int[,] matrix2 = GetArray(row2, col2, 0, 10);
    PrintArray(matrix2);
    Console.WriteLine();
    int[,] productMatrix = MultiplyMatrices(matrix1, matrix2);
    PrintArray(productMatrix);
}

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

// метод для нахождения произведения двух матриц
int[,] MultiplyMatrices(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int row = 0; row < array1.GetLength(0); row++)
    {
        for (int col = 0; col < array2.GetLength(1); col++)
        {
            for (int i = 0; i < array1.GetLength(1); i++)
            {
                result[row, col] += array1[row, i] * array2[i, col];
            }
        }
    }
    return result;
}