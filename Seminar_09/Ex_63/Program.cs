// 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

Console.Clear();

// int firstNum = 1;
int userNum = GetNumberFromUser("Введите целое положительное число: ","Ошибка ввода!");

PrintNaturalNumbers(1, userNum);

void PrintNaturalNumbers(int num1, int num2)
{
    Console.Write($"{num1} ");
    if(num1 < num2) PrintNaturalNumbers(num1 + 1, num2);
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
