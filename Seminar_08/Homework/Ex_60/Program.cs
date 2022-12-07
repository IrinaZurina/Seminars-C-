// 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();

int dimensionX = GetNumberFromUser("Введите количество строк: ","Ошибка ввода!");
int dimensionY = GetNumberFromUser("Введите количество столбцов: ","Ошибка ввода!");
int dimensionZ = GetNumberFromUser("Введите количество слоев: ","Ошибка ввода!");

int[, ,] matrix3D = GetArray(dimensionX, dimensionY, dimensionZ);

PrintArray(matrix3D);

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
int[, ,] GetArray(int x, int y, int z)
{
    int[, ,] result = new int[x, y, z];   // трехмерный массив для заполнения
    int[] newNumbers = new int[1];   // массив для запоминания эл-тов, которые уже внесли
    // int count = 0;   // счетчик элементов в массиве elements, по этому индексу будут добавляться новые элементы для отслеживания
    for (int k = 0; k < z; k++)   // внешний цикл на третье измерение, чтобы послойно заполнять двумерную матрицу
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                result[x, y, z] = AddNewElement(result[x, y, z], newNumbers, 10, 99);
                //newNumbers[count] = result[x, y, z];
                //count++;
            }
        }
    }
    return result;
}

// метод для проверки наличия элемента в массиве
bool FindElement(int element, int[] array)
{
    bool flag = true;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != element) flag = true;
        else 
        {
            flag = false;
            break;
        }
    }
    return flag;
}

// метод для записи в элемент массива неповторяющегося чила
int AddNewElement(int element, int[] array, int minValue, int maxValue)
{
    element = new Random().Next(minValue, maxValue + 1);   // генерируем элемент массива
    if (FindElement(element, array))   // если метод FindElement возвращает true, то значит элемент новый и он остается в матрице
        {
            array.Append(element);   // добавляем элемент в массив уникальных элементов
        }
    else element = AddNewElement(element, array, minValue, maxValue);
    return element;            
}

// метод для вывода массива на экран
void PrintArray(int[,,] inArray)
{
    for (int k = 0; k < inArray.GetLength(2); k++)
    {    
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
                