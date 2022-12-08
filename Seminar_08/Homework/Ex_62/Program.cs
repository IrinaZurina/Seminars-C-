// Заполните спирально массив 4 на 4.
Console.Clear();

int row = GetNumberFromUser("Введите количество строк: ","Ошибка ввода!");
int col = GetNumberFromUser("Введите количество столбцов: ","Ошибка ввода!");
int[,] matrix = GetSpiralArray(row, col);
PrintArray(matrix);

// метод для заполнения массива
int[,] GetSpiralArray(int m, int n)
{
    int[,] spiralArray = new int[m, n];
    int rowPos = 0;
    int colPos = 0;
    int rowStep = 1;
    int colStep = 1;
    int num = 1;
    while (num <= m * n) 
    {
        while (colPos < spiralArray.GetLength(1) && colPos >= 0)
        {
            if (spiralArray[rowPos, colPos] == 0)
            {
                spiralArray[rowPos, colPos] = num;
                num++;    
            }
            /* else 
            { 
                colPos -= colStep;
                break;
            } */
            
            if (num > m * n 
                || spiralArray[rowPos, colPos + colStep] != 0 
                || colPos + colStep >= spiralArray.GetLength(1)
                || colPos + colStep < 0) 
                break;
            colPos += colStep;
        }

        while (rowPos < spiralArray.GetLength(0) && rowPos >= 0)
        {
            if (spiralArray[rowPos, colPos] == 0)
            {
                spiralArray[rowPos, colPos] = num;
                num++;    
            }
            else 
            { 
                rowPos -= rowStep;
                break;
            }
            rowPos += rowStep;
            if (num > spiralArray.GetLength(0) * spiralArray.GetLength(1) || spiralArray[rowPos + rowStep, colPos] != 0) break;
        }
        rowPos -= rowStep;
        rowStep *= -1;
        colStep *= -1;
    PrintArray(spiralArray);
    Console.WriteLine();
    }    
    return spiralArray;
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


