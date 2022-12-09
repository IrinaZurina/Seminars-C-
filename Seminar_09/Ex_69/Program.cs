// 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
Console.Clear();

int userNum1 = GetNumberFromUser("Введите первое целое положительное число:  ","Ошибка ввода!");
int userNum2 = GetNumberFromUser("Введите второе целое положительное число:  ","Ошибка ввода!");

int num1PowNum2 = FindNum1PowNum2(userNum1, userNum2);
Console.WriteLine($"{userNum1} в степени {userNum2} = {num1PowNum2}");

int FindNum1PowNum2(int num1, int num2)
{
    if (num2 == 0) return 1;
    else if (num2 == 1) return num1;
    else return num1 * FindNum1PowNum2(num1, num2 - 1);
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
