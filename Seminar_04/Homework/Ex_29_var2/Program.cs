// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[] array = new int[GetNumberFromUser("Введите целое число: ","Ошибка ввода!")];
FillUserArray(array);
PrintArray(array);

// Метод для заполнения массива
void FillUserArray(int[] collection)
{
    
    for (int i = 0; i < array.Length; i++)
        array[i] = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
}

// Метод для печати массива
void PrintArray(int[] col)
{
    //вывод последовательно по одному элементу массива

    Console.Write("[ ");  
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{col[i]} ");
    Console.Write("]"); 
        
}

// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage
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