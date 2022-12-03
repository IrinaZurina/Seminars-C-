// 50: Напишите программу, которая на вход принимает ЗНАЧЕНИЕ элемента в двумерном массиве, 
// и возвращает ПОЗИЦИЮ этого элемента или же указание, что такого элемента нет.

int row = GetNumberFromUser("Введите количество строк: ","Ошибка ввода!");
int col = GetNumberFromUser("Введите количество столбцов: ","Ошибка ввода!");
int[,] matrix = GetArray(row, col, 0, 100);
PrintArray(matrix);

int userNumber = GetNumberFromUser("Введите целое число от 0 до 100: ","Ошибка ввода!");

FindNumberInArray(matrix, userNumber);


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


// метод для поиска числа и вывода его позиции
// если числа нет в массиве, пользователю предлагается ввести новое число для поиска или остановить программу.
void FindNumberInArray(int[,] array, int num)
{
    int[] position = {-1, -1}; 

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                position[0] = i;
                position[1] = j;
                break;
            }
        }
        if (position[0] > -1) break;
    }

    if (position[0] == -1) 
    {
        Console.WriteLine("Такого числа нет в массиве");
        num = GetNumberFromUser("Введите новое целое число от 0 до 100 или -1, если хотите выйти. ","Ошибка ввода!");
        if (num > -1) FindNumberInArray(array, num);
    }
    else Console.WriteLine($"Число {num} находится на позиции {position[0]},{position[1]}");
    
}

