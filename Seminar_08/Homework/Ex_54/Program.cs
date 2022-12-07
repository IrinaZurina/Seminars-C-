// 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
Console.Clear();

int row = GetNumberFromUser("Введите количество строк: ","Ошибка ввода!");
int col = GetNumberFromUser("Введите количество столбцов: ","Ошибка ввода!");
int[,] matrix = GetArray(row, col, 0, 100);
PrintArray(matrix);
Console.WriteLine();
MatrixRowBubbleSort(matrix);
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

// метод пузырьковой сортировки для одномерного массива
int[] BubbleSort(int[] array)
{
    int temp;
    int count = 0;   // счетчик для оптимизации метода
    int n = array.Length;
    for (int i = 0; i < n - 1; i++)   // i < n - 1, т.к. сравнений будет на 1 меньше, чем элементов в массиве
    {
        for (int j = 0; j < n - i - 1; j++)   // в каждом новой итерации внешнего цикла количество итераций вложенного цикла уменьшается на 1
        {
            if (array[j] < array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                count++;
            }
        }
        if (count == 0) break;   // если в итерации не произошло ни одной замены, т.е. сортировка закончилась, прерываем внешний цикл.
        count = 0;
    }    
    return array;
}

// метод для пузырьковой сортировки строк по убыванию внутри двумерного массива
void MatrixRowBubbleSort(int[,] array)
{    
    int[] sortedRow = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sortedRow[j] = array[i,  j];   // создаем одномерный массив-копию строки
        }
        sortedRow = BubbleSort(sortedRow);   // сортируем одномерный массив
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,  j] = sortedRow[j];   // обновляем строку в исходном массиве
        }
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
