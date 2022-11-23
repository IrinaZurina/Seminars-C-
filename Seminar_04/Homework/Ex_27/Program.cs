// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int digitsSum = GetDigitsSum(num);
Console.WriteLine($"{num} -> {digitsSum}");

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

// Возвращает сумму цифр в числе number
int GetDigitsSum(int number)
{
    int total = 0;
    do 
    {
        total += number % 10;
        number /= 10;
    }
    while (number != 0);
    
    return total;
}