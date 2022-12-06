// 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
 Console.Clear();
 int row = GetNumberFromUser("Введите количество строк: ","Ошибка ввода!");
int col = GetNumberFromUser("Введите количество столбцов: ","Ошибка ввода!");
int[,] matrix = GetArray(row, col, 0, 9);
PrintArray(matrix);
Console.WriteLine();

int[,] countArray = CountSymbols(matrix);
PrintCountArray(countArray);


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
int[,] CountSymbols(int[,] array)
{
    int[,] newArray = new int[10, 2];
    for (int i = 0; i < 10; i++)
    {
       newArray[i, 0] = i;
    } 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[array[i,j], 1] ++;
        }

    }
    return newArray;
}

void PrintCountArray(int[,] inArray)
{
    for (int i = 0; i < 10; i++)
    {
        if (inArray[i, 1] != 0)
        {
            Console.WriteLine($"{inArray[i, 0]} встречается {inArray[i, 1]} раз(а)");

        }
         
     }
}
