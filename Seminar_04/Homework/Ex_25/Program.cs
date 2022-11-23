// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.Clear();
int numA = GetNumberFromUser("Введите целое число A: ","Ошибка ввода!");
int numB = GetNumberFromUser("Введите целое число B: ","Ошибка ввода!");
int result = ApowB(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {result}");

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

// Возвращает А в степени В, рассчет через цикл
int ApowB(int number1, int number2)
{
    int product = 1;
    
    for (int i = 0; i < number2; i ++) product *= number1;

    return product;
}