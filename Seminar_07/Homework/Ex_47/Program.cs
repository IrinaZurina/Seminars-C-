// 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int row = GetNumberFromUser("Введите количество строк: ","Ошибка ввода!");
int col = GetNumberFromUser("Введите количество столбцов: ","Ошибка ввода!");
double[,] matrix = GetArray(row, col, 0, 10);
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
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            var random = new Random();
            double rDouble = random.NextDouble();  // генерирует вещественное число от 0 до 1
            result[i, j] = Math.Round((rDouble * (maxValue - minValue) + minValue), 2);  // переводит сгенерированное число в заданный диапазон + округление до сотых
        }
    }
    return result;
}

// метод для печати массива
void PrintArray(double[,] inArray)
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
