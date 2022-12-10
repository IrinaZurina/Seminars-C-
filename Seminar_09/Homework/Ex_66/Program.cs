// 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

int m = GetNumberFromUser("Введите первое целое положительное число:  ","Ошибка ввода!");
int n = GetNumberFromUser("Введите второе целое положительное число:  ","Ошибка ввода!");

int numSum = FindNumbersSum(m, n);

Console.WriteLine($"M = {m}, N = {n} -> {numSum}");

// метод для поиска суммы натуральных чисел на промежутке от M до N
int FindNumbersSum(int num1, int num2)
{
    if(num1 == num2) return num1;
    else return num1 + FindNumbersSum(num1 + 1, num2);
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

