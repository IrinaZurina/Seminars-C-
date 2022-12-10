// 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

int start = GetNumberFromUser("Введите целое положительное число: ","Ошибка ввода!");

Console.Write($"N = {start} -> ");
PrintNaturalNumbers(start, 1);

// метод для вывода натуральных чисел от N до 1
void PrintNaturalNumbers(int start, int finish)
{
    if(start > finish)
    {
        Console.Write($"{start}, ");
        PrintNaturalNumbers(start - 1, finish);
    }
    else if (start == finish)
    {
        Console.Write($"{start}");
    }
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
