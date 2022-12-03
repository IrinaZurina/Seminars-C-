// 50: Напишите программу, которая на вход принимает ПОЗИЦИИ элемента в двумерном массиве, 
// и возвращает ЗНАЧЕНИЕ этого элемента или же указание, что такого элемента нет.

int row = GetNumberFromUser("Введите количество строк: ","Ошибка ввода!");
int col = GetNumberFromUser("Введите количество столбцов: ","Ошибка ввода!");
int[,] matrix = GetArray(row, col, 0, 100);
PrintArray(matrix);

int userRowNum = GetNumberFromUser("Введите номер строки: ","Ошибка ввода!");
int userColNum = GetNumberFromUser("Введите номер столбца: ","Ошибка ввода!");
FindNumberInArray(matrix, userRowNum, userColNum);


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


// метод для вывода числа на заданной позиции
// если позиции нет в массиве, пользователю предлагается ввести новые координаты или выйти из программы. Реализовано через рекурсию
void FindNumberInArray(int[,] array, int row, int col)
{
    if (row > array.GetLength(0) - 1 || col > array.GetLength(1) - 1) 
    {
        Console.WriteLine("Такой позиции нет в массиве");
        row = GetNumberFromUser("Введите новый номер строки или -1, чтобы выйти. ","Ошибка ввода!");
        if (row > -1) 
        {
            col = GetNumberFromUser("Введите новый номер столбца: ","Ошибка ввода!");
            FindNumberInArray(array, row, col);
        }
    }
    else Console.WriteLine($"Число на позиции {row},{col} -> {array[row,col]}");  
}

