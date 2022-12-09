// 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Clear();

int userNum1 = GetNumberFromUser("Введите первое целое положительное число:  ","Ошибка ввода!");
int userNum2 = GetNumberFromUser("Введите второе целое положительное число:  ","Ошибка ввода!");

PrintNaturalNumbers(userNum1, userNum2);

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



