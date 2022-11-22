// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.Clear();
int num = GetNumberFromUser("Введите целое число: ","Ошибка ввода!");
int digitsNumber = GetDigitsNumber(num);
Console.WriteLine($"{num} -> {digitsNumber}");

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

// Возвращает количество цифр в числе number
int GetDigitsNumber(int number)
{
    int count = 0;
    do 
    {
        count ++;
        number /= 10;
    }
    while (number != 0);
    
    return count;
}