// Заполните спирально массив 4 на 4. 
// Задача решена для массива ЛЮБОГО размера
Console.Clear();

int row = GetNumberFromUser("Введите количество строк: ","Ошибка ввода!");
int col = GetNumberFromUser("Введите количество столбцов: ","Ошибка ввода!");
int[,] matrix = new int[row, col];
if (row == 1 && col == 1) matrix[0,0] = 1;   // учитываем исключительный случай матрицы 1х1
else matrix = GetSpiralArray(row, col);
PrintArray(matrix);


// метод для заполнения массива
int[,] GetSpiralArray(int row, int col)
{
    int[,] spiralArray = new int[row, col];
    int i = 0;   // стратовая позиция рядов
    int j = 0;   // стратовая позиция столбцов
    int step = 1;   // шаг для передвижения по матрице
    int num = 1;   // число, с которого начинается заполнение
    
    while (num <= row * col) 
    {
        while (j + step >= 0 && j + step < col)
        {
            if (spiralArray[i, j] == 0)
            {
                spiralArray[i, j] = num;
                num++; 
            }         
            if (num > row * col ||  spiralArray[i, j + step] != 0) break;   // условия для досрочного выхода из цикла - следующая ячейка заполнена или закончились пустые ячейки
            j += step;
        }
        
        while (i + step >= 0 && i + step < row)
        {           
            if (spiralArray[i, j] == 0)
            {
                spiralArray[i, j] = num;
                num++;
            }          
            if (num > row * col || spiralArray[i + step, j] != 0) break;   // условия для досрочного выхода из цикла - следующая ячейка заполнена или закончились пустые ячейки                
            i += step;
        }
        step *= -1;   // в конце итерации внешнего цикла меняем напраление движения
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


