// 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

Console.Clear();

int userNum = GetNumberFromUser("Введите целое положительное число: ","Ошибка ввода!");


int digitSum = FindDigitsSum(userNum);
Console.Write($"Сумма цифр числа {userNum} составляет {digitSum}");

int FindDigitsSum(int num)
{
    
    if(num == 0) return 0;
    else return num % 10 + FindDigitsSum(num / 10);
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
